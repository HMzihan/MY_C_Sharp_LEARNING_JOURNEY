using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ln.if_else_Larger_is_three_variable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            
            Console.WriteLine("Number1: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Number2: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Number3: ");
            num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine($"{num1} is larger");
            }
            else if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine($"{num2} is larger");
            }
            else if (num3 > num1 && num3 > num2)
            {
                Console.WriteLine($"{num3} is larger");
            }
            else
            {
                Console.WriteLine("All numbers are equal");
            }

        }
    }
}
