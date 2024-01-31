using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25012024_1
{
internal class Program
{
    static void Main(string[] args)
    {
        Planet zemlja = new Planet(1, 2);
        Satelit mjesec = new Satelit(3, 4);
    }
}

class NebeskoTijelo
{
    protected double BrzinaOkoOsi;
    protected double BrzinaOkoSunca;
}

class Planet : NebeskoTijelo
{
    public Planet(double a, double b)
    {
        BrzinaOkoOsi = a;
        BrzinaOkoSunca = b;
    }
}
class Satelit : NebeskoTijelo
{
    public Satelit(double a, double b)
    {
        BrzinaOkoOsi = a;
        BrzinaOkoSunca = b;
    }
}
}
