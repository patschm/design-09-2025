namespace BeverageMachine.Items.Creamers;

public class SoyMilk : Creamer
{
    public SoyMilk(Beverage beverage) : base(beverage)
    {
    }
    public override float? Price => .4F + base.Price;

    public override void Brew()
    {
        base.Brew();
        Console.WriteLine($"Adding {nameof(SoyMilk)}");
    }
}
