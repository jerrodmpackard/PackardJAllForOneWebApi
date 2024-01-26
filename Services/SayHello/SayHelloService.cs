namespace PackardJAllForOneWebApi.Services;

public class SayHelloService : ISayHelloService
{
    public string SayHello(string name)
    {
        return $"Hello, {name}. Nice to meet you!";
    }
}
