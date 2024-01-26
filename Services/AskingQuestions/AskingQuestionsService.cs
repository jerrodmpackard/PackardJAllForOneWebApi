namespace PackardJAllForOneWebApi.Services.AskingQuestions;
public class AskingQuestionsService : IAskingQuestionsService
{
    public string AskingQuestions(string name, string wakeUpTime)
    {
        return $"Your name is {name} and you woke up at {wakeUpTime} today.";
    }
}
