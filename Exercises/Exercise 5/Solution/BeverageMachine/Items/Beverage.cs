namespace BeverageMachine.Items;

public abstract class Beverage
{
    public abstract float? Price { get; }
    public abstract void Brew();
}
