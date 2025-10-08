namespace BeverageMachine.Items;

public class HotTea : Beverage
{
    public override float? Price => 3;

    public override void Brew()
    {
        Console.WriteLine($"Brewing {nameof(HotTea)}...");
    }
}
