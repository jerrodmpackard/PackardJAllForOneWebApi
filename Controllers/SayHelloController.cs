using Microsoft.AspNetCore.Mvc;
using PackardJAllForOneWebApi.Services;

namespace PackardJAllForOneWebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class SayHelloController : Controller
{
    private readonly ISayHelloService _sayHelloService;

    public SayHelloController(ISayHelloService sayHelloService)
    {
        _sayHelloService = sayHelloService;
    }

    [HttpGet]
    [Route("SayHello/{name}")]

    public string SayHello(string name)
    {
        return _sayHelloService.SayHello(name);
    }
}
