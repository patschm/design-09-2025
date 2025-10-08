using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod;

internal class Cage : Stay
{
    protected override bool CanContain(Animal animal)
    {
        return animal is Cat;
    }

    protected override void RejectMessage(Animal animal)
    {
        Console.WriteLine("Dit beest mag niet in de kooi");
    }
}
