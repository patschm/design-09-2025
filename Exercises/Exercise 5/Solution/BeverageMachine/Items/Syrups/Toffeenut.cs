namespace BeverageMachine.Items.Syrups;

public class Toffeenut : Syrup
{
    public Toffeenut(Beverage beverage) : base(beverage)
    {
    }
    public override float? Price => .4F + base.Price;

    public override void Brew()
    {
        base.Brew();
        Console.WriteLine($"Adding {nameof(Toffeenut)} Syrup");
    }
}
