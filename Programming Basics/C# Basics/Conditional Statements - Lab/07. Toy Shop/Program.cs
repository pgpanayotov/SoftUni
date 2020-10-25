using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Toy_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            const double puzzlePrice = 2.60;
            const double talkingDollPrice = 3;
            const double tedyBearPrice = 4.10;
            const double minionPrice = 8.20;
            const double truckPrice = 2;

            double priceForEcscursion = double.Parse(Console.ReadLine());
            int countOfPuzzles = int.Parse(Console.ReadLine());
            int countOfTalkingDolls = int.Parse(Console.ReadLine());
            int countOfTeddyBears = int.Parse(Console.ReadLine());
            int countOfMinions = int.Parse(Console.ReadLine());
            int countOfTrucks = int.Parse(Console.ReadLine());

            int countOfToys = countOfPuzzles + countOfTalkingDolls + countOfTeddyBears + countOfMinions + countOfTrucks;
            double sum = countOfPuzzles * puzzlePrice + countOfTalkingDolls * talkingDollPrice + countOfTeddyBears * tedyBearPrice + countOfMinions * minionPrice + countOfTrucks * truckPrice;

            double discount = 0;
            if (countOfToys >= 50)
            {
                discount = sum * 0.25;
            }
            double finalSum = sum - discount;
            double rent = finalSum * 0.10;
            double moneyMade = finalSum - rent;

            if (moneyMade >= priceForEcscursion)
            {
                double moneyLeft = moneyMade - priceForEcscursion;
                Console.WriteLine($"Yes! {moneyLeft:f2} lv left.");
            }
            else
            {
                double moneyNeeded = priceForEcscursion - moneyMade;
                Console.WriteLine($"Not enough money! {moneyNeeded:f2} lv needed.");
            }
        }
    }
}