//task 2
using System;

namespace Example
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введіть тризначне число: ");
            int num = int.Parse(Console.ReadLine());

            if (num < 100 || num > 999)
            {
                Console.WriteLine("Це не тризначне число.");
                return;
            }

            int firstDigit = num / 100;
            int secondDigit = (num / 10) % 10;

            if (firstDigit > secondDigit)
                Console.WriteLine("Перша цифра більша.");
            else if (firstDigit < secondDigit)
                Console.WriteLine("Друга цифра більша.");
            else
                Console.WriteLine("Цифри рівні.");
        }
    }
}
