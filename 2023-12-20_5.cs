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
        int n = Convert.ToInt32(Console.ReadLine());
        double res = 0;
        while (n > 0)
        {
            res += 1.0 / Math.Pow(3, n);
            n--;
        }
        Console.WriteLine(res);
    }
}
}
