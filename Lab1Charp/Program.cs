// See https://aka.ms/new-console-template for more information

using System;
namespace Example
{
    class Program
    {
        static void Main()
        {
            //task1();
            //task2();
            //task3();
            //task4();
            //task5();
            //task6();
        }
    
    public static void task1() {
            Console.Write("s= ");
            float s = float.Parse(Console.ReadLine());
            double r = Math.Sqrt(s / Math.PI);
            Console.WriteLine("r=" + r);
        }

        public static void task2() {
           
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
        public static void task3() {
            Console.Write("Введіть x: ");
            float x = float.Parse(Console.ReadLine());

            Console.Write("Введіть y: ");
            float y = float.Parse(Console.ReadLine());

            if (x <= 0 && y >= 0 && y <= x)
                Console.WriteLine("Так"); 
            else if (x <= 0 && y == x)
                Console.WriteLine("На межі"); 
            else
                Console.WriteLine("Ні"); 
        }
        public static void task4()
        {
            string[] animals = {
            "Мавпа", "Півень", "Собака", "Свиня", "Щур",
            "Бик", "Тигр", "Кролик", "Дракон", "Змія",
            "Кінь", "Вівця"
        };

            Console.Write("Введіть рік: ");
            if (int.TryParse(Console.ReadLine(), out int year))
            {
                int index = (year - 4) % 12;
                Console.WriteLine($"Рік {year} — це рік {animals[index]}.");
            }
            else
            {
                Console.WriteLine("Неправильний формат року.");
            }
        }
        public static void task5() {
           
                Console.Write("Введіть перше число: ");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введіть друге число: ");
                double b = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine($"Квадрат різниці: {SquareOfDifference(a, b)}");
            }

            static double SquareOfDifference(double x, double y)
            {
                return Math.Pow(x - y, 2);
            }
        public static void task6() { 
            // Введення значень a та b
            Console.Write("Введіть значення a: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введіть значення b: ");
            double b = Convert.ToDouble(Console.ReadLine());

            // Обчислення значення виразу
            double denominator1 = a * a + a * b + 1;
            double denominator2 = b * b + a * b + 1;

            // Перевірка на ділення на нуль
            if (denominator1 == 0 || denominator2 == 0)
            {
                Console.WriteLine("Ділення на нуль неможливе.");
            }
            else
            {
                double result = (1 / denominator1) - (1 / denominator2);
                Console.WriteLine("Значення виразу: " + result);
            }
        }
    }

} 
