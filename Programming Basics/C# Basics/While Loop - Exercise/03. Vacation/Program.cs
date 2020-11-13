using System;

namespace _03._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyNeeded = double.Parse(Console.ReadLine());
            double ballance = double.Parse(Console.ReadLine());

            int daysCount = 0;
            int daysSpendCount = 0;

            while (ballance < moneyNeeded)
            {
                string action = Console.ReadLine();
                double ammount = double.Parse(Console.ReadLine());
                daysCount++;

                if (action == "spend")
                {
                    ballance -= ammount;
                    if (ballance < 0)
                        ballance = 0;
                    daysSpendCount++;
                    if (daysSpendCount == 5)
                    {
                        Console.WriteLine("You can't save the money.");
                        Console.WriteLine(daysCount);
                        return;
                    }
                }
                else if (action == "save")
                {
                    ballance += ammount;
                    daysSpendCount = 0;
                }
            }

            Console.WriteLine($"You saved the money for {daysCount} days.");
        }
    }
}
