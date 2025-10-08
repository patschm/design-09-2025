namespace Dependency_Inversion.Correct;

internal class ACME
{
    private  IContract worker;

    public ACME(IContract worker)
    {
        this.worker = worker;
    }

    public void Hire(IContract worker)
    {
        this.worker = worker;
    }
    public void StartProducing()
    {
        Console.WriteLine("ACME Starts producing:");
        worker.Working();
    }
}
