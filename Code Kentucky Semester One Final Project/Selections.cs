namespace Code_Kentucky_Semester_One_Final_Project
{
    public class Selections
    {

        

        public static void SelectionAll(Properties post)
        {
            Results.SelectionResult(post);
        }


        public static void SelectionGenre(Properties[] myPosts, string genre)
        {
            List<string> artistLists = new List<string>();
            List<string> genresList = new List<string>();
            List<string> nameList = new List<string>();
           

            foreach (var get in myPosts)
            {
                float? rating;
                int? position, num_ratings, num_reviews, date;
                string? artist, names;
                string[] strings;
                Results.GenreParcer(get, out rating, out position, out num_ratings, out num_reviews, out date, out artist, out names, out strings);

                foreach (string s in strings)
                {
                    if (!genresList.Contains(s) && !artistLists.Contains(s) && !nameList.Contains(s))
                    {
                        artistLists.Add(s);
                        genresList.Add(s);
                        nameList.Add(s);


                        if (s.Contains(genre))
                        {

                            Results.GenreSelectionResult(rating, position, num_ratings, num_reviews, date, artist, names, s);

                        }                       
                    }
                }
            }
        }

        public static void SelectionEleven(Properties[] myPosts)
        {
           
            Random random = new Random();
            random.Next();
            
        }

    }
}
