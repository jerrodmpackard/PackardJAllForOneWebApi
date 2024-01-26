namespace PackardJAllForOneWebApi.Services.OddOrEven;

public class OddOrEvenService : IOddOrEvenService
{
    public string OddOrEven(string number)
    {
        double isANumber = 0;

        bool success = double.TryParse(number, out isANumber);

        if (success)
        {
            if (isANumber % 2 == 0)
            {
                return $"{isANumber} is even.";
            }
            else
            {
                return $"{isANumber} is odd.";
            }
        }
        else
        {
            return "Please make sure you are entering a number.";
        }
    }
}
