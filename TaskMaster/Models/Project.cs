namespace TaskMaster.Models
{
  public class Project
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public string CreatorId { get; set; }
    public Profile Creator { get; set; }
  }
}