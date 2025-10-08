namespace BeverageMachine.Items.Creamers;

public abstract class Creamer : Decorator
{
    protected Creamer(Beverage beverage) : base(beverage)
    {
    }
    public override float? Price => base.Price;
}
