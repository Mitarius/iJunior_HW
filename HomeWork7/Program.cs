using System;

namespace HomeWork7
{
    /// <summary>
    /// Домашнее задание "Освоение циклов"
    /// При помощи циклов вы можете повторять один и тот же код множество раз.
    /// Напишите простейшую программу, которая выводит указанное(установленное) пользователем сообщение заданное количество раз.
    /// </summary>
    
    class Program
    {
        static void Main(string[] args)
        {
            string  message;
            int     repeatCount;

            Console.WriteLine("Введите сообщение:");
            message = Console.ReadLine();
            Console.WriteLine("Введите число повторений:");
            repeatCount = Convert.ToInt32(Console.ReadLine());

            while (repeatCount > 0)
            {
                Console.WriteLine(message);
                repeatCount--;
            }
        }
    }
}
