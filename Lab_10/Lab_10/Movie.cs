using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_10
{
    class Movie
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
            #endregion

            //constructors
           public Movie(string title, string category)
        {
           Title1 = title;
           Category1 = Category;
        }
            public Movie(string category)
        {
            Category1 = category;
        }
        public MatchCategory(string category)
        {

        }
        
    }
}
