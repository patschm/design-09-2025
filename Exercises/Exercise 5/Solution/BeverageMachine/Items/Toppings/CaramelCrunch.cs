namespace BeverageMachine.Items.Toppings;

public class CaramelCrunch : Topping
{
    public CaramelCrunch(Beverage beverage) : base(beverage)
    {
    }
    public override float? Price => .5F + base.Price;

    public override void Brew()
    {
        base.Brew();
        Console.WriteLine($"Topping of with {nameof(CaramelCrunch)}");
    }
}
