using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Time___15_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int mins = int.Parse(Console.ReadLine());

            mins += 15;
            if(mins > 59)
            {
                hour++;
                if(hour == 24)
                {
                    hour = 0;
                }
                mins -= 60;
            }
            if(mins < 10)
            {
                Console.WriteLine($"{hour}:0{mins}");
            }
            else
            {
                Console.WriteLine($"{hour}:{mins}");
            }
            
        }
    }
}
