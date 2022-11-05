

namespace Code_Kentucky_Semester_One_Final_Project
{
    public class Menus
    {
        public static void SplashScreen()
        {
            Console.WriteLine("\n\n\n\n\n\n\n");
            Console.WriteLine("\t\t\tTHE FOLLOWING DATA IN THIS CONSOLE APP WAS GATHERED FROM rateyourmusic.com.");
            Console.WriteLine("\t\t\tTHE DATA REFLECTS RYM USER RATINGS FOR THEIR TOP 500 ALBUMS OF ALL TIME");
            Console.WriteLine("\n\t\t\tPress ENTER to continue...");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\t\t\t\t\t\t\tThanks!");
            Console.WriteLine("\n\t\t\t\t\t\t\t  :)"); Console.Beep(500, 500);
            Thread.Sleep(500);
            Console.Clear();
        }
        public static string? MainMenu()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Thread.Sleep(500);
            Console.WriteLine("\n\n\t\t\t\t\tMake a selection below: \n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\t\t\t\t\t1. Return Entire List\n"); 

            Console.WriteLine("\t\t\t\t\t2. Return all ROCK related genres"); 
            Console.WriteLine("\t\t\t\t\t3. Return all METAL related genres"); 
            Console.WriteLine("\t\t\t\t\t4. Return all HIP HOP related genres"); 
            Console.WriteLine("\t\t\t\t\t5. Return all COUNTRY related genres"); 
            Console.WriteLine("\t\t\t\t\t6. Return all JAZZ related genres"); 
            Console.WriteLine("\t\t\t\t\t7. Return all POP related genres"); 
            Console.WriteLine("\t\t\t\t\t8. Return all BLUES related genres"); 
            Console.WriteLine("\t\t\t\t\t9. Return all EXPERIMENTAL related genres"); 
            Console.WriteLine("\t\t\t\t\t10. Return all ELECTRONIC related genres\n\n"); 
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\t\t\t\t\t000 to Quit :( \n"); 

            Console.ForegroundColor = ConsoleColor.White;
            var UserSelection = Console.ReadLine();
            Console.WriteLine();
            Console.Beep(650, 100);
            Console.WriteLine("Got it!\n\n");
            Thread.Sleep(800);
            Console.Beep(400, 100);
            return UserSelection;
        }


        public static async Task MakeAnotherSelection()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("--------------------------------------------------------------------------------------------\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\t\t\t\t\tWould you like to make another selection?");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\t\t\t\t\t1. Yes"); 
            Console.WriteLine("\t\t\t\t\t000. No\n");
            
            
            var anotherSelection = Console.ReadLine();

            while (true)
            {
                if (anotherSelection == "1")
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    await ProgramStartUp.StartProgram();
                }
                else if (anotherSelection == "000")
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Goodbye, Kenny Loggins!");
                    Environment.Exit(0);
                }
                else if (anotherSelection != "1" || anotherSelection != "000")
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Please Enter a Valid Selection");
                    await ProgramStartUp.StartProgram();
                    break;
                }
            }
        }        
    }
}
