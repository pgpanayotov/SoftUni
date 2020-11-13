using System;

namespace _09._Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int widthFree = int.Parse(Console.ReadLine());
            int lengthFree = int.Parse(Console.ReadLine());
            int heightFree = int.Parse(Console.ReadLine());
            int freeHouseVolume = widthFree * lengthFree * heightFree;
            int sumCubics = 0;
            string command = Console.ReadLine();

            while (command != "Done")
            {
                int currentCubic = int.Parse(command);
                sumCubics += currentCubic;
                if (freeHouseVolume < sumCubics)
                {
                    int neededCubics = sumCubics - freeHouseVolume;
                    Console.WriteLine($"No more free space! You need {neededCubics} Cubic meters more.");
                    break;
                }
                command = Console.ReadLine();
            }
            if (command == "Done")
            {
                int freeCubics = freeHouseVolume - sumCubics;
                Console.WriteLine($"{freeCubics} Cubic meters left.");
            }
        }
    }
}
