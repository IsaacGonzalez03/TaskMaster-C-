namespace TaskMaster.Models
{
  public class Board
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public string CreatorId { get; set; }
    public Profile Creator { get; set; }
    public int ProjectId { get; set; }

  }
}