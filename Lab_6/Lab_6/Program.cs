using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //by Mary O on Oct 28, 2016

            Console.WriteLine("Pig Latin Translator");
            Console.WriteLine("(igpay atinlay anslatortray)\n");

            //set up/introduce continue loop 
            string proceed = "yes";
            while (proceed == "yes")
            {
                //Get user input
                Console.Write("Please enter a word:  ");
                string word = (Console.ReadLine());
                word = word.Trim().ToLower();
                int IndexOfFirstVowel = findIndexFirstVowel(word);
                Console.WriteLine("");

                // VALIDATE - string should contain only letters and should contain a vowel or, failing that, a 'y'.
                bool testWord = IsWord(word);
                if (testWord == false || IndexOfFirstVowel < 0 && word.IndexOf("y") < 0)
                {
                    Console.WriteLine("Error!  The string you entered, '" + word + "' , is not a word.  Please try again.  \n(Numbers and special characters are not accepted.)\n");
                }
                //if word starts with a vowel (append 'way')
                else if (IndexOfFirstVowel == 0)
                {
                    string addWay = (word + "way");
                    Console.WriteLine(addWay);
                }
                //if word starts with a consonant (move substring before 1st vowel to end, add 'ay')
                else if (IndexOfFirstVowel > 0)
                {
                    string end = word.Substring(IndexOfFirstVowel);
                    string beginning = word.Substring(0, IndexOfFirstVowel);
                    Console.WriteLine(end + beginning + "ay");
                }
                //remaining words containing 'y' (treat y as vowel)
                else if (word.Contains("y"))
                {
                    string end = word.Substring(word.IndexOf("y"));
                    string begin = word.Substring(0, word.IndexOf("y"));
                    Console.WriteLine(end + begin + "ay");
                }
                
                Console.Write("\nTranslate another word? (y/n)   ");
                proceed = Proceed(Console.ReadLine());
                Console.WriteLine(" ");
            }
        }

        //METHODS
        //Method: Find First Vowel in word                
        private static int findIndexFirstVowel(string word)
        {
            char[] vowel = { 'a', 'e', 'i', 'o', 'u' };
            int indexFirstVowel = word.IndexOfAny(vowel);        //find index of first vowel
            return indexFirstVowel;
        }

        //Method: Continue?
        private static string Proceed(string input)
        {
            string proceed = (input.ToLower().Trim());
            if (proceed == "y" || proceed == "yes" || proceed == "sure" || proceed == "ok")
            {
                proceed = "yes";
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Goodbye!");
                Console.WriteLine("(Oodbyegay!)");
            }
            return proceed;
        }
        //Method:  Validate string input to word
        private static bool IsWord(string input)
        {
            char[] temp = input.ToCharArray();
            bool isWord= false;           
            for (int i = 0; i < input.Length; i++)
            {
                isWord = char.IsLetter(temp[i]);

               if (isWord == false)
                {
                    break;
                }
            }
             return isWord;

        }

    }
}
