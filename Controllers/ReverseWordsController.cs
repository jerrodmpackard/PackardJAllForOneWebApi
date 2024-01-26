using Microsoft.AspNetCore.Mvc;
using PackardJAllForOneWebApi.Services.ReverseWords;

namespace PackardJAllForOneWebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class ReverseWordsController : ControllerBase
{
    private readonly IReverseWordsService _reverseWordsService;

    public ReverseWordsController(IReverseWordsService reverseWordsService)
    {
        _reverseWordsService = reverseWordsService;
    }

    [HttpGet]
    [Route("ReverseWords/{word}")]

    public string ReverseWords(string word)
    {
        return _reverseWordsService.ReverseWords(word);
    }
}
