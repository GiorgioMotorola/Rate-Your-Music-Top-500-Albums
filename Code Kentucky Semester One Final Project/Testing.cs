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

            HttpClient client = new HttpClient();
        
            try
            {
                var httpResponseMessage = await client.GetAsync(url);
                string jsonResponse = await httpResponseMessage.Content.ReadAsStringAsync();
                var myPosts = JsonConvert.DeserializeObject<Post[]>(jsonResponse);

                string? pick = Utility.MainMenu();

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
                    else if(pick == "0")
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
