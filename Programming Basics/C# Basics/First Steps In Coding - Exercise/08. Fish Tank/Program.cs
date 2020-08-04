using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Fish_Tank
{
    class Program
    {
        static void Main(string[] args)
        {
            int tankLenght = int.Parse(Console.ReadLine());
            int tankWidth = int.Parse(Console.ReadLine());
            int tankHeight = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            double tankVolume = tankLenght * tankWidth * tankHeight;
            double tankVolumeLiters = tankVolume * 0.001;
            percent *= 0.01;
            double liters = tankVolumeLiters * (1 - percent);

            Console.WriteLine(liters);
        }
    }
}
