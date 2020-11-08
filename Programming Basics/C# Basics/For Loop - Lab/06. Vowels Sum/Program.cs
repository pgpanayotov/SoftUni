using System;

namespace _06._Vowels_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int n = 0;

            for (int i = 0; i < input.Length; i++)
            {
                switch (input[i])
                {
                    case 'a':
                        n++;
                        break;
                    case 'e':
                        n += 2;
                        break;
                    case 'i':
                        n += 3;
                        break;
                    case 'o':
                        n += 4;
                        break;
                    case 'u':
                        n += 5;
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine(n);
        }
    }
}
