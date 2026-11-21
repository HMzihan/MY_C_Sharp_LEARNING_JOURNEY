using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ln.if_elseP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter digit");
            int dig = Convert.ToInt32(Console.ReadLine());

            if (dig == 5)
            {
                Console.WriteLine("Five");
            }
            else if (dig == 6)
            {
                Console.WriteLine("Six");
            }
            else if (dig == 7)
            {
                Console.WriteLine();
            }
            else if (dig == 8)
            {
                Console.WriteLine("Eight");
            }
            else if (dig == 9)
            {
                Console.WriteLine("Nine");
            }
            else if (dig == 10)
            {
                Console.WriteLine("Ten");
            }
            else
            {
                Console.WriteLine("Try again please!");
            }
        }
    }
}
