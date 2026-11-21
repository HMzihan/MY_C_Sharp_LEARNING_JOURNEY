using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ln.if_ellse_even_odd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine($"{num} is Even");

            }
            else
            {
                Console.WriteLine($"{num} is Odd");
            }

            Console.WriteLine("Enter any key to end the program...");
            Console.ReadKey();
        }
    }
}
