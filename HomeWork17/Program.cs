using System;

namespace HomeWork17
{
    /// <summary>
    /// Дан одномерный массив целых чисел из 30 элементов.
    /// Найдите все локальные максимумы и вывести их. (Элемент является локальным максимумом, если он не имеет соседей, больших, чем он сам)
    ///Крайние элементы являются локальными максимумами если не имеют соседа большего, чем они сами
    ///Программа должна работать с массивом любого размера.
    ///Массив всех локальных максимумов не нужен.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[30];
            Random rand = new Random();

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rand.Next(0, 16);
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                if (i == 0)
                {
                    if (numbers[i + 1] < numbers[i])
                    {
                        Console.WriteLine($"Element {i} is a local maximum and it is {numbers[i]}");
                    }
                } else if (i == numbers.Length-1)
                {
                    if (numbers[i - 1] < numbers[i])
                    {
                        Console.WriteLine($"Element {i} is a local maximum and it is {numbers[i]}");
                    }
                } else if (numbers[i-1] < numbers[i] & numbers[i+1] < numbers[i]) 
                {
                    Console.WriteLine($"Element {i} is a local maximum and it is {numbers[i]}");
                }

            }
        }

    }
}
