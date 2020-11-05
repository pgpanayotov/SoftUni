using System;

namespace _06._Operations_Between_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            string o = Console.ReadLine();
            string resultString = "";

            if (o == "+")
            {
                int result = n1 + n2;
                string evenOdd = result % 2 == 0 ? "even" : "odd";
                resultString = $"{n1} {o} {n2} = {result} - {evenOdd}";
            }
            else if (o == "-")
            {
                int result = n1 - n2;
                string evenOdd = result % 2 == 0 ? "even" : "odd";
                resultString = $"{n1} {o} {n2} = {result} - {evenOdd}";
            }
            else if (o == "*")
            {
                int result = n1 * n2;
                string evenOdd = result % 2 == 0 ? "even" : "odd";
                resultString = $"{n1} {o} {n2} = {result} - {evenOdd}";
            }
            else if (o == "/") 
            { 


                double result = 0.0;
                if (n2 == 0)
                {
                    resultString = $"Cannot divide {n1} by zero";                   
                }
                else
                {
                    result = (double)n1 / n2;
                    resultString = $"{n1} / {n2} = {result:f2}";
                }
                    

            }
            else if (o == "%")
            {
                if (n2 == 0)
                {
                    resultString = $"Cannot divide {n1} by zero";
                }
                else
                {
                    int result = n1 % n2;
                    resultString = $"{n1} % {n2} = {result}";
                }
                
            }

            Console.WriteLine(resultString);
        }
    }
}
