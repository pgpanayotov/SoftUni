using System;

namespace _07._Min_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = int.MaxValue;

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Stop")
                    break;
                else
                {
                    int n = int.Parse(input);
                    if (n < max)
                    {
                        max = n;
                    }
                }
            }

            Console.WriteLine(max);
        }
    }
}
