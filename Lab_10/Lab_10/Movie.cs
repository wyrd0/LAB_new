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
        public Movie(string title, string category)
        {
            title = Title;
            category = Category;
        }


        public static List<string> SearchByCategory(string category, List<Movie> MovieList)
        {
            return null;
        }
        
    }
}
