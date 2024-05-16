using Obrasci_strukture_DZ5;
using System;

class Program
{
    public static void Main()
    {
        Coffee espresso = new Espresso();
        Console.WriteLine($"{espresso.GetDescription()}, {espresso.GetCost()} eur");

        Coffee espressoWmilk = new Milk(new Espresso());
        Console.WriteLine($"{espressoWmilk.GetDescription()}, {espressoWmilk.GetCost()} eur");
    }
}
