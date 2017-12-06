using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication42
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Osoba> os = new List<Osoba>();
            os.Add(new Osoba("Adam", "Zakrzewski", "Prawie sto"));
            os.Add(new Osoba("Adam", "Kowalski", "Prawie sto"));
            
            os.Add(new Osoba("Andrzej", "Kowalski", "Prawie sto"));

            os.Sort();
            foreach(var element in os)
            {
                Console.WriteLine(element);
            }
            Console.ReadKey();
        }
    }
}
