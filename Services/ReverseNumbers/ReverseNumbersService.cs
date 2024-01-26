namespace PackardJAllForOneWebApi.Services.ReverseNumbers;

public class ReverseNumbersService : IReverseNumbersService
{
    public string ReverseNumbers(string number)
    {
        double inputNumber = 0;

        bool success = double.TryParse(number, out inputNumber);

        if (success)
        {
            string reversed = "";

            for (int i = number.Length - 1; i >= 0; i--)
            {
                reversed += number[i];
            }

            return $"You entered {number}. Your number reversed is {reversed}.";
        }
        else
        {
            return "Please make sure you are entering a number.";
        }

    }
}
