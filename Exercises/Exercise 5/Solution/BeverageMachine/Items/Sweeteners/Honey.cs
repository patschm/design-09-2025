using BeverageMachine.Items.Sauces;

namespace BeverageMachine.Items.Sweeteners;

public class Honey : Sweetener
{
    public Honey(Beverage beverage) : base(beverage)
    {
    }
    public override float? Price => .5F + base.Price;

    public override void Brew()
    {
        base.Brew();
        Console.WriteLine($"Sweetening with {nameof(Honey)}");
    }
}
