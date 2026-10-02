using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ln.PlaceHolder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int value1 = 30;
            int value2 = 20;
            int result;

            result = value1 + value2;
            Console.WriteLine("{0}+{1} = {2}", value1, value2 , result);

            result = value1 - value2;
            Console.WriteLine("{0}-{1} = {2}", value1, value2, result);

            result = value1 / value2;
            Console.WriteLine("{0}/{1} = {2}", value1, value2, result);

            result = value1 % value2;
            Console.WriteLine("{0}%{1} = {2}", value1, value2, result);


        }
    }
}
