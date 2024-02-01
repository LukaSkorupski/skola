using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01022024_1
{
    class GeometrijskiLik
    {
        protected int BrojStranica;
        double[] Stranice  = new double[10];


        public void UcitajStranice()
        {
            for (int i = 0; i<BrojStranica; ++i)
            {
                Console.Write(String.Format("stranica {0} >>> ", i));
                Stranice[i] = Convert.ToDouble(Console.ReadLine());
            }
        }

        public double Opseg()
        {
            double opseg = 0;
            for (int i=0; i<BrojStranica; ++i)
            {
                opseg += Stranice[i];
            }
            return opseg;
        }
    }

    class Trokut : GeometrijskiLik
    {
        public Trokut()
        {
            BrojStranica = 3;
        }
    }

    class Cetverokut : GeometrijskiLik
    {
        public Cetverokut()
        {
            BrojStranica = 4;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Trokut t = new Trokut();
            t.UcitajStranice();
            Console.WriteLine(String.Format("Opseg trokuta: {0}", t.Opseg()));
            
            Cetverokut c = new Cetverokut();
            c.UcitajStranice();
            Console.WriteLine(String.Format("Opseg cetverokuta: {0}", c.Opseg()));

            Console.ReadKey();
        }
    }
}
