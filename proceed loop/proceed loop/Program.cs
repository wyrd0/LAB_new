using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proceed_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            string proceed = "y";
            while (proceed == "y")
            {
                //Get User Input

                //Process

                //Output

                //Proceed?
                Console.Write("Continue? (y/n)");
                proceed = (Console.ReadLine().ToLower());
                if (proceed == "yes")
                {
                    proceed = "y";
                }
                else Console.WriteLine("Goodbye!");
            }
        }
    }
}
