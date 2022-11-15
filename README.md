# Top 500 Albums According to rateyourmusic.com Users

http://www.Rateyourmusic.com is one of the largest music databases and communities online. Users can sign up and rate albums they have listened to between 1-5 stars. 
I located a .tsv file off of https://data.world/notgibs/rateyourmusic-top500-albums that contained the Top 500 albums of all time according to RYM users and converted it to a .JSON file. 


In order to demonstrate making a RESTful API call, I put the .JSON file in a Git Hub repository. The program receives the .JSON response body and then deserializes it to allow the user to parse thru the data:


```C#
string url = "https://raw.githubusercontent.com/GiorgioMotorola/Rate-Your-Music-Top-500-JSON/main/JSON";
HttpClient client = new HttpClient();
```

```C#
 var httpResponseMessage = await client.GetAsync(url);
string jsonResponse = await httpResponseMessage.Content.ReadAsStringAsync();
Properties[] myPosts = JsonConvert.DeserializeObject<Properties[]>(jsonResponse);
string? UserSelection = Menus.MainMenu();
```



The above block of code is ran thru a Try Catch statement, then a foreach loop and finally a Switch statement which controls the user selection in the menu: 



```C# 
string url = "https://raw.githubusercontent.com/GiorgioMotorola/Rate-Your-Music-Top-500-JSON/main/JSON";
            HttpClient client = new HttpClient();

            try
            {
                var httpResponseMessage = await client.GetAsync(url);
                string jsonResponse = await httpResponseMessage.Content.ReadAsStringAsync();
                Properties[] myPosts = JsonConvert.DeserializeObject<Properties[]>(jsonResponse);
                string? UserSelection = Menus.MainMenu();
               
                foreach (var post in myPosts)
                {

                    switch (UserSelection)
                    {
                        case "1":
                            Selections.SelectionAll(post);
                            break;
                        case "2":
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("----------------------------------------------ROCK GENRES---------------------------------------------\n\n");
                            Selections.SelectionGenre(myPosts, "Rock");
                            break;
                        case "3":
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("----------------------------------------------METAL GENRES---------------------------------------------\n\n");
                            Selections.SelectionGenre(myPosts, "Metal");
                            break;
                        case "4":
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("---------------------------------------------HIP HOP GENRES--------------------------------------------\n\n");
                            Selections.SelectionGenre(myPosts, "Hip Hop");
                            break;
                        case "5":
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("---------------------------------------------COUNTRY GENRES--------------------------------------------\n\n");
                            Selections.SelectionGenre(myPosts, "Country");
                            break;
                        case "6":
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("----------------------------------------------JAZZ GENRES----------------------------------------------\n\n");
                            Selections.SelectionGenre(myPosts, "Jazz");
                            break;
                        case "7":
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("-----------------------------------------------POP GENRES----------------------------------------------\n\n");
                            Selections.SelectionGenre(myPosts, "Pop");
                            break;
                        case "8":
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("----------------------------------------------BLUES GENRES---------------------------------------------\n\n");
                            Selections.SelectionGenre(myPosts, "Blues");
                            break;
                        case "9":
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("------------------------------------------EXPERIMENTAL GENRES------------------------------------------\n\n");
                            Selections.SelectionGenre(myPosts, "Experimental");
                            break;
                        case "10":
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("-------------------------------------------ELECTRIONIC GENRES------------------------------------------\n\n");
                            Selections.SelectionGenre(myPosts, "Electronic");
                            break;
                        case "11":
                            Selections.SelectionName(myPosts);
                            break;
                        case "000":
                            Console.WriteLine("Goodbye, Kenny Loggins!");
                            Environment.Exit(0);
                            break;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("--End of List--");
            }
            finally
            {                
                client.Dispose();
            }
        }
```        



The Selections class will either return everything, allow the user to search by Artist name or store Artist, Genre and Album name into lists and split thru all Genres. It then references the Results class which displays the selection to the user by calling the Properties: 



```C#
 public class Selections
    {

        public static void SelectionAll(Properties post)
        {
            Results.SelectionResult(post);
        }

        public static void SelectionName(Properties[] myPosts)
        {
            Console.WriteLine("");
            Console.WriteLine("Please Enter an Artists Name (lowercase only, please):");
            Console.WriteLine("Try: 'radiohead' or 'kendrick lamar'");
            var select = Console.ReadLine();

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
                


                  if (select.Contains(artist.ToLower()))
                {
                    Results.ArtistSelectionResult(rating, position, num_ratings, num_reviews, date, artist, names, genres);
                }                                                  
            }             
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
        
```       

The output returns the data, including a link you can Copy/Paste into a Spotify search bar or your preferred internet browser: 
![image](https://user-images.githubusercontent.com/97712526/202047795-02bf32c1-2bd8-4ec4-aeab-efacc49354dd.png)


This Console applicaion meets the following final project requirements: 

1. Read data from an external file, such as text, JSON, CSV, etc and use that data in your application.
2. Implement a “master loop” console application where the user can repeatedly enter commands/perform actions, including choosing to exit the program.
3. Create a dictionary or list, populate it with several values, retrieve at least one value, and use it in your program.

