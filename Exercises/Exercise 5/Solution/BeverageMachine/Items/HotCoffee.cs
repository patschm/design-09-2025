namespace BeverageMachine.Items;

public class HotCoffee : Beverage
{
    public override float? Price => 3;

    public override void Brew()
    {
        Console.WriteLine($"Brewing {nameof(HotCoffee)}...");
    }
}
