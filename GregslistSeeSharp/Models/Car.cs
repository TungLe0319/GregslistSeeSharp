namespace GregslistSeeSharp.Models;

public class Car
{

public DateTime CreatedAt { get; set; }
public DateTime UpdatedAt { get; set; }
public int Id { get; set; }
public string Make { get; set; }
public string Model { get; set; }
public int? Year { get; set; }
public decimal? Price { get; set; }
public string Description { get; set; }
public string ImgUrl { get; set; }
  public string  SellerId { get;  set; }

}
