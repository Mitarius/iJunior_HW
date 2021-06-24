using System;

namespace HomeWork16
///<summary>
///Найти наибольший элемент матрицы A(10,10) и записать ноль в ту ячейку, где он находится. Вывести наибольший элемент, исходную и полученную матрицу.
///Массив под измененную версию не нужен.
///</summary>
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxValue = int.MinValue;
            int[,] arrayOfNumbers = new int[10, 10];
            Random rand = new Random();

            Console.WriteLine("Initial array: \n");
            for (int i = 0; i < arrayOfNumbers.GetLength(0); i++)
            {
                for (int j = 0; j < arrayOfNumbers.GetLength(1); j++) 
                {
                    arrayOfNumbers[i, j] = rand.Next(0, 16);
                    Console.Write($"{arrayOfNumbers[i, j]},");
                }
                Console.WriteLine("");
            }

            for (int i = 0; i < arrayOfNumbers.GetLength(0); i++)
            {
                for (int j = 0; j < arrayOfNumbers.GetLength(1); j++)
                {
                    if (arrayOfNumbers[i, j] > maxValue)
                    {
                        maxValue = arrayOfNumbers[i, j];
                    }   
                }
            }

            Console.WriteLine($"\nLargeast value is {maxValue}\n");
            Console.WriteLine("Largest elements:");
            
            for (int i = 0; i < arrayOfNumbers.GetLength(0); i++)
            {
                for (int j = 0; j < arrayOfNumbers.GetLength(1); j++)
                {
                    if (arrayOfNumbers[i, j] == maxValue)
                    {
                        arrayOfNumbers[i, j] = 0;
                        Console.WriteLine($"Element [{i},{j}] ");
                    }
                }
            }

            Console.WriteLine("\nResulting array: ");
            
            for (int i = 0; i < arrayOfNumbers.GetLength(0); i++)
            {
                for (int j = 0; j < arrayOfNumbers.GetLength(1); j++)
                {
                    Console.Write($"{arrayOfNumbers[i, j]},");
                }
                Console.WriteLine("");
            }
        }
    }
}
