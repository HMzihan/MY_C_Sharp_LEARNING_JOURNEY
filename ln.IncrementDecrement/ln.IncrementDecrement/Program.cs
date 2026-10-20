using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ln.IncrementDecrement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 10;
            Console.WriteLine();

            //post incriment and decriment (variable++ and variable--)
            Console.WriteLine(num++);
            Console.WriteLine(num);
            Console.WriteLine(num--);
            Console.WriteLine(num);

            // pre incriment and decrement (++variable and --variable)
            Console.WriteLine(++num);
            Console.WriteLine(num);
            Console.WriteLine(--num);
            Console.WriteLine(num);
        }
    }
}
