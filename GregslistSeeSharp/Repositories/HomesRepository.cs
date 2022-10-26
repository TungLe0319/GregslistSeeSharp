namespace GregslistSeeSharp.Repositories;

public class HomesRepository{

  private readonly IDbConnection _db;

  public HomesRepository(IDbConnection db)
  {
    _db = db;
  }

  public List<Home> GetHomes()
  {
    var sql = "SELECT * FROM homes";

    return  _db.Query<Home>(sql).ToList();
  }



  public List<Home> GetHomesBySellerId(string sellerId)
  {
    var sql = "SELECT * FROM homes WHERE sellerId = @sellerId";
    return _db.Query<Home>(sql, new { sellerId }).ToList();
  }



  public Home GetHomeById(int id)
  {
   var sql = "SELECT * FROM homes WHERE id = @id";
   return _db.QueryFirstOrDefault<Home>(sql, new {id});
  }

  public Home RemoveHome(int id)
  {
    var home = GetHomeById(id);
    var sql = @"DELETE FROM homes WHERE id = @id";
   int houseRow = _db.Execute(sql, new {id});

    if (houseRow == 0 )
    {
      throw new Exception("home was found but not deleted");
    }
    return home; 
  }

  public Home CreateHome(Home homeData)
  {
    var sql = @"
    INSERT INTO homes(bathrooms,bedrooms,levels,year,price,description,imgUrl)
    VALUES(@Bathrooms,@Bedrooms,@Levels,@Year,@price,@Description,@ImgUrl);
    SELECT LAST_INSERT_ID();";

    homeData.Id = _db.ExecuteScalar<int>(sql, homeData);
   return  homeData;
  }

  public Home UpdateHome(Home homeData)
  {
      string sql = @"UPDATE homes SET
                bathrooms = @bathrooms,
                bedrooms = @bedrooms,
                levels = @levels,
                year = @year,
                price = @price,
                description = @description,    
                imgUrl = @imgUrl
            WHERE id = @id";
            int homesRow = _db.Execute(sql, homeData);
            if (homesRow == 0)
            {
              throw new Exception("could not update home properly");
            }
    return homeData;
  }

}