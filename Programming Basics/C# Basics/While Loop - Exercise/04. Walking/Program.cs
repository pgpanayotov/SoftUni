using System;

namespace _04._Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            const int stepsTarget = 10000;
            int stepsCount = 0;

            while (stepsCount < stepsTarget)
            {
                string input = Console.ReadLine();

                if (input == "Going home")
                {
                    int steps = int.Parse(Console.ReadLine());
                    stepsCount += steps;
                    if(stepsCount >= stepsTarget)
                        break;
                    else
                    {
                        Console.WriteLine($"{stepsTarget - stepsCount} more steps to reach goal.");
                        return;
                    }
                }
                else
                {
                    int steps = int.Parse(input);
                    stepsCount += steps;
                }
            }

            Console.WriteLine("Goal reached! Good job!");
            Console.WriteLine($"{stepsCount - stepsTarget} steps over the goal!");

        }
    }
}
