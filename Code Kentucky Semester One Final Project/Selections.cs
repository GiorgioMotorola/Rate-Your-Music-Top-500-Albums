

using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;

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
                
                rating = (float?)get.rating;
                position = (int?)(long?)get.position;
                num_ratings = (int?)(long?)get.num_ratings;
                num_reviews = (int?)(long?)get.num_reviews;
                date = (int?)(long?)get.date;
                artist = get.artist;
                string? genres = get.genres;
                names = (string?)get.name;
                strings = genres.Split(",");

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
    }    
}
