using System;

namespace _04._Fishing_Boat
{
    class Program
    {
        static void Main(string[] args)
        {
            //•	Бюджет на групата – цяло число в интервала[1…8000]
            //•	Сезон –  текст: "Spring", "Summer", "Autumn", "Winter"
            //•	Брой рибари – цяло число в интервала[4…18]
            // "Spring", "Summer", "Autumn", "Winter"
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishermanCount = int.Parse(Console.ReadLine());
            double moneyNeeded = 0;

            switch (season)
            {
                case "Spring":
                    moneyNeeded = 3000;
                    break;
                case "Summer":
                case "Autumn":
                    moneyNeeded = 4200;
                    break;
                case "Winter":
                    moneyNeeded = 2600;
                    break;
            }
            if (fishermanCount <= 6)
                moneyNeeded -= moneyNeeded * 0.10;
            else if (fishermanCount >= 7 && fishermanCount <= 11)
                moneyNeeded -= moneyNeeded * 0.15;
            else if (fishermanCount >= 12)
            {
                moneyNeeded -= moneyNeeded * 0.25;
            }

            if (fishermanCount % 2 == 0 && season != "Autumn")
                moneyNeeded -= moneyNeeded * 0.05;

            if (budget >= moneyNeeded)
            {
                double moneyLeft = budget - moneyNeeded;
                Console.WriteLine($"Yes! You have {moneyLeft:f2} leva left.");
            }
            else
            {
                double money = moneyNeeded - budget;
                Console.WriteLine($"Not enough money! You need {money:f2} leva.");
            }
        }
    }
}
