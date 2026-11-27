using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ln.if_else_grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double value;

            Console.Write("Enter Your Marks please: ");
            value = Convert.ToDouble(Console.ReadLine());

            if (value >= 0 && value <= 100)
            {
                if (value >= 90)
                {
                    Console.WriteLine($"{value} is A");
                }
                else if (value >= 80)
                {
                    Console.WriteLine($"{value} is B");
                }
                else if (value >= 70)
                {
                    Console.WriteLine($"{value} is C");
                }
                else if (value >= 60)
                {
                    Console.WriteLine($"{value} is D");
                }
                else
                {
                    Console.WriteLine($"{value} is F");
                }
            }
            else
            {
                Console.WriteLine($"{value} is invalid.");
            }
        }
    }
}
