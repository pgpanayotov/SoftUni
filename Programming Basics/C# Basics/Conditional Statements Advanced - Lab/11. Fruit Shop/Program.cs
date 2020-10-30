﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Fruit_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string day = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            double sum = 0.0;
            switch (day)
            {
                case "Monday":
                case "Tuesday":
                case "Wednesday":
                case "Thursday":
                case "Friday":
                    switch (fruit)
                    {
                        case "banana":
                            sum = quantity * 2.50;
                            break;
                        case "apple":
                            sum = quantity * 1.20;
                            break;
                        case "orange":
                            sum = quantity * 0.85;
                            break;
                        case "grapefruit":
                            sum = quantity * 1.45;
                            break;
                        case "kiwi":
                            sum = quantity * 2.70;
                            break;
                        case "pineapple":
                            sum = quantity * 5.50;
                            break;
                        case "grapes":
                            sum = quantity * 3.85; 
                            break;
                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    break;
                case "Saturday":
                case "Sunday":
                    switch (fruit)
                    {
                        case "banana":
                            sum = quantity * 2.70;
                            break;
                        case "apple":
                            sum = quantity * 1.25;
                            break;
                        case "orange":
                            sum = quantity * 0.90;
                            break;
                        case "grapefruit":
                            sum = quantity * 1.60;
                            break;
                        case "kiwi":
                            sum = quantity * 3.00;
                            break;
                        case "pineapple":
                            sum = quantity * 5.60;
                            break;
                        case "grapes":
                            sum = quantity * 4.20;
                            break;
                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("error");
                    break;
            }
            if(sum != 0.0)
                Console.WriteLine($"{sum:f2}");
        }
    }
}
