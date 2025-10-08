namespace DecoratorNS;

internal class FacebookDecorator: Decorator
{
   
    public FacebookDecorator(Component wrapper) : base(wrapper)
    {
        
    }

    public override void Send(string text)
    {
        base.Send(text);
        _wrapper.Send($"Sending to Facebook: {text}");
    }
}
