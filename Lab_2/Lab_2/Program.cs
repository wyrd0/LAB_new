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
            Console.WriteLine(" ");
            Console.Write("Welcome! What is your name?     ");
            string uName = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Would you like to play a game, " + uName.ToUpper() + "?     ");
            string proceed = Program.Proceed(Console.ReadLine());

            string state = "start";
            string puff = "PUFF";
            while (proceed == "yes")
            {
                switch (state)
                {
                    case "start":
                        {
                            Console.Clear();
                            Console.WriteLine(" ");
                            Console.Write("Excellent!  You are walking across a field and you encounter a fire-\nbreathing dragon! What will you do? (A: Face the beast? or B: Run away)?     ");
                            state = (Console.ReadLine().ToLower());
                            break;
                        }

                    case "a":
                        {
                            Console.Clear();
                            Console.WriteLine(" ");
                            Console.Write("Brave choice.  You approach the dragon.  You see that it has ___ heads.  \n(enter '1' or '2' or '3'):  ");
                            state = (Console.ReadLine().ToLower());
                            break;
                        }
                    case "b":
                        {
                            Console.Clear();
                            Console.WriteLine(" ");
                            Console.WriteLine("You run away screaming.  If you had looked behind you while running in \nfear, you might have been surprised to see the sad confusion hovering in \nthe dragon's red eyes.");
                            //state = "default";
                            break;
                        }
                    case "1":
                        {
                            Console.Clear();
                            Console.WriteLine(" ");
                            Console.WriteLine("Gah!  One-headed dragons are the worst.  She will surely be aggressive. \n Choose your weapon. (Enter 'slingshot' or 'sword' or 'bow' (for bow and arrow):   ");
                            state = (Console.ReadLine().ToLower());
                            break;
                        }
                    case "2":
                        {
                            Console.Clear();
                            Console.WriteLine(" ");
                            Console.WriteLine("Whew.  A two-headed dragon.  Those guys have a slow reaction time, due to \ntheir crippling ambivalence and existential angst.  Squinting, you can see \nthat the dragon's eyes are ('red' or 'blue'):     ");
                            state = (Console.ReadLine().ToLower());
                            break;
                        }
                    case "3":
                        {
                            Console.Clear();
                            Console.WriteLine(" ");
                            Console.WriteLine("No one has ever faced a three-headed dragon before!  Choose your weapon. \n(Enter 'slingshot' or 'sword' or 'bow' (for bow and arrow):   ");
                            state = (Console.ReadLine().ToLower());
                            break;
                        }
                    case "slingshot":
                        {
                            Console.Clear();
                            Console.WriteLine(" ");
                            Console.Write("Wise choice; very portable.  You load the slingshot and approach.  You can \nfeel the dragon's fiery breath. Squinting, you take aim.  Just as you prepare to let \nfly, something about the dragon's ____ eyes gives you pause. \n(Enter 'red' or 'blue'):    ");
                            state = (Console.ReadLine().ToLower());
                            break;
                        }
                    case "sword":
                        {
                            Console.Clear();
                            Console.WriteLine(" ");
                            Console.Write("Boldly, you draw your sword and stumble forward.  You struggle to regain \nyour center of balance as you feel the dragon's fiery breath slowly \nbaking the local atmosphere.  It stares at you with its ____ eyes.   \n(Enter 'red' or 'blue'):     ");
                            state = (Console.ReadLine().ToLower());
                            break;
                        }
                    case "red":
                        {
                            Console.Clear();
                            Console.WriteLine(" ");
                            Console.Write("Oh thank goodness!  Red-eyed dragons are friendly.  You remember hearing \nsomething about this from some old song.  You guess that their eyes are \nred from all that puffing they do all day. Well, you've always \nwanted a pet dragon.  You walk up and pet the dragon.  You \nbecome fast friends and you name him ___________.  :     ");
                            puff = (Console.ReadLine());
                            state = ("default");
                            break;
                        }
                    case "blue":
                        {
                            Console.Clear();
                            Console.WriteLine(" ");
                            Console.Write("Blue-eyed dragons are very rare!  What was it that they used to say about \nblue-eyed dragons? ... Oh!  That's right.  Blue-eyed dragons are blind!  \nSilently, you stow your weapon and back away.  We'll leave this dragon to live another day.");
                            state = ("default");
                            break;
                        }
                    default:
                        {
                            Console.Clear();
                            Console.WriteLine(" ");
                            Console.Write("Would you like to play again?     ");
                            proceed = Program.Proceed(Console.ReadLine());
                            if (proceed == "yes")
                            {
                                state = "start";
                            }
                            else
                            {
                                Console.WriteLine(puff + " waves at you. 'So long, " + uName.ToUpper() + "!  Come back soon!");
                                proceed = "no";
                            }
                            break;
                        }

                }
            }
        }
    

    private static string Proceed(string v)
    {
        string proceed = (v.ToLower().Trim());
            if (proceed == "y" || proceed == "yes" || proceed == "sure" || proceed == "ok")
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

