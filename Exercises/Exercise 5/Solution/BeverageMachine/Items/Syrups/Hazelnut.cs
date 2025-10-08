namespace BeverageMachine.Items.Syrups;

public class Hazelnut : Syrup
{
    public Hazelnut(Beverage beverage) : base(beverage)
    {
    }
    public override float? Price => .5F + base.Price;

    public override void Brew()
    {
        base.Brew();
        Console.WriteLine($"Adding {nameof(Hazelnut)} Syrup");
    }
}
