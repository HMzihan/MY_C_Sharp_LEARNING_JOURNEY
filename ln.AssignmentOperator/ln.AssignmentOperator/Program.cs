using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ln.AssignmentOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 20;

            x += 2;
            Console.WriteLine($"{x}");

            x -= 2;
            Console.WriteLine($"{x}");

            x *= 2;
            Console.WriteLine($"{x}");

            x /= 2;
            Console.WriteLine($"{x}");

        }
    }
}
