using Microsoft.AspNetCore.Mvc;
using PackardJAllForOneWebApi.Services.OddOrEven;

namespace PackardJAllForOneWebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class OddOrEvenController : ControllerBase
{
    private readonly IOddOrEvenService _oddOrEvenService;

    public OddOrEvenController(IOddOrEvenService oddOrEvenService)
    {
        _oddOrEvenService = oddOrEvenService;
    }

    [HttpGet]
    [Route("OddOrEven/{number}")]

    public string OddOrEven(string number)
    {
        return _oddOrEvenService.OddOrEven(number);
    }
}
