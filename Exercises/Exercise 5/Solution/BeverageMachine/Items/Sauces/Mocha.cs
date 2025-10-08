namespace BeverageMachine.Items.Sauces;

public class Mocha : Sauce
{
    public Mocha(Beverage beverage) : base(beverage)
    {
    }
    public override float? Price => .3F + base.Price;

    public override void Brew()
    {
        base.Brew();
        Console.WriteLine($"Adding flavour {nameof(Mocha)}");
    }
}
