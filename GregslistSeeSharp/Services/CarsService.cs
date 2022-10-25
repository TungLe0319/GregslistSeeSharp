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
    return null;
  }

}