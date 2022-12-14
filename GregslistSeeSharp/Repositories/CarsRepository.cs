namespace GregslistSeeSharp.Repositories;

public class CarsRepository : BaseRepository
{
  public CarsRepository(IDbConnection db) : base(db)
  {
  }



  public List<Car> GetCars()
  {
    var sql = "SELECT * FROM cars";
    return _db.Query<Car>(sql).ToList();
  }


  public Car CreateCar(Car carData)
  {
    var sql = @"
    INSERT INTO cars(make,model,year,price,description,imgUrl,sellerId)
    VALUES(@Make,@Model,@Year,@Price,@Description,@ImgUrl,@SellerId);
    SELECT LAST_INSERT_ID();";
    // RUN COMMAND AND THEN DO A SELECT...
    carData.Id = _db.ExecuteScalar<int>(sql, carData);
    return carData;
  }


  public Car GetCarById(int id)
  {
    var sql = @"SELECT * FROM cars WHERE id = @id";
    return _db.QueryFirstOrDefault<Car>(sql, new { id });

  }


  public List<Car> GetCarsBySellerId(string sellerId)
  {
    var sql = @"SELECT * FROM cars WHERE sellerId = @sellerId";
    return _db.Query<Car>(sql, new { sellerId }).ToList();

  }




  public Car RemoveCar(int id)
  {
    var car = GetCarById(id);
    // id = car.Id;
    var sql = @"DELETE FROM cars WHERE id = @id";

    _db.Execute(sql, new { id });
    return car;
  }

  public Car UpdateCar(Car carData)
  {
    string sql = @"
        UPDATE cars SET
                make = @make,
                model = @model,
                year = @year,
                price = @price,
                imgUrl = @imgUrl,
                description = @description      
            WHERE id = @id;
        ";
    _db.Execute(sql, carData);
    // if (carRow == 0)
    // {
    //   throw new Exception("unable to edit this car");
    // }
    return carData;
  }

}
// UPDATE cats SET
//   name = "Felix the Cat"
// WHERE id = 3;

