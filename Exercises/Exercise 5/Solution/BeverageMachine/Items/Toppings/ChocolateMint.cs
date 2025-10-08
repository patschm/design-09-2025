using BeverageMachine.Items.Syrups;

namespace BeverageMachine.Items.Toppings;

public class ChocolateMint : Topping
{
    public ChocolateMint(Beverage beverage) : base(beverage)
    {
    }
    public override float? Price => .5F + base.Price;

    public override void Brew()
    {
        base.Brew();
        Console.WriteLine($"Topping of with {nameof(ChocolateMint)}");
    }
}
