using System;

namespace HomeWork08
{   /// <summary>
    /// Домашнее задание "Контроль выхода"
    /// Написать программу, которая будет выполняться до тех пор, пока не будет введено слово exit.
    ///Помните, в цикле должно быть условие, которое отвечает за то, когда цикл должен завершиться.
    ///Это нужно, чтобы любой разработчик взглянув на ваш код, понял четкие границы вашего цикла.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            string exitCommand = "Exit";
            string userCommand = "";
            while (userCommand != exitCommand)
            {
                Console.Write($"Please, enter your command, or {exitCommand} to quit: ");
                userCommand = Console.ReadLine();
                Console.WriteLine($"You have entered: {userCommand}");
            }
            
        }
    }
}
