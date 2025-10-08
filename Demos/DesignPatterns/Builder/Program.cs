namespace Builder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var carBuilder = new CarBuilder();
            carBuilder.AddEngine();
            carBuilder.AddWheels();
            var car1 = carBuilder.Result;

            Console.WriteLine(car1);
            var bikeBuilder = new BicycleBuilder();

           // carBuilder.AddEngine();

            var director = new Director();
            var bike = director.CreateBicycle(bikeBuilder);
            var car = director.CreateCar(carBuilder);

            Console.WriteLine(bike);
            Console.WriteLine(car);
        }
    }
}