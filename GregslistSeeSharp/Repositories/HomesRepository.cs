namespace GregslistSeeSharp.Repositories;

public class HomesRepository{

  private readonly IDbConnection _db;

  public HomesRepository(IDbConnection db)
  {
    _db = db;
  }

  public List<Home> GetHomes()
  {
    var sql = "SELECT * FROM houses";

    return  _db.Query<Home>(sql).ToList();
  }

  public Home GetHomeById(int id)
  {
   var sql = "SELECT * FROM houses WHERE id = @id";
   return _db.QueryFirstOrDefault<Home>(sql, new {id});
  }

  public Home RemoveHome(int id)
  {
    Home home = this.GetHomeById(id);
    var sql = "DELETE FROM houses WHERE id = @id";
    int houseRow = _db.Execute(sql);

    if (houseRow == 0 )
    {
      throw new Exception("home was found but not deleted");
    }
    return home; 
  }

  public Home CreateHome(Home homeData)
  {
    var sql = @"INSERT INTO homes(bathrooms,bedrooms,levels,year,price,description,imgUrl)
    VALUES(@Bathrooms,@Bedrooms,@Levels,@Year,@price,@Description,@ImgUrl);
    SELECT_LAST_INSERT_ID()";

    homeData.Id = _db.ExecuteScalar<int>(sql, homeData);
   return  homeData;
  }

  public Home UpdateHome(Home homeData)
  {
      string sql = @"UPDATE cars SET
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