using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication46
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbe");
            double a=0;
            try
            {

                a = double.Parse(Console.ReadLine());
                Console.WriteLine("Pierwiastek={0}", Math.Sqrt(a));
            }
            catch
            {
                Console.WriteLine("sasdsdf");
            }
            
            Console.ReadKey();
        }
    }
}
