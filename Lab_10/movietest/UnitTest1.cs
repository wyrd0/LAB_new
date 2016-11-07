using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace movietest
{
    [TestClass]
    public class Movie
    {
        [TestMethod]
        public void TestSearchByCategory()
        {
            List<Movie> MovieList = new List<Movie>();
            string title = Movie(string category);

            MovieList.Add(new Movie("Brazil", "scifi"));
            MovieList.Add(new Movie("Blade Runner", "scifi"));
            MovieList.Add(new Movie("Leon, the Professional", "drama"));
            
            int result = 
            Assert.AreEqual(1, result);
        }
    }


}
