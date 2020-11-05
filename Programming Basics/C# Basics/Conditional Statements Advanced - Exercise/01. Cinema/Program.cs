using System;

namespace _01._Cinema
{
    class Program
    {
        static void Main()
        {
            const double Premiere = 12.00;
            const double Normal = 7.50;
            const double Discount = 5.00;

            string projectionType = Console.ReadLine();
            int r = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            double income = 0.0;

            if (projectionType == "Premiere")
                income = (r * c) * Premiere;
            else if (projectionType == "Normal")
                income = (r * c) * Normal;
            else if (projectionType == "Discount")
                income = (r * c) * Discount;

            Console.WriteLine("{0:f2} leva", income);
        }
    }
}
