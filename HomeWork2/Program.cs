using System;

namespace HomeWork2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Домашняя работа "Магазин" (без проверки достаточности золота)

            int goldCount;
            int crystalPrice = 10;
            int crystalCount = 0;
            int purchaseAmount;

            Console.Write("Сколкьо у вас с собой золота: ");
            goldCount = Convert.ToInt32(Console.ReadLine());
            Console.Write("Сколько кристаллов по " + crystalPrice + " золота вы хотите купить: ");
            purchaseAmount =  Convert.ToInt32(Console.ReadLine());
            crystalCount += purchaseAmount;
            goldCount -= purchaseAmount * crystalPrice;
            Console.Write("У вас " + crystalCount + " кристаллов и " + goldCount + " золота");
        }
    }
}
