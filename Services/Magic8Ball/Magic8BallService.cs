namespace PackardJAllForOneWebApi.Services.Magic8Ball;

public class Magic8BallService : IMagic8BallService
{
    public string Magic8Ball(string question)
    {
        string[] responses = {"Ask again later", "Yes", "No", "All signs point to yes...", "My sources say nope", "Better not tell you", "Very doubtful", "Outlook good"};
        
        Random randomClass = new Random();
        int responseChoice = randomClass.Next(0, 8);

        return responses[responseChoice];
    }
}
