using System;

namespace _13._Ski_Trip
{
    class Program
    {
        static void Main()
        {
            const double onePersonPrice = 18.00;
            const double apartmentPrice = 25.00;
            const double presidentApartmentPrice = 35.00;


            int nights = int.Parse(Console.ReadLine()) - 1;
            string roomType = Console.ReadLine();
            string rate = Console.ReadLine();

            double totalPrice = 0.0;

            if (roomType == "room for one person")
            {
                totalPrice = onePersonPrice * nights;
            }
            else if (roomType == "apartment")
            {
                totalPrice = apartmentPrice * nights;
                if (nights < 10)
                    totalPrice = totalPrice * 0.70;

                else if (nights >= 10 && nights <= 15)
                    totalPrice = totalPrice * 0.65;

                else if (nights > 15)
                    totalPrice = totalPrice * 0.50;
            }
            else if (roomType == "president apartment")
            {
                totalPrice = presidentApartmentPrice * nights;
                if (nights < 10)
                    totalPrice = totalPrice * 0.90;

                else if (nights >= 10 && nights <= 15)
                    totalPrice = totalPrice * 0.85;

                else if (nights > 15)
                    totalPrice = totalPrice * 0.80;
            }

            if (rate == "positive")
                totalPrice = totalPrice * 1.25;
            else if (rate == "negative")
                totalPrice = totalPrice * 0.90;

            Console.WriteLine($"{totalPrice:f2}");


        }
    }
}
