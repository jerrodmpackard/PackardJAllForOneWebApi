using Microsoft.AspNetCore.Mvc;
using PackardJAllForOneWebApi.Services.ReverseNumbers;

namespace PackardJAllForOneWebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class ReverseNumbersController : ControllerBase
{
    private readonly IReverseNumbersService _reverseNumbersService;

    public ReverseNumbersController(IReverseNumbersService reverseNumbersService)
    {
        _reverseNumbersService = reverseNumbersService;
    }

    [HttpGet]
    [Route("ReverseNumbers/{number}")]

    public string ReverseNumbers(string number)
    {
        return _reverseNumbersService.ReverseNumbers(number);
    }
}
