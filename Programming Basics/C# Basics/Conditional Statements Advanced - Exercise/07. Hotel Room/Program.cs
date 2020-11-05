using System;
using System.Threading;

namespace _07._Hotel_Room
{
    class Program
    {
        static void Main(string[] args)
        {
            const double MayAndOctoberStudioPricePerNight = 50;
            const double MayAndOctoberApartmentPricePerNight = 65;
            const double JuneAndSeptemberStudioPricePerNight = 75.20;
            const double JuneAndSeptemberApartmentPricePerNight = 68.70;
            const double JulyAndAugustStudioPricePerNight = 76;
            const double JulyAndAugustApartmentPricePerNight = 77;

            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());
            double studioTotalPrice = 0;
            double apartmentTotalPrice = 0;

            switch (month)
            {
                case "May":
                case "October":
                    studioTotalPrice = MayAndOctoberStudioPricePerNight * nights;
                    apartmentTotalPrice = MayAndOctoberApartmentPricePerNight * nights;
                    if (nights > 7 && nights <= 14)
                    {
                        studioTotalPrice -= studioTotalPrice * 0.05;
                    }
                    else if (nights > 14)
                    {
                        studioTotalPrice -= studioTotalPrice * 0.30;
                        apartmentTotalPrice -= apartmentTotalPrice * 0.10;
                    }
                    break;
                case "June":
                case "September":
                    studioTotalPrice = JuneAndSeptemberStudioPricePerNight * nights;
                    apartmentTotalPrice = JuneAndSeptemberApartmentPricePerNight * nights;
                    if (nights > 14)
                    {
                        studioTotalPrice -= studioTotalPrice * 0.20;
                        apartmentTotalPrice -= apartmentTotalPrice * 0.10;
                    }
                    break;
                case "July":
                case "August":
                    studioTotalPrice = JulyAndAugustStudioPricePerNight * nights;
                    apartmentTotalPrice = JulyAndAugustApartmentPricePerNight * nights;
                    if (nights > 14)
                    {
                        apartmentTotalPrice -= apartmentTotalPrice * 0.10;
                    }
                    break;
            }

            Console.WriteLine($"Apartment: {apartmentTotalPrice:f2} lv.");
            Console.WriteLine($"Studio: {studioTotalPrice:f2} lv.");
        }
    }
}
