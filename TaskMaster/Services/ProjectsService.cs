using System.Collections.Generic;
using TaskMaster.Models;
using TaskMaster.Repositories;

namespace TaskMaster.Services
{
  public class ProjectsService
  {
    private readonly ProjectsRepository _pr;

    public ProjectsService(ProjectsRepository pr)
    {
      _pr = pr;
    }
    public Project Create(Project projectData)
    {
      var project = _pr.Create(projectData);
      return project;
    }
    public List<Project> GetAll()
    {
      return _pr.GetAll();
    }
  }
}