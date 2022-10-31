using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Kentucky_Semester_One_Final_Project
{
    public class Utility
    {
        public static string? MainMenu()
        {
            Console.WriteLine("Hello! Make a selection below: ");
            Console.WriteLine("1. Return all albums 1 - 500");
            Console.WriteLine("2. Return Top 10");
            Console.WriteLine("3. Return all Rock related genres");
            Console.WriteLine("4. Return all Metal related genres");
            Console.WriteLine("5. Return all Hip Hop related genres");
            Console.WriteLine("0. Quit");
            var pick = Console.ReadLine();
            Console.Beep(650, 100);
            return pick;
        }

        public static void SelectionOne(Post post)
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
            Console.WriteLine("____________________________________________________________________________________________________");
            Console.WriteLine("===================================================================================================|");
            Console.WriteLine("___________________________________________________________________________________________________|");
        }

        public static void SelectionTwo(Post post)
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
            Console.WriteLine("____________________________________________________________________________________________________");
            Console.WriteLine("===================================================================================================|");
            Console.WriteLine("___________________________________________________________________________________________________|");
        }

        public static void SelectionThree(Post[] myPosts)
        {
            List<string> artistLists = new List<string>();
            List<string> genresList = new List<string>();
            List<string> nameList = new List<string>();

            foreach (var get in myPosts)
            {
                var position = (int?)get.position;
                string? artist = get.artist;
                string? genres = get.genres;
                string? names = (string?)get.name;
                string[] strings = genres.Split(",");
                foreach (string s in strings)
                {
                    if (!genresList.Contains(s) && !artistLists.Contains(s) && !nameList.Contains(s))
                    {
                        artistLists.Add(s);
                        genresList.Add(s);
                        nameList.Add(s);

                        if (s.Contains("Rock"))
                        {
                            Console.WriteLine($"{position}. Artist: {artist} - {names}");
                            Console.WriteLine($"Genre: {s}");
                            Console.WriteLine("____________________________________________________________________________________________________");
                            Console.WriteLine("===================================================================================================|");
                            Console.WriteLine("___________________________________________________________________________________________________|");

                        }
                    }

                }

            }
        }

        public static void SelectionFour(Post[] myPosts)
        {
            List<string> artistLists = new List<string>();
            List<string> genresList = new List<string>();
            List<string> nameList = new List<string>();

            foreach (var get in myPosts)
            {
                var position = (int?)get.position;
                string? artist = get.artist;
                string? genres = get.genres;
                string? names = (string?)get.name;
                string[] strings = genres.Split(",");

                foreach (var s in strings)
                {
                    if (!genresList.Contains(s) && !artistLists.Contains(s) && !nameList.Contains(s))
                    {
                        artistLists.Add(s);
                        genresList.Add(s);
                        nameList.Add(s);


                        if (s.Contains("Metal"))
                        {
                            Console.WriteLine($"{position}. Artist: {artist} - {names}");
                            Console.WriteLine($"Genre: {s}");
                            Console.WriteLine("____________________________________________________________________________________________________");
                            Console.WriteLine("===================================================================================================|");
                            Console.WriteLine("___________________________________________________________________________________________________|");

                        }

                    }

                }

            }
        }

        public static void SelectionFive(Post[] myPosts)
        {
            List<string> artistLists = new List<string>();
            List<string> genresList = new List<string>();
            List<string> nameList = new List<string>();

            foreach (var get in myPosts)
            {
                var position = (int?)get.position;
                string? artist = get.artist;
                string? genres = get.genres;
                string? names = (string?)get.name;
                string[] strings = genres.Split(",");

                foreach (var s in strings)
                {
                    if (!genresList.Contains(s) && !artistLists.Contains(s) && !nameList.Contains(s))
                    {
                        artistLists.Add(s);
                        genresList.Add(s);
                        nameList.Add(s);


                        if (s.Contains("Hip Hop"))
                        {


                            Console.WriteLine($"{position}. Artist: {artist} - {names}");
                            Console.WriteLine($"Genre: {s}");
                            Console.WriteLine("____________________________________________________________________________________________________");
                            Console.WriteLine("===================================================================================================|");
                            Console.WriteLine("___________________________________________________________________________________________________|");



                        }

                    }

                }

            }
        }
    }
}
