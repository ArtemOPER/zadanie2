using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            uint oddNumberCount = 0;
            uint evenNumberCount = 0;

            Console.WriteLine("Введите первое число диапозона");
            int currentValue = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите последнее число диапозона");
            int limit = int.Parse(Console.ReadLine());

            while (currentValue <= limit)
            {
                if (currentValue % 2 == 0)
                {
                    evenNumberCount++;
                }
                else
                {
                    oddNumberCount++;
                }
                currentValue++;
            }

            Console.WriteLine("Колличество нечетных чисел:" + oddNumberCount);
            Console.WriteLine("Колличество четных чисел:" + evenNumberCount);
            Console.ReadLine();
        }
    }
}
