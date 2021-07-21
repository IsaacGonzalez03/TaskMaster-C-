using System.Collections.Generic;
using System.Threading.Tasks;
using CodeWorks.Auth0Provider;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TaskMaster.Models;
using TaskMaster.Services;

namespace TaskMaster.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class ProjectsController : ControllerBase
  {
    private readonly ProjectsService _ps;

    public ProjectsController(ProjectsService ps)
    {
      _ps = ps;
    }
    [Authorize]
    [HttpPost]
    public async Task<ActionResult<Project>> Create([FromBody] Project projectData)
    {
      try
      {
        Account userInfo = await HttpContext.GetUserInfoAsync<Account>();
        projectData.CreatorId = userInfo.Id;
        var p = _ps.Create(projectData);
        return Ok(p);
      }
      catch (System.Exception e)
      {
        return BadRequest(e.Message);
      }
    }
    [Authorize]
    [HttpGet]
    public ActionResult<List<Project>> GetAll()
    {
      try
      {
        List<Project> projects = _ps.GetAll();
        return Ok(projects);
      }
      catch (System.Exception e)
      {
        return BadRequest(e.Message);
      }
    }
  }
}