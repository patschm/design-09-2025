namespace BeverageMachine.Items.Syrups;

public class Vanilla : Syrup
{
    public Vanilla(Beverage beverage) : base(beverage)
    {
    }
    public override float? Price => .5F + base.Price;

    public override void Brew()
    {
        base.Brew();
        Console.WriteLine($"Adding {nameof(Vanilla)} Syrup");
    }
}
