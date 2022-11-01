using Newtonsoft.Json;


namespace Code_Kentucky_Semester_One_Final_Project
{
    internal class Start
    {
        public static async Task StartProgram()
        {

            string url = "https://raw.githubusercontent.com/GiorgioMotorola/Rate-Your-Music-Top-500-JSON/main/JSON";

            HttpClient client = new HttpClient();

            try
            {
                var httpResponseMessage = await client.GetAsync(url);
                string jsonResponse = await httpResponseMessage.Content.ReadAsStringAsync();
                var myPosts = JsonConvert.DeserializeObject<Post[]>(jsonResponse);

                string? pick = Results.MainMenu();

                foreach (var post in myPosts)
                {

                    if (pick == "1")
                    {
                        Selections.SelectionOne(post);

                    }
                    else if (pick == "2")
                    {
                        if (post.position <= 10)
                        {
                            Selections.SelectionTwo(post);
                        }
                    }
                    else if (pick == "3")
                    {
                        Selections.SelectionThree(myPosts);

                    }

                    else if (pick == "4")
                    {
                        Selections.SelectionFour(myPosts);
                    }
                    else if (pick == "5")
                    {
                        Selections.SelectionFive(myPosts);

                    }
                    else if (pick == "0")
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
