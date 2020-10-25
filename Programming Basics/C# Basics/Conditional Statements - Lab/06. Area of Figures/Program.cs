using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Area_of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();
            if (figure == "square")
            {
                double side = double.Parse(Console.ReadLine());
                double area = side * side;
                Console.WriteLine(area);
            }
            else if (figure == "rectangle")
            {
                double width = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                double area = width * height;
                Console.WriteLine(area);
            }
            else if (figure == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                double area = Math.PI * radius * radius;
                Console.WriteLine(area);
            }
            else if (figure == "triangle")
            {
                double b = double.Parse(Console.ReadLine());
                double h = double.Parse(Console.ReadLine());
                double area = (b * h) / 2;
                Console.WriteLine(area);
            }
        }
    }
}
