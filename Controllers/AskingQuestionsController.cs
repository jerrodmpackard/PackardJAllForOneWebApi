using Microsoft.AspNetCore.Mvc;
using PackardJAllForOneWebApi.Services.AskingQuestions;

namespace PackardJAllForOneWebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class AskingQuestionsController : ControllerBase
{
    private readonly IAskingQuestionsService _askingQuestionsService;

    public AskingQuestionsController(IAskingQuestionsService askingQuestionsService)
    {
        _askingQuestionsService = askingQuestionsService;
    }

    [HttpGet]
    [Route("AskingQuestions/{name}/{wakeUpTime}")]

    public string AskingQuestions(string name, string wakeUpTime)
    {
        return _askingQuestionsService.AskingQuestions(name, wakeUpTime);
    }
}
