using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Birthday_party
{
    class Program
    {
        static void Main(string[] args)
        {
            double hallPrice = double.Parse(Console.ReadLine());

            double cakePrice = (hallPrice * 20) / 100;

            double drinksPrice = cakePrice;
            drinksPrice = drinksPrice - (drinksPrice * 0.45);

            double animatorPrice = hallPrice / 3;
            double sum = hallPrice + cakePrice + drinksPrice + animatorPrice;

            Console.WriteLine(sum);
        }
    }
}
