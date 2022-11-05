using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Kentucky_Semester_One_Final_Project
{
    public class Results
    {
        public static void SelectionResult(Properties post)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write($"{post.position}. ");
            Console.WriteLine($"{ post.artist} - { post.name}");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"Genre: {post.genres}");           
            Console.WriteLine($"User Rating: {post.rating} || Number of User Ratings: {post.num_ratings} || Number of User Reviews: {post.num_reviews}");
            Console.WriteLine($"Year Released: {post.date}\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("|| Copy the link below and paste it into your Spotify search field or a web browser to listen ||");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine($"http://open.spotify.com/search/{post.artist}+{post.name}\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("______________________________________________________________________________________________________\n\n");

        }

        public static void GenreSelectionResult(float? rating, int? position, int? num_ratings, int? num_reviews, int? date, string? artist, string? names, string s)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"[Ranking: {position}]. Artist: {artist} - {names}");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"Genre: {s}");
            Console.WriteLine($"User Rating: {rating} || Number of User Ratings: {num_ratings} || Number of User Reviews: {num_reviews}"); 
            Console.WriteLine($"Year Released: {date}\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("|| Copy the link below and paste it into your Spotify search field or a web browser to listen ||");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine($"http://open.spotify.com/search/{artist}+{names}\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("______________________________________________________________________________________________________\n\n");
            Thread.Sleep(100);
                   
        }                
    }
}
