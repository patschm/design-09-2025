using BeverageMachine.Items.Sweeteners;

namespace BeverageMachine.Items.Syrups;

public class Caramel : Syrup
{
    public Caramel(Beverage beverage) : base(beverage)
    {
    }
    public override float? Price => .5F + base.Price;

    public override void Brew()
    {
        base.Brew();
        Console.WriteLine($"Adding {nameof(Caramel)} Syrup");
    }
}
