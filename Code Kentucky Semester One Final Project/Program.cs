using System.Diagnostics;

namespace Code_Kentucky_Semester_One_Final_Project
{
    public class ProgramStart
    {
        static async Task Main(string[] args)
       {
            Console.WriteLine("\n\n\n\n\n\n\n");
            Console.WriteLine("\t\t\tTHE FOLLOWING DATA IN THIS CONSOLE APP WAS GATHERED FROM rateyourmusic.com.");
            Console.WriteLine("\t\t\tTHE DATA REFLECTS RYM USER RATINGS FOR THEIR TOP 500 ALBUMS OF ALL TIME");
            Console.WriteLine("\n\t\t\tPress ENTER to continue...");
            Console.ReadLine();
            Console.WriteLine("\n\t\t\tThanks!");
            
            await ProgramStartUp.StartProgram();
            await Menus.MakeAnotherSelection();            
        }
    }
}