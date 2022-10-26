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
}