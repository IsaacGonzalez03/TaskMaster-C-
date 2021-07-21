using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dapper;
using TaskMaster.Models;

namespace TaskMaster.Repositories
{
  public class ProjectsRepository
  {
    private readonly IDbConnection _db;
    public ProjectsRepository(IDbConnection db)
    {
      _db = db;
    }
    public Project Create(Project data)
    {
      var sql = @"
      INSERT INTO projects
      (name, creatorId)
      VALUES (@Name, @CreatorId);
      SELECT LAST_INSERT_ID();
      ";
      var id = _db.ExecuteScalar<int>(sql, data);
      data.Id = id;
      return data;
    }
    public List<Project> GetAll()
    {
      var sql = "SELECT * FROM projects";
      return _db.Query<Project>(sql).ToList();
    }
  }
}