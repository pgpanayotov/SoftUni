using System;

namespace _11._Clever_Lily
{
    class Program
    {
        static void Main(string[] args)
        {
            int lilyAge = int.Parse(Console.ReadLine());
            double washmachinePrice = double.Parse(Console.ReadLine());
            double toysPrice = double.Parse(Console.ReadLine());

            double moneySaved = 0;

            for (int i = 1; i <= lilyAge; i++)
            {
                if (i % 2 == 0)
                {
                    moneySaved += i * 5;
                    // Brother motherfucker
                    moneySaved--;
                }
                else
                {
                    // recieved a toy wich Lily sells for 6 bucks
                    moneySaved += toysPrice;
                }
            }

            if(moneySaved >= washmachinePrice)
            {
                Console.WriteLine($"Yes! {(moneySaved - washmachinePrice):f2}");
            }
            else
            {
                Console.WriteLine($"No! {(washmachinePrice - moneySaved):f2}");
            }
            
        }
    }
}
