namespace DecoratorNS;

internal class Message : Component
{
    public override void Send(string text)
    {
        Console.WriteLine($"{text}");
    }
}
