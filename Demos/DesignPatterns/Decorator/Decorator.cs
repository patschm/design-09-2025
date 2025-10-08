namespace DecoratorNS;

internal class Decorator : Component
{
    protected readonly Component _wrapper;
    public Decorator(Component wrapper)
    {
        _wrapper = wrapper;
    }

    //public override void SendMessage(string message)
    //{ 
    //}
}
