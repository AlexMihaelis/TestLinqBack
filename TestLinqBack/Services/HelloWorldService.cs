using TestLinqBack.Contracts;

namespace TestLinqBack.Services;

public class HelloWorldService : IHelloWorldService
{
    public string GetHelloWorld(string name)
        => $"{name} сказал привет мир, но не на пендосском!)";
}