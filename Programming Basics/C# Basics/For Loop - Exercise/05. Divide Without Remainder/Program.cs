using System;

namespace _05._Divide_Without_Remainder
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = int.Parse(Console.ReadLine());
            int p1Count = 0;
            int p2Count = 0;
            int p3Count = 0;


            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num % 2 == 0)
                    p1Count++;
                if (num % 3 == 0)
                    p2Count++;
                if (num % 4 == 0)
                    p3Count++;

            }

            double p1 = p1Count / n * 100.00;
            double p2 = p2Count / n * 100.00;
            double p3 = p3Count / n * 100.00;

            Console.WriteLine($"{p1:f2}%");
            Console.WriteLine($"{p2:f2}%");
            Console.WriteLine($"{p3:f2}%");

        }
    }
}
