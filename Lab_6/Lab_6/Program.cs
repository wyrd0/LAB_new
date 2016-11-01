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
            Console.WriteLine("Pig Latin Translator");
            Console.WriteLine("(igpay atinlay anslatortray)\n");

            //set up/introduce continue loop 
            string proceed = "yes";
            while (proceed == "yes")
            {
                //Get user input
                Console.WriteLine("Please enter a word:  ");
                string word = (Console.ReadLine());
                word = word.Trim().ToLower();
                int IndexOfFirstVowel = findIndexFirstVowel(word);

                //if word starts with a vowel (append 'way')
                if (IndexOfFirstVowel == 0)
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
                //else if (word.Contains("y"))
                //{
                //    string endY = word.Substring(word.IndexOf("y"));
                //    string beginY = word.Substring(0, word.IndexOf("y"));
                //    Console.WriteLine(endY + beginY + "ay");
                //}

                // VALIDATION:  Check that string contains only letters.
                bool testWord = IsWord(word);
                if (testWord == false)
                {
                    Console.WriteLine(word + " is not a word.  Please enter a word.  (Numbers and special characters \nare not accepted.)");
                }
                


                Console.Write("Translate another word? (y/n)   ");
                proceed = Proceed(Console.ReadLine());
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
            int i = 0;
                       
            for (i = 0; i < input.Length; i++)
            {
                char letter = temp[i];
                bool isWord = char.IsLetter(letter);

                Console.Write(letter.ToString());
                Console.Write(isWord.ToString());
                if (isWord == false)
                {
                    Console.Write("break");
                    break;
                }
            }
            return false;
        }

    }
}
