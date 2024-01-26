using Microsoft.AspNetCore.Mvc;
using PackardJAllForOneWebApi.Services.SumTwoNumbers;

namespace PackardJAllForOneWebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class SumTwoNumbersController : ControllerBase
{
    private readonly ISumTwoNumbersService _sumTwoNumbersService;

    public SumTwoNumbersController(ISumTwoNumbersService sumTwoNumbersService)
    {
        _sumTwoNumbersService = sumTwoNumbersService;
    }

    [HttpGet]
    [Route("SumTwoNumbers/{num1}/{num2}")]
    public string SumTwoNumbers(string num1, string num2)
    {
        return _sumTwoNumbersService.SumTwoNumbers(num1, num2);
    }
}
