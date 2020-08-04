using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Deposit_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double depositSum = double.Parse(Console.ReadLine());
            int term = int.Parse(Console.ReadLine());
            double afflicationPercent = double.Parse(Console.ReadLine());

            double twelveMonthAfflication = (depositSum * afflicationPercent) / 100;
            double oneMonthAfflication = twelveMonthAfflication / 12;
            double sum = depositSum + (term * oneMonthAfflication);

            Console.WriteLine(sum);
        }
    }
}
