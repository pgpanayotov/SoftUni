using System;

namespace _05._Account_Balance
{
    class Program
    {
        static void Main(string[] args)
        {
            double ballance = 0;

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "NoMoreMoney")
                {
                    break;
                }
                else
                {
                    double increase = double.Parse(input);
                    if (increase > 0)
                    {
                        ballance += increase;
                        Console.WriteLine($"Increase: {increase:f2}");
                    }
                    else
                    {
                        Console.WriteLine("Invalid operation!");
                        break;
                    }
                }
            }
            Console.WriteLine($"Total: {ballance:f2}");
        }
    }
}
