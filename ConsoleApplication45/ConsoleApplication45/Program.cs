using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication45
{
    class Program
    {
        static void Main(string[] args)
        {
            double liczba1 = 30;
            double liczba2 = 0;
            try
            {
                if (liczba2 == 0) throw new NaszWyjatekException("ssdsdsdsddf");
                double liczba3 = liczba1 / liczba2;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }
    }

    class NaszWyjatekException:Exception
    {
        public NaszWyjatekException() { }

        public NaszWyjatekException(string message) : base(message) { }

        public NaszWyjatekException(String message, Exception innerException)
            : base(message, innerException) { }
    }
}
