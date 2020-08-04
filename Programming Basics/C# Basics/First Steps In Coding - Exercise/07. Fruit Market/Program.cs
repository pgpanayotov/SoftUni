using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Fruit_Market
{
    class Program
    {
        static void Main(string[] args)
        {
            double strawberriesPrice = double.Parse(Console.ReadLine());
            double bananaKg = double.Parse(Console.ReadLine());
            double orangeKg = double.Parse(Console.ReadLine());
            double raspberriesKg = double.Parse(Console.ReadLine());
            double strawberriesKg = double.Parse(Console.ReadLine());

            //
            double raspberriesPrice = strawberriesPrice / 2;
            double orangePrice = raspberriesPrice - (0.4 * raspberriesPrice);
            double bananaPrice = raspberriesPrice - (0.8 * raspberriesPrice);

            double raspberrySum = raspberriesKg * raspberriesPrice;
            double orangeSum = orangeKg * orangePrice;
            double bananaSum = bananaKg * bananaPrice;
            double strawperriesSum = strawberriesKg * strawberriesPrice;

            Console.WriteLine(raspberrySum + orangeSum + bananaSum + strawperriesSum);
        }
    }
}
