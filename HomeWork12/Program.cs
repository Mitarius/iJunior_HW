using System;

namespace HomeWork12
{
    /// <summary>
    /// Домашняя работа "вывод имени"
    /// Вывести имя в прямоугольник из символа, который введет сам пользователь.
    /// Вы запрашиваете имя, после запрашиваете символ, а после отрисовываете в консоль его имя в прямоугольнике из его символов.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            string userName;
            string decoratorSymbol;

            Console.Write("Enter your name:");
            userName = Console.ReadLine();
            Console.WriteLine("Please enter decorator symbol");
            decoratorSymbol = Console.ReadLine();

            for (int i = 0; i <= userName.Length + 1; i++) 
            {
                Console.Write(decoratorSymbol);
            }
            Console.WriteLine("\n"+decoratorSymbol + userName + decoratorSymbol);

            for (int i = 0; i <= userName.Length + 1; i++)
            {
                Console.Write(decoratorSymbol);
            }

        }
    }
}
