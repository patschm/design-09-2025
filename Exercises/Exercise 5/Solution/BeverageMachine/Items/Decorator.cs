
namespace BeverageMachine.Items;

public class Decorator: Beverage
{
    protected readonly Beverage? _beverage;

    public Decorator(Beverage? beverage)
    {
        _beverage = beverage;
    }

    public override float? Price { get; }

    public override void Brew()
    {
       _beverage?.Brew();
    }
}
