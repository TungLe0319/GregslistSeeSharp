import { AppState } from "../AppState.js";
import { Car } from "../models/Car.js";
import { api } from "./AxiosService.js";

class CarsService {
  //  /api/classifieds/listingType=Cars
  async getCars() {
    const res = await api.get("/api/cars");
    console.log(res.data);
    AppState.cars = res.data.map((c) => new Car(c));
  }
  async createCar(carData) {
    const res = await api.post("/api/cars", carData);
    console.log(res.data);
    AppState.cars = [new Car(res.data), ...AppState.cars];
  }
  async deleteCar(carId){
    const res = await api.delete(`/api/cars/${carId}`)
    console.log(res.data);
    AppState.cars = AppState.cars.filter(c => c.id != carId)
  }
  makeActive(carData){
    AppState.activeListing = carData
    
  }

  async editCar(carData){

const res = await api.put(`/api/cars/${carData.id}`,carData)
console.log(res.data);
 let index = AppState.cars.findIndex(c => c.id == carData.id)

 AppState.cars.splice(index,1,new Car(res.data))
  }
}

export const carsService = new CarsService();
