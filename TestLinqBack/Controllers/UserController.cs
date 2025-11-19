using Microsoft.AspNetCore.Mvc;
using TestLinqBack.Contracts;
using TestLinqBack.Models.DTO;

namespace TestLinqBack.Controllers;

public class UserController : ControllerBase
{
    private readonly IUserService _userService;

    public UserController(IUserService userService)
    {
        _userService = userService;
    }

    [HttpGet ("api/users/get-user-salary")]
    public IActionResult GetUsersSalary(decimal salary)
    {
        return Ok(_userService.GetUsersSalary(salary));
    }

    [HttpGet("api/users/get-user-role")]
    public IActionResult GetUsersRole()
    {
        return Ok(_userService.GetUsersRole());
    }
    
    [HttpGet("api/users/get-frequent-role")]
    public IActionResult GetFrequentRole()
    {
        return Ok(_userService.GetFrequentRole());
    }

    [HttpGet("api/users/get-user-actual-projects")]
    public IActionResult GetUserActualProjects(int userId)
    {
        return Ok(_userService.GetUserActualProjects(userId));
    }
    
    [HttpGet("api/users/get-user-projects")]
    public IActionResult GetUserProject()
    {
        return Ok(_userService.GetUserProject());
    }
}