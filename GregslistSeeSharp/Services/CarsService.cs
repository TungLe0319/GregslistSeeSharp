namespace GregslistSeeSharp.Services;

public class CarsService
{
  //REPOSITORY PATTERN
  //will be used to control communication with the DB



  private readonly CarsRepository _carsRepo;

  public CarsService(CarsRepository carsRepo)
  {
    _carsRepo = carsRepo;
  }

  public List<Car> GetCars()
  {
    return _carsRepo.GetCars();
  }
  public Car CreateCar(Car carData)
  {
    return _carsRepo.CreateCar(carData);
  }

  public Car GetCarById(int id)
  {
    var car = _carsRepo.GetCarById(id);

    if (car == null)
    {
      throw new Exception("Invalid Id [GetCarById]");
    }




    return car;
  }

public List<Car> GetCarsBySellerId(string sellerId){
return _carsRepo.GetCarsBySellerId(sellerId);
}



  public Car RemoveCar(int id)
  {
    var car = _carsRepo.GetCarById(id);

    if (car == null)
    {
      throw new Exception("Invalid Id [GetCarById]");
    }

    return _carsRepo.RemoveCar(id);
  }


  public Car UpdateCar(Car carData,Account userInfo)
  {

if (carData.SellerId != userInfo.Id)
{
  throw new Exception("You Are Not The Owner Of This Listing");
} 

    
    Car original = GetCarById(carData.Id);
    original.Make = carData.Make ?? original.Make;
    original.Model = carData.Model ?? original.Model;
    original.Year = carData.Year ;
    original.Price = carData.Price ;
    original.ImgUrl = carData.ImgUrl ?? original.ImgUrl;
    original.Description = carData.Description ?? original.Description;
    return _carsRepo.UpdateCar(original);
  }

}