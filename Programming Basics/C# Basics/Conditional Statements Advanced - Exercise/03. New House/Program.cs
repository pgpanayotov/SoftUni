using System;

namespace _03._New_House
{
    class Program
    {
        static void Main(string[] args)
        {
            // "Roses", "Dahlias", "Tulips", "Narcissus", "Gladiolus"
            const double RosesPrice = 5;
            const double DahliasPrice = 3.80;
            const double TulipsPrice = 2.80;
            const double NarcissusPrice = 3;
            const double GladiolusPrice = 2.50;

            string flowers = Console.ReadLine();
            int flowersCount = int.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());
            double totalMoney = 0;

            switch (flowers)
            {
                case "Roses":
                    totalMoney = flowersCount > 80 ?
                        flowersCount * RosesPrice - flowersCount * RosesPrice * 0.10 :
                        flowersCount * RosesPrice;
                    break;
                case "Dahlias":
                    totalMoney = flowersCount > 90 ?
                        flowersCount * DahliasPrice - flowersCount * DahliasPrice * 0.15 :
                        flowersCount * DahliasPrice;
                    break;
                case "Tulips":
                    totalMoney = flowersCount > 80 ?
                        flowersCount * TulipsPrice - flowersCount * TulipsPrice * 0.15 :
                        flowersCount * TulipsPrice;
                    break;
                case "Narcissus":
                    totalMoney = flowersCount < 120 ?
                        flowersCount * NarcissusPrice + flowersCount * NarcissusPrice * 0.15 :
                        flowersCount * NarcissusPrice;
                    break;
                case "Gladiolus":
                    totalMoney = flowersCount < 80 ?
                        flowersCount * GladiolusPrice + flowersCount * GladiolusPrice * 0.20 :
                        flowersCount * GladiolusPrice;
                    break;
                default:
                    break;
            }

            if (budget >= totalMoney)
            {
                double moneyLeft = budget - totalMoney;
                Console.WriteLine($"Hey, you have a great garden with {flowersCount} {flowers} and {moneyLeft:f2} leva left.");
            }
            else
            {
                double moneyNeeded = totalMoney - budget;
                Console.WriteLine($"Not enough money, you need {moneyNeeded:f2} leva more.");
            }
        }
    }
}
