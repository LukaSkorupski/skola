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
        int a = 100;
        int b = 3;
        Console.WriteLine(String.Format("{0} djeljeno s {1} je {2} i ostatak {3}", a, b, a / b, a % b));
        Console.ReadKey();
    }
}
}
