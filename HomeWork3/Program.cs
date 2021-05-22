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
            int estimatedTotalWaitingMinutes;
            int estimatedWaitingHours;
            int estimatedWaitingMinutes;

            Console.Write("Введите кол-во старушек: ");
            queueLength = Convert.ToInt32(Console.ReadLine());
            estimatedTotalWaitingMinutes = queueLength * minutesPerPerson;
            estimatedWaitingHours = estimatedTotalWaitingMinutes / 60;
            estimatedWaitingMinutes = estimatedTotalWaitingMinutes % 60;
            Console.WriteLine("Вы должны отстоять в очереди " + estimatedWaitingHours +  " часа и " + estimatedWaitingMinutes + " минут.");
        }
    }
}
