namespace GregslistSeeSharp.Controllers;

[ApiController]
[Route("api/[controller]")]
public class HomesController : ControllerBase
{
  private readonly HomesService _homesService;

  public HomesController(HomesService homesService)
  {
    _homesService = homesService;
  }



  



  [HttpGet]
  public ActionResult<List<Home>> Get()
  {
    try
    {



      List<Home> homes = _homesService.GetHomes();
      return Ok(homes);
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }



  [HttpGet("{id}")]
  public ActionResult<Car> GetHomeById(int id)
  {
    try
    {
      Home home = _homesService.GetHomeById(id);
      return Ok(home);
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }




    [HttpDelete("{id}")]
    public ActionResult<Home> RemoveHome(int id)
    {
      try
      {
        Home home = _homesService.RemoveHome(id);
        return Ok(home);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }







  [HttpPost]
  public ActionResult<List<Car>> Create([FromBody] Car carData)
  {
    try
    {
      Car car = _carsService.CreateCar(carData);
      return Ok(car);
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }



  [HttpPut("{id}")]
  public ActionResult<List<Car>> UpdateCar([FromBody] Car carData,int id)
  {
    try
    {
      carData.Id = id;
     
      return Ok(_carsService.UpdateCar(carData));
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }


}

