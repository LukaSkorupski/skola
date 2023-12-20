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
        int n = 100;
        bool[] p = new bool[n];
        Array.Fill(p, true);
        p[0] = false;

        for (int i = 2; i < n + 1; ++i)
        {
            if (p[i - 1])
            {
                for (int j = i * i; j < n + 1; j += i)
                {
                    p[j - 1] = false;
                }
            }
        }

        for (int i = 0; i < n; ++i)
        {
            if (p[i])
                Console.Write(String.Format("{0} ", i + 1));
        }
    }
}
}
