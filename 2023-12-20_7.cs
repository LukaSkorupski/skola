using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main
{
internal class Program
{
    static Dictionary<int, int> cache = new Dictionary<int, int>();

    static void Main(string[] args)
    {

        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(Fib(n));
    }

    static int Fib(int n)
    {
        if (n < 2)
            return n;

        if (cache.ContainsKey(n))
        {
            return cache[n];
        }
        else
        {
            cache.Add(n, Fib(n - 1) + Fib(n - 2));
        }

        return cache[n];
    }
}
}
