using System;

namespace HomeWork11
{
    /// <summary>
    /// Домашнее задание "последовательность"
    /// Нужно написать программу (используя циклы, обязательно пояснить выбор вашего цикла), чтобы она выводила следующую последовательность 7 14 21 28 35 42 49 56 63 70 77 84 91 98
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int sequenceBaseNumber = 7;
            int numberInSequence;
            for (int i = 1; i <=14; i++  )
            {
                numberInSequence = sequenceBaseNumber * i;
                Console.Write(numberInSequence + " ");
            }
            
        }
    }
}
