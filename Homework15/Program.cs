using System;

namespace Homework15
{/// <summary>
///  Домашняя работа "Работа с колкрутными элемгетнгми массива"
 /// Дан двумерный массив.
 /// Вычислить сумму второй строки и произведение первого столбца.Вывести исходную матрицу и результаты вычислений.
/// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arrayOfNumbers = new int[5, 4] { { 1, 2, 3, 4 }, { 4, 5, 6, 7 }, { 7, 8, 9, 10 }, { 10, 11, 12, 13 }, { 13,14,15,16} };
            int sumOfRow = 0;
            int productOfColumn = 0;
            int rowToSum = 1;
            int columnToMultiply = 0;

            for (int i = 0; i < arrayOfNumbers.GetLength(1); i++)
            {
                sumOfRow += arrayOfNumbers[rowToSum, i];
            }

            for (int i = 0; i < arrayOfNumbers.GetLength(0); i++)
            {
                productOfColumn += arrayOfNumbers[i,columnToMultiply];
            }

            Console.WriteLine($"Sum of row {rowToSum +1}: {sumOfRow}, product of column {columnToMultiply +1} is: {productOfColumn} ");
        }
    }
}
