namespace BeverageMachine.Items.Sweeteners;

public class Sugar : Sweetener
{
    public Sugar(Beverage beverage) : base(beverage)
    {
    }
    public override float? Price => .2F + base.Price;

    public override void Brew()
    {
        base.Brew();
        Console.WriteLine($"Sweetening with {nameof(Sugar)}");
    }
}
