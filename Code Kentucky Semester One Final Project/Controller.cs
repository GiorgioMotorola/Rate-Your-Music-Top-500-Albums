using Newtonsoft.Json;
using System.Reflection.Emit;

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
                        Selections.SelectionGenre(myPosts, "Rock");
                    }
                    else if (UserSelection == "3")
                    {
                        Selections.SelectionGenre(myPosts, "Metal");

                    }

                    else if (UserSelection == "4")
                    {
                        Selections.SelectionGenre(myPosts, "Hip Hop");
                    }
                    else if (UserSelection == "5")
                    {
                        Selections.SelectionGenre(myPosts, "Country");

                    }
                    
                    else if (UserSelection == "6")
                    {
                        Selections.SelectionGenre(myPosts, "Jazz");

                    }
                    else if (UserSelection == "7")
                    {
                        Selections.SelectionGenre(myPosts, "Pop");

                    }
                    else if (UserSelection == "8")
                    {
                        Selections.SelectionGenre(myPosts, "Blues");

                    }
                    else if (UserSelection == "9")
                    {
                        Selections.SelectionGenre(myPosts, "Experimental");

                    }
                    else if (UserSelection == "10")
                    {
                        Selections.SelectionGenre(myPosts, "Electronic");

                    }
                    else if (UserSelection == "11")
                    {
                        Selections.SelectionEleven(myPosts);

                    }
                   
                    else if (UserSelection == "0")
                    {
                        Console.WriteLine("Goodbye, Kenny Loggins");
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
