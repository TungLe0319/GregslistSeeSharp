namespace GregslistSeeSharp.Controllers;

[ApiController]
[Authorize]
[Route("api/[controller]")]
public class CarsController : ControllerBase
{
  private readonly CarsService _carsService;
  private readonly Auth0Provider _auth0Provider;

  // Dependency Injection... DONT FORGET TO ADD INTO startup.cs
  public CarsController(CarsService carsService, Auth0Provider auth0Provider)
  {
    _carsService = carsService;
    _auth0Provider = auth0Provider;
  }


  [HttpGet]
  public async Task<ActionResult<List<Car>>> Get()
  {
    try
    {

      var userInfo = await _auth0Provider.GetUserInfoAsync<Account>(HttpContext);
// var cars = _carsService.GetCarBySellerId

      List<Car> cars = _carsService.GetCars();
      return Ok(cars);


    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }



  [HttpGet("{id}")]
  public async  Task<ActionResult<Car>> GetCarById(int id)
  {
    try
    {
      var userInfo = await _auth0Provider.GetUserInfoAsync<Account>(HttpContext);
      Car car = _carsService.GetCarById(id);
      return Ok(car);
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }




  [HttpDelete("{id}")]
  public async Task<ActionResult<Car>> RemoveCar(int id)
  {
    try
    {
      var userInfo = await _auth0Provider.GetUserInfoAsync<Account>(HttpContext);
 
      
      Car car = _carsService.RemoveCar(id);
      return Ok(car);
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }







  [HttpPost]
  public  async Task<ActionResult<List<Car>>> Create([FromBody] Car carData)
  {
    try
    {
      var userInfo = await _auth0Provider.GetUserInfoAsync<Account>(HttpContext);
      carData.SellerId = userInfo?.Id;



      //Make sure to now add <Task<ActionResult<Example/Character>>>  
      
      Car car = _carsService.CreateCar(carData);
      return Ok(car);
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }



  [HttpPut("{id}")]
  public async  Task<ActionResult<List<Car>>> UpdateCar([FromBody] Car carData, int id)
  {
    try
    {
    await _auth0Provider.GetUserInfoAsync<Account>(HttpContext);
   
      
      carData.Id = id;

      return Ok(_carsService.UpdateCar(carData));
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }


}
