using Lab_10;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace movietest
{
    [TestClass]
    public class MovieTest
    {
        [TestMethod]
        public void TestSearchByCategory()
        {
            List<Movie> MovieList = new List<Movie>();
            
            MovieList.Add(new Movie("Brazil", "scifi"));
            MovieList.Add(new Movie("Blade Runner", "scifi"));
            MovieList.Add(new Movie("Leon, the Professional", "drama"));

            List<string> result = Movie.SearchByCategory("scifi", MovieList);
            Assert.AreEqual(2, result.Count);
        }
    }

}