using System;

namespace MovieList
{
    class Program
    {
        static void Main(string[] args)
        {

            //this is a list of type MovieDatabase
            MovieDatabase MovieL = new MovieDatabase();
            bool keepGoing = true;
            do
            {

                MovieL.PrintListOfMoviesByCategory();

                keepGoing = Continue();
            }
            while (keepGoing == true);
            
        }

        public static bool Continue()
        {
            string input = GetUserInput("Would you like to continue ? y/n");

            if(input == "y")
            {
                return true;
            }
            else if(input == "n")
            {
                Console.WriteLine("Have a nice day!");
                return false;
            }
            else
            {
                Console.WriteLine("I am sorry! I don't understand that!");
                return Continue();
            }
        }

        //Method taking in the user answer, and then assigns it to the continue method to then do its job 
        private static string GetUserInput(string prompt)
        {
            Console.WriteLine(prompt);
            string userAnswer = Console.ReadLine().ToLower();

            return userAnswer;
        }
    }
}
