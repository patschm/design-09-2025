namespace BeverageMachine.Items.Sauces;

public class DarkCaramel : Sauce
{
    public DarkCaramel(Beverage beverage) : base(beverage)
    {
    }
    public override float? Price => .3F + base.Price;

    public override void Brew()
    {
        base.Brew();
        Console.WriteLine($"Adding flavour {nameof(DarkCaramel)}");
    }
}
