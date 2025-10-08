namespace BeverageMachine.Items.Sweeteners;

public abstract class Sweetener : Decorator
{
    protected Sweetener(Beverage beverage) : base(beverage)
    {
    }
    public override float? Price => base.Price;
}
