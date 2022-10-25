import { AppState } from "../AppState.js"
import { House } from "../models/House.js"
import { api } from "./AxiosService.js"

class HousesService {
  async getHouses() {
    const res = await api.get('/api/houses');
    AppState.houses = res.data.map((h) => new House(h));
  }

  async addHouse(editable) {
    const res = await api.post('/api/houses');
    // let job = new Job(res.data)
    //AppState.jobs = [...AppState.jobs, job]
  }
}

export const housesService = new HousesService()