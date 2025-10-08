using AbstractFactory.ArtDeco;
using AbstractFactory.Modern;

namespace AbstractFactory;

internal class Program
{
    static void Main(string[] args)
    {
        var modern = new ModernFactory();
        var table = modern.CreateTable();
        table.ShowTable();
        modern.CreateSofa().ShowSofa();
        modern.CreateChair().ShowChair();

        var artdeco = new ArtDecoFactory();
        artdeco.CreateTable().ShowTable();
        artdeco.CreateSofa().ShowSofa();
        artdeco.CreateChair().ShowChair();
    }
}