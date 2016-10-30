using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Get User Input
            Console.Write("Welcome! What is your name?     ");
            string uName = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Would you like to play a game, " + uName + "?     ");
            string proceed = Program.Proceed(Console.ReadLine());

            if (proceed == "yes")
            {
                Console.WriteLine("Excellent!  You are walking across a field and you encounter a fire-breathing dragon! What will you do? (A: Face the beast? or B: Run away)?     ");
            }
            string state = (Console.ReadLine());
            state = state.ToUpper();
            while (proceed == "yes")
            {
                switch (state)
                {
                    case "A":
                        {
                            Console.Write("Brave choice.  You approach the dragon.  You see that he has ___ heads.  /n(enter '1' or '2' or '3'):  ");
                            break;
                        }
                    case "B":
                        {
                            break;
                        }
                    default:
                        {
                            break;
                        }
                }

                //Process

                //Output

                //Proceed?
                Console.Write("Would you like to continue?");
                proceed = Program.Proceed(Console.ReadLine());
                
            }
        }
    

    private static string Proceed(string v)
    {
        string proceed = (v.ToLower());
            if (proceed == "y" || proceed == "yes")
            {
                proceed = "yes";
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Goodbye!");
                Console.WriteLine("");
            }
                return proceed;
    }
    }
}

