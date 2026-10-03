using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ln.Input
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3, sum;
            double avg;

            Console.Write("Number1 = ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Number2 = ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Number3 = ");
            num3 = Convert.ToInt32(Console.ReadLine());

            sum = num1 + num2 + num3;
            Console.Write($"Sum = {sum}");
            Console.WriteLine();

            avg = (double)sum / 3;
            Console.Write($"Average = {avg}");
        }
    }
}
