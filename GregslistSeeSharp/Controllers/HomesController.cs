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
  public ActionResult<List<Home>> Create([FromBody] Home homeData)
  {
    try
    {
      Home home  = _homesService.CreateHome(homeData);
      return Ok(home);
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }



  [HttpPut("{id}")]
  public ActionResult<List<Home>> Update([FromBody] Home homeData,int id)
  {
    try
    {
      homeData.Id = id;
      Home home = _homesService.UpdateHome(homeData);
     
      return Ok();
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }


}

