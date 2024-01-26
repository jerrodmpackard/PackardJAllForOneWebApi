using Microsoft.AspNetCore.Mvc;
using PackardJAllForOneWebApi.Services.GreaterOrLess;

namespace PackardJAllForOneWebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class GreaterOrLessController : ControllerBase
{
    private readonly IGreaterOrLessService _greaterOrLessService;

    public GreaterOrLessController(IGreaterOrLessService greaterOrLessService)
    {
        _greaterOrLessService = greaterOrLessService;
    }

    [HttpGet]
    [Route("GreaterOrLess/{num1}/{num2}")]
    public string GreaterOrLess(string num1, string num2)
    {
        return _greaterOrLessService.GreaterOrLess(num1, num2);
    }
}
