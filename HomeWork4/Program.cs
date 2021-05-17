using System;

namespace HomeWork4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Домашняя работе "работа со строками"

            string userName;
            string userZodiakSign;
            string userWrkingPlace;
            string userAddress;
            int userAge;

            Console.Write("Введите имя пользователя: ");
            userName = Console.ReadLine();

            Console.Write("Введите знак зодиака пользователя: ");
            userZodiakSign = Console.ReadLine();

            Console.Write("Введите место работы пользователя: ");
            userWrkingPlace = Console.ReadLine();

            Console.Write("Введите адрес пользователя: ");
            userAddress = Console.ReadLine();

            Console.Write("Введите возраст пользователя: ");
            userAge = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Вас зовут {userName}, вам {userAge}, вы {userZodiakSign} по гороскопу, работаете в {userWrkingPlace} и проживаете по адресу: {userAddress}");
        }
    }
}
