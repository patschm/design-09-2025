
namespace DecoratorNS;

internal class TwitterDecorator : Decorator
{
    
    public TwitterDecorator(Component wrapper) : base(wrapper)
    {
  
    }

    public override void Send(string text)
    {
        base.Send(text);
        _wrapper.Send($"Sending to Twitter: {text}.");
    }
}
