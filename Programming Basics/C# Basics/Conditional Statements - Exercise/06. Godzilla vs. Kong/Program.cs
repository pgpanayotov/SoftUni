using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Godzilla_vs.Kong
{
    class Program
    {
        static void Main(string[] args)
        {
            //⦁	Бюджет за филма – реално число в интервала[1.00 … 1000000.00]
            double budget = double.Parse(Console.ReadLine());
            //⦁	Брой на статистите – цяло число в интервала[1 … 500]
            int statists = int.Parse(Console.ReadLine());
            //⦁	Цена за облекло на един статист – реално число в интервала[1.00 … 1000.00]
            double clothingPrice = double.Parse(Console.ReadLine());

            double decorCosts = budget * 0.1;
            double clothingCosts = statists * clothingPrice;
            double clothingDicsount = 0.0;
            if (statists > 150)
                clothingDicsount = clothingCosts * 0.1;
            double totalCosts = decorCosts + clothingCosts - clothingDicsount;
            
            if(budget < totalCosts)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {totalCosts - budget:f2} leva more.");                 
            }
            else
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {budget - totalCosts:f2} leva left.");
              
            }

        }
    }
}
