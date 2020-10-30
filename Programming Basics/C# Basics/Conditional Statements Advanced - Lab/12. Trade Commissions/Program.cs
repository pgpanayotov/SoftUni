using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Trade_Commissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());
            double commision = 0.0;
            if(sales > 0.0)
            {
                if (city == "Sofia")
                {
                    if (0 <= sales && sales <= 500)
                        commision = sales * 0.05;
                    else if (500 < sales && sales <= 1000)
                        commision = sales * 0.07;
                    else if (1000 < sales && sales <= 10000)
                        commision = sales * 0.08;
                    else if (sales > 10000)
                        commision = sales * 0.12;
                }
                else if (city == "Varna")
                {
                    if (0 <= sales && sales <= 500)
                        commision = sales * 0.045;
                    else if (500 < sales && sales <= 1000)
                        commision = sales * 0.075;
                    else if (1000 < sales && sales <= 10000)
                        commision = sales * 0.10;
                    else if (sales > 10000)
                        commision = sales * 0.13;
                }
                else if (city == "Plovdiv")
                {
                    if (0 <= sales && sales <= 500)
                        commision = sales * 0.05;
                    else if (500 < sales && sales <= 1000)
                        commision = sales * 0.07;
                    else if (1000 < sales && sales <= 10000)
                        commision = sales * 0.08;
                    else if (sales > 10000)
                        commision = sales * 0.12;
                }
                else
                {
                    Console.WriteLine("error");
                }
                Console.WriteLine($"{commision:f2});
            }
            else
            {
                Console.WriteLine("error");
            }
            
        }
    }
}
