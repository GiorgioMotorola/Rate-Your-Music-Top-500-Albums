using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                Console.ReadLine();
                Console.WriteLine("pick");
                var pick = Console.ReadLine();


                foreach (var post in myPosts)
                {

                    if (pick == "1")
                    {
                        Console.WriteLine($"{post.position}. {post.artist} - {post.name}");

                    }
                    else if (pick == "2")
                    {
                        if (post.position <= 10)
                        {
                            Console.WriteLine($"{post.position}. {post.artist} - {post.name}");
                        }
                    }


                }
                Console.ReadLine();

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
