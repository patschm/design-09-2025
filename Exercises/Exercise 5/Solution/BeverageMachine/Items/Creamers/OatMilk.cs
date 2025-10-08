namespace BeverageMachine.Items.Creamers;

public class OatMilk : Creamer
{
    public OatMilk(Beverage beverage) : base(beverage)
    {
    }
    public override float? Price => .5F + base.Price;

    public override void Brew()
    {
        base.Brew();
        Console.WriteLine($"Adding {nameof(OatMilk)}");
    }
}
