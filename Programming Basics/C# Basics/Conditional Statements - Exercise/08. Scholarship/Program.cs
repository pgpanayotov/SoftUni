using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Scholarship
{
    class Program
    {
        static void Main(string[] args)
        {
            //⦁	Доход в лева - реално число в интервала[0.00..6000.00]
            double income = double.Parse(Console.ReadLine());
            //⦁	Среден успех -реално число в интервала[2.00...6.00]
            double avgRating = double.Parse(Console.ReadLine());
            //⦁	Минимална работна заплата - реално число в интервала[0.00..1000.00]
            double minSalary = double.Parse(Console.ReadLine());

            double socialScholarship = 0.0;
            double scholarship = 0.0;

            if (avgRating >= 5.5)
                scholarship = avgRating * 25;
               
            if (income < minSalary && avgRating > 4.5)
                socialScholarship = minSalary * 0.35;
            
            if(scholarship > socialScholarship)
                Console.WriteLine($"You get a scholarship for excellent results {Math.Floor(scholarship)} BGN");
            else if(socialScholarship > scholarship)
                Console.WriteLine($"You get a Social scholarship {Math.Floor(socialScholarship)} BGN");
            else
                Console.WriteLine("You cannot get a scholarship!");

        }
    }
}
