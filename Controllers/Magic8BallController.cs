using Microsoft.AspNetCore.Mvc;
using PackardJAllForOneWebApi.Services.Magic8Ball;

namespace PackardJAllForOneWebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class Magic8BallController : ControllerBase
{
    private readonly IMagic8BallService _magic8BallService;

    public Magic8BallController(IMagic8BallService magic8BallService)
    {
        _magic8BallService = magic8BallService;
    }

    [HttpGet]
    [Route("Magic8Ball/{question}")]

    public string Magic8Ball(string question)
    {
        return _magic8BallService.Magic8Ball(question);
    }
}
