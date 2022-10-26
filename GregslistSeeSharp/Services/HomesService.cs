namespace GregslistSeeSharp.Services;
public class HomesService
{
  private readonly HomesRepository _homesRepository;

  public HomesService(HomesRepository homesRepository)
  {
    _homesRepository = homesRepository;
  }

  public List<Home> GetHomes()
  {

    return _homesRepository.GetHomes();
  }

  public Home GetHomeById(int id)
  {
    var house = _homesRepository.GetHomeById(id);

    if (house == null)
    {
      throw new Exception("no home found");
    }
   return house;
  }

  internal Home RemoveHome(int id)
  {
    throw new NotImplementedException();
  }
}