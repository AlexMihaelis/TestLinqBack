using Microsoft.AspNetCore.Mvc;
using TestLinqBack.Contracts;
using TestLinqBack.Data;

namespace TestLinqBack.Controllers;

[Controller]
public class TestProjectController : ControllerBase
{
    private readonly IHelloWorldService helloWorldService;
    
    public TestProjectController(IHelloWorldService helloWorldService)
        => this.helloWorldService = helloWorldService;
    
    [HttpGet("api/get-hello-world")]
    public IActionResult GetHelloWorld(string name)
        => Ok($"{name} say: Hello World!");
    
    [HttpGet("api/get-hello-world-from-service")]
    public IActionResult GetHelloWorldFromService(string name)
        => Ok(helloWorldService.GetHelloWorld(name));
    
    [HttpGet("api/get-users")]
    public IActionResult GetUsers()
        => Ok(LinqData.Users);
}