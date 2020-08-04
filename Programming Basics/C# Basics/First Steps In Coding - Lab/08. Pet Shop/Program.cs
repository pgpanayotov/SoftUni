using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Pet_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfDogs = int.Parse(Console.ReadLine());
            int otherAnimals = int.Parse(Console.ReadLine());

            double price = numberOfDogs * 2.5 + otherAnimals * 4;

            Console.WriteLine($"{price} lv.");
        }
    }
}
