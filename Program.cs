using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace OOP3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList kolekcija = new ArrayList();
            kolekcija.Add(1);
            kolekcija.Add('a');
            kolekcija.Add("abc");
            kolekcija.Add(1.1f);

            kolekcija.Insert(2, "def");


            if (kolekcija.Contains(1))
                kolekcija.Remove(1);

            if (!kolekcija.Contains(1))
                kolekcija.Add(1);

            foreach (var predmet in kolekcija)
            {
                Console.WriteLine(predmet);
            }

            Console.ReadKey();
        }
    }
}
