using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Metric_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            //⦁	Първи ред: число за преобразуване - реално число 
            double num = double.Parse(Console.ReadLine());
            //⦁	Втори ред: входна мерна единица - текст
            string input = Console.ReadLine();
            //⦁	Трети ред: изходна мерна единица (за резултата) - текст
            string output = Console.ReadLine();

            if(input == "m")
            {
                if(output == "mm")
                {
                    Console.WriteLine($"{num * 1000:f3}");
                }
                else if(output == "cm")
                {
                    Console.WriteLine($"{num * 100:f3}");
                }
            }
            else if(input == "mm")
            {
                if(output == "m")
                {
                    Console.WriteLine($"{num / 1000:f3}");
                }
                else if(output == "cm")
                {
                    Console.WriteLine($"{num / 10:f3}");
                }
            }
            else if (input == "cm")
            {
                if (output == "m")
                {
                    Console.WriteLine($"{num / 100:f3}");
                }
                else if (output == "mm")
                {
                    Console.WriteLine($"{num * 10:f3}");
                }
            }

        }
    }
}
