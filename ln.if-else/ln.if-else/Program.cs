using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ln.if_else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 10;

            if (num > 0)
            {
                Console.WriteLine("Positive");
            }
            else if (num < 0)
            {
                Console.WriteLine("Negative");
            }
            else if (num == 0)
            {
                Console.WriteLine("Zero");
            }
        }
    }
}
