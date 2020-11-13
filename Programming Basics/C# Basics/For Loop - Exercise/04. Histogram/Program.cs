using System;

namespace _04._Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = int.Parse(Console.ReadLine());
            int p1Count = 0;
            int p2Count = 0;
            int p3Count = 0;
            int p4Count = 0;
            int p5Count = 0;

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num < 200)
                    p1Count++;
                else if (num >= 200 && num <= 399)
                    p2Count++;
                else if (num >= 400 && num <= 599)
                    p3Count++;
                else if (num >= 600 && num <= 799)
                    p4Count++;
                else if (num >= 800)
                    p5Count++;
            }

            double p1 = p1Count / n * 100.00;
            double p2 = p2Count / n * 100.00;
            double p3 = p3Count / n * 100.00;
            double p4 = p4Count / n * 100.00;
            double p5 = p5Count / n * 100.00;
            Console.WriteLine($"{p1:f2}%");
            Console.WriteLine($"{p2:f2}%");
            Console.WriteLine($"{p3:f2}%");
            Console.WriteLine($"{p4:f2}%");
            Console.WriteLine($"{p5:f2}%");

        }
    }
}
