# Rate-Your-Music-Top-500-Albums

http://www.Rateyourmusic.com is one of the largest music databases and communities online. Users can sign up and rate albums they have listened to between 1-5 stars. 
I located a .tsv file off of https://data.world/notgibs/rateyourmusic-top500-albums and converted it to a .JSON file. 


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
