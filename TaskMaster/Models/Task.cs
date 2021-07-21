namespace TaskMaster.Models
{
  public class Task
  {
    public int Id { get; set; }
    public string AccountId { get; set; }
    public int BoardId { get; set; }
    public string CreatorId { get; set; }
    public Profile Creator { get; set; }
  }
}