﻿using System;
using System.Threading;

namespace HomeWork10
{
    /// <summary>
    /// Домашнее задание "консольное меню"
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int screenFlashCount = 10;
            int screenFlashPauseTimeMs = 100;
            int actionPauseMs = 1000;
            int commentTargetShitCount = 11;
            int commentTargetActualShitCount = commentTargetShitCount;
            int commentShitDispersion = 10;
            string userCommand = "";
            string newPassword = "";
            bool pentagonIsHacked = false;
            int loginAttempts = 3;
            int remainigAttemps = loginAttempts;
            string userInput;
            Random rand = new Random();


            while (userCommand != "Exit")
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\n\n*********************************************************");
                Console.WriteLine("*****************Хакерское меню**************************");
                Console.WriteLine("*********************************************************");
                Console.WriteLine("Выбери команду и смотри не запались");
                Console.WriteLine("1: Поменять рут паролиь на глвном сервере \"петнагона\"");
                Console.WriteLine("2: Узнать кто убил Кеннеди ");
                Console.WriteLine("3: Насрать в коментах");
                Console.WriteLine("4: Удалить логи");
                Console.WriteLine("Exit: Выход из системы");

                userCommand = Console.ReadLine();

                switch (userCommand)
                {
                    case "1":
                        {
                            Console.Write("Введи новый дурацкий пароль:");
                            newPassword = Console.ReadLine();
                            Console.WriteLine("Подключаюсь к серверу...");
                            Thread.Sleep(actionPauseMs);
      
                            for (int i = 0; i < screenFlashCount; i++) {
                                Console.BackgroundColor = ConsoleColor.Red;
                                Console.Clear();
                                Thread.Sleep(screenFlashPauseTimeMs);
                                Console.BackgroundColor = ConsoleColor.Black;
                                Console.Clear();
                            }
                            
                            Console.WriteLine("Соединение установлено...");
                            Thread.Sleep(actionPauseMs);
                            Console.WriteLine("Меняю пароль...");
                            Thread.Sleep(actionPauseMs);
                            Console.WriteLine($"Новый пароль: {newPassword}");
                            pentagonIsHacked = true;

                        }                
                        break;

                    case "2":
                        {
                            Console.WriteLine("Подключаюсь к серверу ФБР...");
                            Thread.Sleep(actionPauseMs);

                            for (int i = 0; i < loginAttempts; i++)
                            {
                                Console.WriteLine($"Enter your super secret password to getr access, you have {remainigAttemps} remaining login attempts:");
                                userInput = Console.ReadLine();
                                remainigAttemps--;
                                if (userInput == newPassword && pentagonIsHacked)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Aliens from Hangar 18 took JFK to Nabiru");
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Incorrect passoword, this incedent will be reported, and you will not get a very secret message for this time.");
                                }
                            }
                        }
                        break;

                    case "3":
                        {
                            Console.WriteLine("Подсоединяем бота...");
                            Thread.Sleep(actionPauseMs);
                            Console.WriteLine("БОЛЬШНЕ БОТОВ...");
                            Thread.Sleep(actionPauseMs);
                            Console.WriteLine("Рандомизируем говно...");
                            Thread.Sleep(actionPauseMs);
                            commentTargetActualShitCount += rand.Next( -commentShitDispersion, commentShitDispersion);
                            for (int i = 0; i < commentTargetActualShitCount; i++) 
                            {
                                Console.WriteLine("This is boolshit!!!!");
                            }
                            commentTargetActualShitCount = commentTargetShitCount;
                        }
                        break;

                    case "4":
                        {
                            Console.WriteLine("Заметаем следы:");
                            Thread.Sleep(actionPauseMs);
                            Console.WriteLine("Подключаюсь к серверу...");
                            Thread.Sleep(actionPauseMs);

                            for (int i = 0; i < screenFlashCount; i++)
                            {
                                Console.BackgroundColor = ConsoleColor.Green;
                                Console.Clear();
                                Thread.Sleep(screenFlashPauseTimeMs);
                                Console.BackgroundColor = ConsoleColor.Black;
                                Console.Clear();
                            }

                            Console.WriteLine("Чисто!");
                            Thread.Sleep(actionPauseMs);
                            Console.WriteLine("Соединение прервано");
                        }
                        break;

                    case "Exit":
                        break;

                    default:
                        Console.WriteLine("Введите правильную команду \"Exit\" для выхода.");
                        break;
                }
            }
        }
    }
}
