using System;

namespace HomeWork13
{
    /// <summary>
    /// Домашнее задание "программа под паролем"
    /// Создайте переменную типа string, в которой хранится пароль для доступа к тайному сообщению. Пользователь вводит пароль, далее происходит проверка пароля на правильность, и если пароль неверный,
    /// то попросите его ввести пароль ещё раз. Если пароль подошёл, выведите секретное сообщение. 
    /// Если пользователь неверно ввел пароль 3 раза, программа завершается.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int loginAttempts  = 3;
            int remainigAttemps = loginAttempts;
            string password = "password123";
            string userInput;
            for (int i = 0; i < loginAttempts; i++)
            {
                Console.WriteLine($"Enter your super secret password to getr access, you have {remainigAttemps} remaining login attempts:");
                userInput = Console.ReadLine();
                remainigAttemps--;
                if (userInput == password)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Very secret message, only for your eyes!\nBitCoin will go UP very soon again! :) ");
                    break;
                }
                else
                {
                    Console.WriteLine("Incorrect passoword, this incedent will be reported, and you will not get a very secret message for this time.");
                }
            }

        }
    }
}
