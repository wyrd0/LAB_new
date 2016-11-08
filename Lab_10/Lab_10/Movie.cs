using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_10
{
     public class Movie

    {           //use hashtable

        private string title;
        private string category;

        #region get/set
        public string Title
        {
            get
            {
                return title;
            }

            set
            {
                title = value;
            }
        }

        public string Category
        {
            get
            {
                return category;
            }

            set
            {
                category = value;
            }
        }

      

        #endregion

        //constructors
        public Movie(string titl, string cat)
        {
            Title = titl;               //! Start with global var (=Property)!
            Category = cat;
        }
        public Movie(string cat)
        {
            Category = cat;
        }


        public List<string> SearchByCategory(string cat, List<Movie> MovieList)
        {
            List<string> SearchList = new List<string>();
            for (int i = 1; i <= MovieList.Count; i++)
            {
                if (MovieList.ElementAt(i).Category == cat)
                {
                    SearchList.Add(MovieList[i].Title);
                }  
                       
           }
            return SearchList;
        }



    }
        
    }
