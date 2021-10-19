using System;
using System.Collections.Generic;
using System.Text;

namespace MovieList
{ 
    //the below class's role is to manage a list of movies
    class MovieDatabase
    {
        public List<Movie> Movies { get; set; } = new List<Movie>();

        //This is the constructor that accepts a movie title and category
        public MovieDatabase()
        {
            Movies.Add(new Movie("Dune", "Scifi"));
            Movies.Add(new Movie("Ron's Gone Wrong", "Animated"));
            Movies.Add(new Movie("Free Guy", "Scifi"));
            Movies.Add(new Movie("Bergman Island", "Drama"));
            Movies.Add(new Movie("Candyman", "Horror"));
            Movies.Add(new Movie("Monster Family", "Animated"));
            Movies.Add(new Movie("Halloween", "Horror"));
            Movies.Add(new Movie("Vertigo", "Drama"));
            Movies.Add(new Movie("My Little Pony", "Animated"));
            Movies.Add(new Movie("Green Lantern", "Scifi"));
        }

        //method that prints the list based on movie category
        public void PrintListOfMoviesByCategory()
        {
            //get user input for which movie category list they would like to see.
            string input = UserInput("Which Movie category list would you like to see? ").ToLower();
            //this if statement is basically saying that if the input is blank - it's printing an error to the user
            if(string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Sorry! Invalid input! Try again");
                return;
            }

            //Created the below list to be able to take the user input and add the movies to a list 
            List<string> selectedMovies = new List<string>();
            //Foreach loop that takes the user input and displays the movies based on selection and then it adds it to the list above
            foreach(Movie movie in Movies)
            {
         
                if (input == movie.GetMovieCategory().ToLower())
                {

                    selectedMovies.Add(movie.GetMovieTitle());
                    //Console.WriteLine(movie.GetMovieTitle());
                    
                }
                
            }
            //Sorting the movies in alphabetical order. Source found here https://www.dotnetperls.com/sort 
            selectedMovies.Sort();

            //This foreach puts the movies based on the movie genre selected by the user in alphabetical order using the .sort() method

            foreach(string selectedMovie in selectedMovies)
            {
                Console.WriteLine(selectedMovie);
            }

        }

        //This is a method that is calling for the user's input
        public string UserInput(string MovieType)
        {
            Console.WriteLine(MovieType);
            string input = Console.ReadLine();

            return input;
        }
    }
}
