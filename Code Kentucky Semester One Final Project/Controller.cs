using Newtonsoft.Json;
using System.Reflection.Emit;
using static System.Net.Mime.MediaTypeNames;

namespace Code_Kentucky_Semester_One_Final_Project
{
    internal class ProgramStartUp
    {

       
        public static async Task StartProgram()
        {

            string url = "https://raw.githubusercontent.com/GiorgioMotorola/Rate-Your-Music-Top-500-JSON/main/JSON";

            HttpClient client = new HttpClient();

            try
            {
                var httpResponseMessage = await client.GetAsync(url);
                string jsonResponse = await httpResponseMessage.Content.ReadAsStringAsync();
                var myPosts = JsonConvert.DeserializeObject<Properties[]>(jsonResponse);
                string? UserSelection = Menus.MainMenu();
               
                foreach (var post in myPosts)
                {

                    if (UserSelection == "1")
                    {
                        Selections.SelectionAll(post);
                    }
                    else if (UserSelection == "2")
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("----------------------------------------------ROCK GENRES---------------------------------------------");
                        Console.WriteLine();
                        Console.WriteLine();
                        Selections.SelectionGenre(myPosts, "Rock");
                        
                    }
                    else if (UserSelection == "3")
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("----------------------------------------------METAL GENRES---------------------------------------------");
                        Console.WriteLine();
                        Console.WriteLine();
                        Selections.SelectionGenre(myPosts, "Metal");
                    }
                    else if (UserSelection == "4")
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("---------------------------------------------HIP HOP GENRES--------------------------------------------");
                        Console.WriteLine();
                        Console.WriteLine();
                        Selections.SelectionGenre(myPosts, "Hip Hop");
                    }
                    else if (UserSelection == "5")
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("---------------------------------------------COUNTRY GENRES--------------------------------------------");
                        Console.WriteLine();
                        Console.WriteLine();
                        Selections.SelectionGenre(myPosts, "Country");
                    }
                    else if (UserSelection == "6")
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("----------------------------------------------JAZZ GENRES---------------------------------------------");
                        Console.WriteLine();
                        Console.WriteLine();
                        Selections.SelectionGenre(myPosts, "Jazz");
                    }
                    else if (UserSelection == "7")
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("-----------------------------------------------POP GENRES----------------------------------------------");
                        Console.WriteLine();
                        Console.WriteLine();
                        Selections.SelectionGenre(myPosts, "Pop");
                    }
                    else if (UserSelection == "8")
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("----------------------------------------------BLUES GENRES---------------------------------------------");
                        Console.WriteLine();
                        Console.WriteLine();
                        Selections.SelectionGenre(myPosts, "Blues");
                    }
                    else if (UserSelection == "9")
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("------------------------------------------EXPERIMENTAL GENRES------------------------------------------");
                        Console.WriteLine();
                        Console.WriteLine();
                        Selections.SelectionGenre(myPosts, "Experimental");
                    }
                    else if (UserSelection == "10")
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("-------------------------------------------ELECTRIONIC GENRES------------------------------------------");
                        Console.WriteLine();
                        Console.WriteLine();
                        Selections.SelectionGenre(myPosts, "Electronic");
                    }                    
                    else if (UserSelection == "000")
                    {
                        Console.WriteLine("Goodbye, Kenny Loggins!");
                        Environment.Exit(0);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                client.Dispose();
            }
        }
    }
}
