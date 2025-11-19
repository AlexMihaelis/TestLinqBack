using Microsoft.AspNetCore.Mvc;
using TestLinqBack.Contracts;
using TestLinqBack.Data;
using TestLinqBack.Models.Enums;

namespace TestLinqBack.Controllers;

public class ProjectController : ControllerBase
{
    private readonly IProjectService _projectService;

    public ProjectController(IProjectService projectService)
    {
        _projectService = projectService;
    }

    [HttpGet("api/project/get-project-documents")]
    public IActionResult GetDocProjects()
    {
        return Ok(_projectService.GetDocProjects());
    }

    [HttpGet("api/project/get-projects")]
    public IActionResult GetProjects(string name, ProjectStatus status)
    {
        return Ok(_projectService.GetProjects(name, status));
    }
    
    [HttpGet("api/project/get-projects-no-documents")]
    public IActionResult GetProjectsNoDocuments()
    {
        return Ok(_projectService.GetProjectsNoDocuments());
    }
    
    [HttpGet("api/project/get-expenses-profit-sum-projects")]
    public IActionResult GetExpensesProfitSumProjects()
    {
        return Ok(_projectService.GetExpensesProfitSumProjects());
    }
    
    [HttpGet("api/project/get-all-projects-by-user")]
    public IActionResult GetAllProjectsByUser(int userId)
    {
        return Ok(_projectService.GetAllProjectsByUser(userId));
    }

    [HttpGet("api/project/get-projects-by-manager")]
    public IActionResult GetManagerProjects(int managerId)
    {
        return Ok(_projectService.GetManagerProjects(managerId));
    }
}