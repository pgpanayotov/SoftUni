using System;

namespace _01._Old_Books
{
    class Program
    {
        static void Main(string[] args)
        {
            var counter = 0;
            var isFind = false;

            var book = Console.ReadLine();

            var currentBook = Console.ReadLine();
            while (currentBook != "No More Books")
            {
                if (book == currentBook)
                {
                    Console.WriteLine($"You checked {counter} books and found it.");
                    isFind = true;
                    break;
                }
                counter++;
                currentBook = Console.ReadLine();
            }
            if (!isFind)
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {counter} books.");
            }
        }
    }
}
