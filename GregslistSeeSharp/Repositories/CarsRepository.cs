namespace GregslistSeeSharp.Repositories;

public class CarsRepository
{
  private readonly IDbConnection _db;

  public CarsRepository(IDbConnection db)
  {
    _db = db;
  }

  public List<Car> GetCars()
  {
    var sql = "SELECT * FROM cars";
    return _db.Query<Car>(sql).ToList();
  }


  public Car CreateCar(Car carData)
  {
    var sql =  @"
    INSERT INTO cars(make,model,year,price,description,imgUrl)
    VALUES(@Make,@Model,@Year,@Price,@Description,@ImgUrl);
    SELECT_LAST_INSERT_ID(); 
";
// RUN COMMAND AND THEN DO A SELECT...
    carData.Id = _db.ExecuteScalar<int>(sql, carData);
    return carData;
  }

}