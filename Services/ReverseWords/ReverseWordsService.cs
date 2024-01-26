namespace PackardJAllForOneWebApi.Services.ReverseWords;

public class ReverseWordsService : IReverseWordsService
{
    public string ReverseWords(string word)
    {
        string reversed = "";

        for(int i = word.Length - 1; i >= 0; i--)
        {
            reversed += word[i];
        }

        return $"You entered {word}. Your word reversed is {reversed}.";
    }
}
