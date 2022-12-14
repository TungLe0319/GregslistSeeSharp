namespace GregslistSeeSharp.Services;
public class HomesService
{
  private readonly HomesRepository _homesRepository;

  public HomesService(HomesRepository homesRepository)
  {
    _homesRepository = homesRepository;
  }

  // public List<Home> GetHomes()
  // {

  //   return _homesRepository.GetHomes();
  // }

  public Home GetHomeById(int id)
  {
    Home house = _homesRepository.GetHomeById(id);

    if (house == null)
    {
      throw new Exception("no home found");
    }
   return house;
  }

  public Home RemoveHome(int id,Account userInfo)
  {
   
    Home home = this.GetHomeById(id);
    if (home.SellerId != userInfo.Id)
    {
      throw new Exception("not your listing");
    }
    return _homesRepository.RemoveHome(id);
  }

  public Home CreateHome(Home homeData)
  {

    return _homesRepository.CreateHome(homeData);
  }

  public Home UpdateHome(Home homeData)
  {
    Home original = this.GetHomeById(homeData.Id);
   original.Bathrooms = homeData.Bathrooms?? original.Bathrooms;
   original.Bedrooms = homeData.Bedrooms?? original.Bedrooms;
   original.Levels = homeData.Levels?? original.Levels;
   original.Price = homeData.Price?? original.Price;
   original.Description = homeData.Description?? original.Description;
   original.ImgUrl = homeData.ImgUrl?? original.ImgUrl;
  
   
    return _homesRepository.UpdateHome(original);
  }

  public List<Home> GetHomesBySellerId(string sellerId)
  {

return _homesRepository.GetHomesBySellerId(sellerId);
  }
}