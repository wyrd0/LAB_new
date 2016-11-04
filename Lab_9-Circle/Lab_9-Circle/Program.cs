using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_9_Circle
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius;

            //Prompt for radius
            Console.Write("Please enter a radius:   ");
            IsDouble(Console.ReadLine(), out radius);
            

        }
        static bool IsDouble(string input, out double radius)
        {
            bool valid = double.TryParse(Console.ReadLine(), out radius);
            return valid;
        }
    }
}
