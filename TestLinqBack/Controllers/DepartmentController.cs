using Microsoft.AspNetCore.Mvc;
using TestLinqBack.Contracts;

namespace TestLinqBack.Controllers;

public class DepartmentController : ControllerBase
{
    private readonly IDepartmentService _departmentService;

    public DepartmentController(IDepartmentService departmentService)
    {
        _departmentService = departmentService;
    }
    [HttpGet("api/department/get-deparment-salarys-sum")]
    public IActionResult GetDepartmentSalarysSum()
    {
        return Ok(_departmentService.GetDepartmentSalarysSum());
    }

    [HttpGet("api/department/get-department-max-avg-salarys")]
    public IActionResult GetDepartmentMaxAvgSalarys()
    {
        return Ok(_departmentService.GetDepartmentMaxAvgSalarys());
    }

    [HttpGet("api/department/get-department-with-active-projects")]
    public IActionResult GetDepartWithActiveProjects()
    {
        return Ok(_departmentService.GetDepartWithActiveProjects());
    }
}