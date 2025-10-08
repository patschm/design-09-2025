namespace CarParts;

public class Composite : Part
{
    public Composite(float costPrice, TimeSpan productionTime)
        : base(costPrice, productionTime)
    {
    }

    private readonly List<Part> children = new List<Part>();
    public void Add(Part part) => children.Add(part);

    public override TimeSpan ManufactorTime
    {
        get
        {
            var time = productionTime;
            foreach (var part in children)
            {
                time += part.ManufactorTime;
            }
            return time;
        }
    }
    public override float CostPrice
    {
        get
        {
            var price = costPrice;
            foreach (var part in children)
            {
                price += part.CostPrice;
            }
            return price;
        }
    }
}