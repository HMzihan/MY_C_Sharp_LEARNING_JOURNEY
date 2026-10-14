using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ln.LogicalOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // && - and 
            Console.WriteLine(6 > 4 && 7 > 4); // true 
            Console.WriteLine(3 > 4 && 7 > 4); // false 
            Console.WriteLine(6 > 4 && 7 > 4 && 1 > 3); // false 

            // || - or 
            Console.WriteLine(8 > 9 || 11 < 9 || 10 > 9); // true 
            Console.WriteLine(8 > 9 || 11 < 9 || 6 > 9); // false 
            
            // ! = not 
            Console.WriteLine(!(8 > 9 || 11 < 9 || 6 > 9)); // true 
        }
    }
}
