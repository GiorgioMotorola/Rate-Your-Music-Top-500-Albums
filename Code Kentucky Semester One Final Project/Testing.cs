using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;


namespace Code_Kentucky_Semester_One_Final_Project
{
    internal class Start
    {
        public static async Task StartProgram()
        {


            string url = "https://raw.githubusercontent.com/GiorgioMotorola/Rate-Your-Music-Top-500-JSON/main/JSON";
            string? pick = Utility.MainMenu();

            HttpClient client = new HttpClient();
        while(pick != "0")
            {

            
            try
            {
                var httpResponseMessage = await client.GetAsync(url);
                string jsonResponse = await httpResponseMessage.Content.ReadAsStringAsync();
                var myPosts = JsonConvert.DeserializeObject<Post[]>(jsonResponse);

                

            foreach (var post in myPosts)
             {
                                 
                    if (pick == "1")
                    {
                        Utility.SelectionOne(post);
                    }

                    else if (pick == "2")
                    {
                        if (post.position <= 10)
                        {
                            Utility.SelectionTwo(post);
                        }
                    }
                    else if (pick == "3")
                    {
                        Utility.SelectionThree(myPosts);

                    }
                    else if (pick == "4")
                    {
                        Utility.SelectionFour(myPosts);
                    }
                    else if (pick == "5")
                    {
                        Utility.SelectionFive(myPosts);

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
}