using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Kentucky_Semester_One_Final_Project
{
    public class UI
    {
        public static string? MainMenu()
        {
            Console.WriteLine("Hello! Make a selection below: ");
            Console.WriteLine("1. Return all albums 1 - 500");
            Console.WriteLine("2. Return Top 10");
            Console.WriteLine("3. Return all Rock related genres");
            Console.WriteLine("4. Return all Metal related genres");
            Console.WriteLine("5. Return all Hip Hop related genres");
            Console.WriteLine("0. Quit\n");

            var pick = Console.ReadLine();
            Console.WriteLine();
            Console.Beep(650, 100);
            return pick;
        }



        public static async Task MakeAnotherSelection()
        {
            Console.WriteLine("Would you like to make another selection?");
            Console.WriteLine("1. Yes");
            Console.WriteLine("2. No");
            var anotherSelection = Console.ReadLine();

            while (true)
            {
                if (anotherSelection == "1")
                {
                    await Start.StartProgram();

                }
                else if (anotherSelection == "2")
                {
                    Console.WriteLine("Goodbye, Kenny Loggins");
                    Environment.Exit(0);
                }
            }
        }



        public static void SelectionResult(Post post)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"{post.position}. {post.artist} - {post.name}");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Genre: {post.genres}");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"User Rating: {post.rating} || Number of User Ratings: {post.num_ratings} || Number of User Reviews: {post.num_reviews}");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Year Released: {post.date}");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("___________________________________________________________________________________________________");
            Console.WriteLine("                                                                                                   |");
            Console.WriteLine("___________________________________________________________________________________________________|");
            Console.WriteLine("");
        }



        public static void GenreSelectionResult(float? rating, int? position, int? num_ratings, int? num_reviews, int? date, string? artist, string? names, string s)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($" [Ranking: {position}]. Artist: {artist} - {names}");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Genre: {s}");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"User Rating: {rating} || Number of User Ratings: {num_ratings} || Number of User Reviews: {num_reviews}");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Year Released: {date}");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("___________________________________________________________________________________________________");
            Console.WriteLine("                                                                                                   |");
            Console.WriteLine("___________________________________________________________________________________________________|");
            Console.WriteLine("");
        }



        public static void GenreParcer(Post get, out float? rating, out int? position, out int? num_ratings, out int? num_reviews, out int? date, out string? artist, out string? names, out string[] strings)
        {
            rating = (float?)get.rating;
            position = (int?)get.position;
            num_ratings = (int?)get.num_ratings;
            num_reviews = (int?)get.num_reviews;
            date = (int?)get.date;
            artist = get.artist;
            string? genres = get.genres;
            names = (string?)get.name;
            strings = genres.Split(",");
        }
    }
}
