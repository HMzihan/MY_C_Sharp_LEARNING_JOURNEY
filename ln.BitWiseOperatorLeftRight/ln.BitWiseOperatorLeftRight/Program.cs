using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ln.BitWiseOperatorLeftRight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result;

            result = 14 >> 2;
            Console.WriteLine($"14 >> 2 = {result}" );

            result = 15 << 2;
            Console.WriteLine($"14 << 2 = {result}");
        }
    }
}
