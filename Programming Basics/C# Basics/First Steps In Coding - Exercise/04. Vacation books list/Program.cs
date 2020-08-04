using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Vacation_books_list
{
    class Program
    {
        static void Main(string[] args)
        {
            int pagesCount = int.Parse(Console.ReadLine());
            double pagesReadPerHour = double.Parse(Console.ReadLine());
            int daysToRead = int.Parse(Console.ReadLine());

            double timeToReadBook = pagesCount / pagesReadPerHour;

            double hoursNeeded = timeToReadBook / daysToRead;

            Console.WriteLine(hoursNeeded);
        }
    }
}
