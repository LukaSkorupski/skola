using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25012024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Gepard g = new Gepard();
            g.Opasnost();
        }
    }
    class Cat
    {
        bool opasna;
        public bool Opasna { get => opasna; set => opasna = value; }

        public virtual void Opasnost()
        {
            Opasna = false;
        }
    }

    class Gepard : Cat
    {
        public override void Opasnost()
        {
            Opasna = true;
        }
    }
}
