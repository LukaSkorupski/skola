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
        int[] n = { 1, 4, 5, 6, 7, 3, 2, 4 };
        Array.Sort(n);
        foreach (int e in n)
        {
            Console.Write(String.Format("{0} ", e));
        }
    }
}
}
