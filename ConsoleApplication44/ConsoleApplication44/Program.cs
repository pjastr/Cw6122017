using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication44
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] table = new int[2];
            try
            {
                table[25] = 2;
                table[0] = Convert.ToInt32("ddd");
            }
            
            catch(IndexOutOfRangeException ex)
            {
                Console.WriteLine("poza zakresem");
            }
            catch
            {
                Console.WriteLine("inny wyjątek");
            }
            

            Console.ReadKey();
        }
    }
}
