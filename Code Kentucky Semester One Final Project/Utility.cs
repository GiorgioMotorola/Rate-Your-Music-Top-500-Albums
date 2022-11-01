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
            SelectionResult(post);
        }



        public static void SelectionTwo(Post post)
        {
            SelectionResult(post);
        }

        public static void SelectionThree(Post[] myPosts)
        {
            List<string> artistLists = new List<string>();
            List<string> genresList = new List<string>();
            List<string> nameList = new List<string>();
            List<int> numRatingsList = new List<int>();

            foreach (var get in myPosts)
            {
                var rating = (float?)get.rating;
                var position = (int?)get.position;
                var num_ratings = (int?)get.num_ratings;
                var num_reviews = (int?)get.num_reviews;
                var date = (int?)get.date;
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

                            GenreSelectionResult(rating, position, num_ratings, num_reviews, date, artist, names, s);

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
                var rating = (float?)get.rating;
                var position = (int?)get.position;
                var num_ratings = (int?)get.num_ratings;
                var num_reviews = (int?)get.num_reviews;
                var date = (int?)get.date;
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
                            GenreSelectionResult(rating, position, num_ratings, num_reviews, date, artist, names, s);
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
                var rating = (float?)get.rating;
                var position = (int?)get.position;
                var num_ratings = (int?)get.num_ratings;
                var num_reviews = (int?)get.num_reviews;
                var date = (int?)get.date;
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

                            GenreSelectionResult(rating, position, num_ratings, num_reviews, date, artist, names, s);

                        }
                    }
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
    }
}
