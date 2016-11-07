using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_10
{
    public class Program
    {
        static void Main(string[] args)
        {
            //create ArrayList
            List<Movie> MovieList = new List<Movie>();
            string title, category;
            Console.Write("Enter Movie Title:   ");
            title = Console.ReadLine();
            Console.Write("Please enter the movie's category:   ");
            category = Console.ReadLine();
            MovieList.Add(new Movie(title, category));

                Console.WriteLine("Welcome to MovieList!\n");
            Console.WriteLine("There are 10 movies in this list. \nWhat category are you interested in?    ");
            category = Console.ReadLine();

        }
    }
}
