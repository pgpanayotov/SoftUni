using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Charity_Campaign
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int confectioner = int.Parse(Console.ReadLine());
            int cakes = int.Parse(Console.ReadLine());
            int waffles = int.Parse(Console.ReadLine());
            int pancakes = int.Parse(Console.ReadLine());

            int cakesProfit = cakes * 45;
            double wafflesProfit = waffles * 5.80;
            double pancakesProfit = pancakes * 3.20;

            double profitDaily = (cakesProfit + wafflesProfit + pancakesProfit) * confectioner;
            double sumTotal = profitDaily * days;
            double sum = sumTotal - (sumTotal / 8);
            Console.WriteLine(sum);
        }
    }
}
