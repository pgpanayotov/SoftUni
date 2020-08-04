using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Projects_Creation
{
    class Program
    {
        static void Main(string[] args)
        {
            string archName = Console.ReadLine();
            int projects = int.Parse(Console.ReadLine());
            int hoursNeeded = projects * 3;

            Console.WriteLine($"The architect {archName} will need {hoursNeeded} hours to complete {projects} project/s.");
        }
    }
}
