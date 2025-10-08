namespace BeverageMachine.Items.Sweeteners;

public class Stevia : Sweetener
{
    public Stevia(Beverage beverage) : base(beverage)
    {
    }
    public override float? Price => 1.1F + base.Price;

    public override void Brew()
    {
        base.Brew();
        Console.WriteLine($"Sweetening with {nameof(Stevia)}");
    }
}
