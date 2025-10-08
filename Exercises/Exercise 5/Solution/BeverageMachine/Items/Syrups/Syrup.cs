namespace BeverageMachine.Items.Syrups;

public abstract class Syrup : Decorator
{
    protected Syrup(Beverage beverage) : base(beverage)
    {
    }
    public override float? Price => base.Price;
}
