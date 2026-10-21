using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ln.TernaryOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 20;
            int y = 10;

            int result = x > y ? x : y;
            Console.WriteLine(result);
        }
    }
}
