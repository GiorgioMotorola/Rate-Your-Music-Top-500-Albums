using System.Net.Http;
using Newtonsoft.Json;
using System;
using System.Threading.Tasks;

namespace Code_Kentucky_Semester_One_Final_Project
{
    internal class Program
    {
        static async Task Main(string[] args)

        {

            await Start.StartProgram();
            await Utility.MakeAnotherSelection();

        }

        
    }
}