using System;
using System.Collections.Generic;
using System.Text;

namespace MovieList
{
    //This is the Movie class that provides the title and category
    class Movie
    {
        private string MovieTitle { get; set; }

        private string MovieCategory { get; set; }

        public Movie(string MovieTitle, string MovieCategory)
        {
            this.MovieTitle = MovieTitle;
            this.MovieCategory = MovieCategory;
        }

        //Since the properties are private, we need to find a way to get the title and the category that can be used outside of this class. When a property inside a class is private
        //It cannot be used outside of it's class.
        //This concept uses encapsulation of movie title and movie category.
        public string GetMovieTitle()
        {
            return this.MovieTitle;
        }
        public string GetMovieCategory()
        {
            return this.MovieCategory;
        }
    }
}
