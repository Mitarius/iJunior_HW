using System;

namespace HomeWork3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Домашняя работа "Поликлиника"

            int queueLength;
            int minutesPerPerson = 10;
            int estimatedWaitingMinutes;

            Console.Write("Введите кол-во старушек: ");
            queueLength = Convert.ToInt32(Console.ReadLine());
            estimatedWaitingMinutes = queueLength * minutesPerPerson; 
            Console.WriteLine("Вы должны отстоять в очереди " + estimatedWaitingMinutes / 60 +  " часа и " + estimatedWaitingMinutes % 60 + " минут.");
        }
    }
}
