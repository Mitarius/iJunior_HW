using System;

namespace HomeWork9
{   /// <summary>
    /// Домашняя работа "конвертер валют"
    /// У пользователя есть баланс в каждой из представленных валют.Он может попросить сконвертировать часть баланса с одной валюты в другую.
    /// Тогда у него с баланса одной валюты снимется X и зачислится на баланс другой Y.Курс конвертации должен быть просто прописан в программе.
    ///Программа должна завершиться тогда, когда это решит пользователь.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            string userCommand = "";
            float currentUSDAmount = 100f;
            float currentEURAmount = 100f;
            float currentRUBAmount = 1000f;
            float ratioUSDEUR = 0.82f;
            float ratioUSDRUB = 73f;
            float ratioEURRUB = 89;
            float convertingAmount;
            
            Console.WriteLine("Конвертер валют.");

            while (userCommand != "Exit")
            {
                Console.WriteLine($"У вас есть {currentUSDAmount} долларов, {currentEURAmount} евро и {currentRUBAmount} рублей.");
                Console.WriteLine("1 обменять рубли на доллары ");
                Console.WriteLine("2 обменять рубли на евро ");
                Console.WriteLine("3 обменять евро на доллары ");
                Console.WriteLine("4 обменять евро на рубли ");
                Console.WriteLine("5 обменять доллары на евро ");
                Console.WriteLine("6 обменять доллары на рубли ");
                
                userCommand = Console.ReadLine();
                                
                switch (userCommand) 
                {
                    case "1":
                        Console.WriteLine("Обмен рублей на доллары, введите сумму в рублях");
                        convertingAmount = Convert.ToSingle(Console.ReadLine());
                        if (currentRUBAmount >= convertingAmount)
                        {
                            currentRUBAmount -= convertingAmount;
                            currentUSDAmount += convertingAmount / ratioUSDRUB;
                        }
                        else
                        {
                            Console.WriteLine("Недопустимая сумма");
                        }
                        break;

                    case "2":
                        Console.WriteLine("Обмен рублей на евро, введите сумму в рублях");
                        convertingAmount = Convert.ToSingle(Console.ReadLine());
                        if (currentRUBAmount >= convertingAmount)
                        {
                            currentRUBAmount -= convertingAmount;
                            currentEURAmount += convertingAmount / ratioEURRUB;
                        }
                        else
                        {
                            Console.WriteLine("Недопустимая сумма");
                        }
                        break;

                    case "3":
                        Console.WriteLine("Обмен евро на доллары, введите сумму в евро");
                        convertingAmount = Convert.ToSingle(Console.ReadLine());
                        if (currentEURAmount >= convertingAmount)
                        {
                            currentEURAmount -= convertingAmount;
                            currentUSDAmount += convertingAmount / ratioUSDEUR;
                        }
                        else
                        {
                            Console.WriteLine("Недопустимая сумма");
                        }
                        break;

                    case "4":
                        Console.WriteLine("Обмен евро на рубли, введите сумму в евро");
                        convertingAmount = Convert.ToSingle(Console.ReadLine());
                        if (currentEURAmount >= convertingAmount)
                        {
                            currentEURAmount -= convertingAmount;
                            currentRUBAmount += convertingAmount * ratioEURRUB;
                        }
                        else
                        {
                            Console.WriteLine("Недопустимая сумма");
                        }
                        break;

                    case "5":
                        Console.WriteLine("Обмен долларов на евро, введите сумму в долларах");
                        convertingAmount = Convert.ToSingle(Console.ReadLine());
                        if (currentUSDAmount >= convertingAmount)
                        {
                            currentUSDAmount -= convertingAmount;
                            currentEURAmount += convertingAmount * ratioUSDEUR;
                        }
                        else
                        {
                            Console.WriteLine("Недопустимая сумма");
                        }
                        break;

                    case "6":
                        Console.WriteLine("Обмен доллары на рубли, введите сумму в долларах");
                        convertingAmount = Convert.ToSingle(Console.ReadLine());
                        if (currentUSDAmount >= convertingAmount)
                        {
                            currentUSDAmount -= convertingAmount;
                            currentRUBAmount += convertingAmount * ratioUSDRUB;
                        }
                        else
                        {
                            Console.WriteLine("Недопустимая сумма");
                        }
                        break;


                    case "Exit":
                        break;

                    default:
                        Console.WriteLine("Введите правильную команду конвертации или \"Exit\" для выхода. Для продолжения нежмите Enter");
                        break;
                }
            }
            Console.WriteLine("");
        }
    }
}
