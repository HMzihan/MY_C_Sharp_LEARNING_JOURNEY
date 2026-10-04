using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lnDifiningArea
{
    class Program
    {
        
        static void Main(string[] args)
        {
            double Base, Height, Triangle_area;

            Console.WriteLine("Traingle area calculator");

            Console.Write("Base = ");
            Base = Convert.ToDouble(Console.ReadLine());

            Console.Write("Height = ");
            Height = Convert.ToDouble(Console.ReadLine());

            Triangle_area = 0.5 * Base * Height;

            Console.WriteLine($"Traingle area = {Triangle_area.ToString("F2")}");
        }
    }
}
