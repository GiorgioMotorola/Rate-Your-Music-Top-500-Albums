using Newtonsoft.Json;



namespace Code_Kentucky_Semester_One_Final_Project
{
    public class ProgramStartUp
    {      
        public static async Task StartProgram()
        {
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
                Console.WriteLine("");
            }
            finally
            {
                client.Dispose();
            }
        }
    }
}
