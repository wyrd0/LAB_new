using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_10
{
     public class Movie
    {

        private string Title;
        private string Category;

        #region get/set
        public string Title1
        {
            get
            {
                return Title;
            }

            set
            {
                Title = value;
            }
        }

        public string Category1
        {
            get
            {
                return Category;
            }

            set
            {
                Category = value;
            }
        }

       #endregion

        //constructors
        public Movie(string titl, string cat)
        {
            titl = Title;
            cat = Category;
        }


        //public static List<string> SearchByCategory(string cat, List<Movie> MovieList)
        //{

        //    List<string> category = new List<string>();
        //    for (int i = 1; i <= MovieList.Count; i++)
        //    {
        //        foreach (Movie item in MovieList)
        //        {
        //            if (c)
        //            {

        //            }
        //        }
        //        {

        //        }
        //    }
        //    return null;

            
        }
        
    }
