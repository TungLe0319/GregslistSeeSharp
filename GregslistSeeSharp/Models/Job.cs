namespace GregslistSeeSharp.Models;

public class Job
{
  public int Id { get; set; }
  public string Company { get; set; }
  public string Title { get; set; }
  public int Hours { get; set; }
  public decimal Pay { get; set; }
  public string Description { get; set; }
  // public string ImgUrl { get; set; }

  public DateTime CreatedAt { get; set; }
  public DateTime UpdatedAt { get; set; }

}
