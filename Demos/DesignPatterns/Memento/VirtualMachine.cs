using Bogus;

namespace Memento;

// Originator
internal class VirtualMachine
{
    // Memento
    public class SnapShot
    {
        internal readonly int number;
        internal readonly string data;

        public SnapShot(int number, string data)
        {
            this.number = number;
            this.data = data;
        }
    }

    private int number = 0;
    private string data = "data";
    //private byte[] mem;

    public void DoSomeWork()
    {
        var faker = new Faker();
        number = faker.Random.Int(1_000_000, 2_000_000_000);
        //mem = new byte[number];
        data = faker.Lorem.Sentence();
        Console.WriteLine(this);
    }
    public SnapShot CreateSnapShot()
    {
        return new SnapShot(number, data);
    }
    public void RestoreSnapShot(SnapShot snapShot)
    {
        number = snapShot.number;
        data = snapShot.data;
    }
    public override string ToString()
    {
        return $"VM State: number={number}, data={data}";
    }
}
