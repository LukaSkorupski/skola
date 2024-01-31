using System;

class ProgramskiJezik
{
    private double postotak;

    public double Postotak
    {
        get {
            return postotak;
        }
        set {
            postotak = value;
        }
    }
}

class Proceduralni : ProgramskiJezik
{
}

class Objektni : ProgramskiJezik
{
}

class Funkcionalni : ProgramskiJezik
{
}

class Program
{
    static void Main()
    {
        Proceduralni x = new Proceduralni();
        Objektni y = new Objektni();
        Funkcionalni z = new Funkcionalni();

        Console.Write("Unesite postotak za Proceduralni: ");
        x.Postotak = double.Parse(Console.ReadLine());

        Console.Write("Unesite postotak za Objektni: ");
        y.Postotak = double.Parse(Console.ReadLine());

        Console.Write("Unesite postotak za Funkcionalni: ");
        z.Postotak = double.Parse(Console.ReadLine());

        double zbrojPostotaka = x.Postotak + y.Postotak + z.Postotak;

        if (zbrojPostotaka != 100)
        {
            Console.WriteLine("Neispravan unos podataka. Zbroj postotaka mora biti 100.");
        }
        else
        {
            Console.WriteLine("Zbroj postotaka je 100. Najzastupljenija vrsta programskih jezika:");

            if (x.Postotak > y.Postotak && x.Postotak > z.Postotak)
                Console.WriteLine("Proceduralni");
            else if (y.Postotak > x.Postotak && y.Postotak > z.Postotak)
                Console.WriteLine("Objektni");
            else
                Console.WriteLine("Funkcionalni");
        }
    }
}
