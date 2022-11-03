using System.Diagnostics;

namespace Code_Kentucky_Semester_One_Final_Project
{
    public class ProgramStart
    {
        static async Task Main(string[] args)
       {


            await ProgramStartUp.StartProgram();
            await Menus.MakeAnotherSelection();

            
        }
    }
}