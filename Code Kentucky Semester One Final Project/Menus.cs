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
            Console.WriteLine("Make a selection below: \n");
            Console.WriteLine(" 1. Return Entire List");
            
            Console.WriteLine();
            Console.WriteLine(" 2. Return all ROCK related genres");
            Console.WriteLine(" 3. Return all METAL related genres");
            Console.WriteLine(" 4. Return all HIP HOP related genres");
            Console.WriteLine(" 5. Return all COUNTRY related genres");
            Console.WriteLine(" 6. Return all JAZZ related genres");
            Console.WriteLine(" 7. Return all POP related genres");
            Console.WriteLine(" 8. Return all BLUES related genres");
            Console.WriteLine(" 9. Return all EXPERIMENTAL related genres");
            Console.WriteLine("10. Return all ELECTRONIC related genres");
            Console.WriteLine();
            Console.WriteLine("11. Can't Decide What To Listen To?");
            Console.WriteLine();


            Console.WriteLine("0. Quit :( \n");


            var UserSelection = Console.ReadLine();
            Console.WriteLine();
            Console.Beep(650, 100);
            return UserSelection;
        }


        public static async Task MakeAnotherSelection()
        {
            Console.WriteLine("Would you like to make another selection?");
            Console.WriteLine("1. Yes");
            Console.WriteLine("2. No");
            var anotherSelection = Console.ReadLine();

            while (true)
            {
                if (anotherSelection == "1")
                {
                    await ProgramStartUp.StartProgram();

                }
                else if (anotherSelection == "2")
                {
                    Console.WriteLine("Goodbye, Kenny Loggins");
                    Environment.Exit(0);
                }
            }
        }

        
    }
}
