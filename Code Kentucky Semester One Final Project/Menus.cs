using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Code_Kentucky_Semester_One_Final_Project
{
    public class Menus
    {
        public static string? MainMenu()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
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
            Console.WriteLine("Got it!");
            Thread.Sleep(800);
            Console.Beep(400, 100);
            return UserSelection;
        }


        public static async Task MakeAnotherSelection()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("--------------------------------------------------------------------------------------------");
            Console.WriteLine("Would you like to make another selection?");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("1. Yes\n");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("000. No\n");
            
            
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
