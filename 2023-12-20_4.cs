using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main
{
internal class Program
{
    static void Main(string[] args)
    {
        string s = Console.ReadLine();
        if (s.StartsWith("www.") && s.EndsWith(".hr"))
        {
            Console.WriteLine("Tolčno");
        }
        else
        {
            Console.WriteLine("Netolčno");
        }
    }
}
}
