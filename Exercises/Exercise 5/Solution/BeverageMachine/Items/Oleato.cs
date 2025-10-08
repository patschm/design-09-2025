namespace BeverageMachine.Items;

public class Oleato : Beverage
{
    public override float? Price => 3.5F;

    public override void Brew()
    {
        Console.WriteLine($"Brewing {nameof(Oleato)}...");
    }
}
