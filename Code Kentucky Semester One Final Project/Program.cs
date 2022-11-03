using System.Diagnostics;

namespace Code_Kentucky_Semester_One_Final_Project
{
    public class ProgramStart
    {
        static async Task Main(string[] args)
       {
            Console.WriteLine("THE FOLLOWING DATA IN THIS CONSOLE APP WAS GATHERED FROM rateyourmusic.com.");
            Console.WriteLine("THE DATA REFLECTS RYM USER RATINGS FOR THEIR TOP 500 ALBUMS OF ALL TIME");
            Console.WriteLine("Press ENTER to continue...");
            Console.ReadLine();
            Console.WriteLine("Thanks!");
            await ProgramStartUp.StartProgram();
            await Menus.MakeAnotherSelection();            
        }
    }
}