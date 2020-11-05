using System;

namespace _05._Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            //•	Първи ред – Бюджет, реално число в интервала[10.00...5000.00].
            //•	Втори ред –  Един от двата възможни сезона: „summer” или “winter”

            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string destination = "";
            string type = "";
            double moneySpend = 0;

            if (season == "summer")
                type = "Camp";
            else if (season == "winter")
                type = "Hotel";

            if (budget <= 100)
            {
                destination = "Bulgaria";
                if (season == "summer")
                    moneySpend = budget * 0.3;
                else if (season == "winter")
                    moneySpend = budget * 0.7;
            }
            else if (budget > 100 && budget <= 1000)
            {
                destination = "Balkans";
                if (season == "summer")
                    moneySpend = budget * 0.4;
                else if (season == "winter")
                    moneySpend = budget * 0.8;
            }
            else if (budget > 1000)
            {
                destination = "Europe";
                moneySpend = budget * 0.9;
                type = "Hotel";
            }

            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{type} - {moneySpend:f2}");

        }
    }
}
