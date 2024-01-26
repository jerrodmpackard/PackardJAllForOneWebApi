namespace PackardJAllForOneWebApi.Services.GreaterOrLess;

public class GreaterOrLessService : IGreaterOrLessService
{
    public string GreaterOrLess(string num1, string num2)
    {
        double isANumber1 = 0;
        double isANumber2 = 0;

        bool success = double.TryParse(num1, out isANumber1) && double.TryParse(num2, out isANumber2);

        if (success)
        {
            if (isANumber1 == isANumber2)
            {
                return $"{isANumber1} is equal to {isANumber2}. \n{isANumber2} is equal to {isANumber1}.";
            }
            else if (isANumber1 > isANumber2)
            {
                return $"{isANumber1} is greater than {isANumber2}. \n{isANumber2} is less than {isANumber1}.";
            }
            else
            {
                return $"{isANumber1} is less than {isANumber2}. \n{isANumber2} is greater than {isANumber1}.";
            }
        }
        else
        {
            return "Please make sure both inputs are numbers.";
        }
    }
}
