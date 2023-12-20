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
        int x = 3;
        int y = 4;
        int z = 5;

        if (x > 0 && y > 0 && z > 0)
        {
            // x**2 + y**2 = z**2
            if (x * x + y * y == z * z)
            {
                Console.WriteLine("Pravokutan");
            }
            else
            {
                Console.WriteLine("Nepravokutan");
            }
        }
        else
        {
            Console.WriteLine("Nije trokut");
        }
    }
}
}
