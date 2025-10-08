namespace DecoratorNS
{
    public class Component
    {
        public virtual void Send(string text)
        {
            Console.WriteLine($"{text}");
        }
    }
}