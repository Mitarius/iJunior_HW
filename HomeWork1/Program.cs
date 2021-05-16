using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //HW3 "Картинки"
            int rowSize = 3;
            int imageCount = 52;
            int fullRowCount = imageCount / rowSize;
            int remainingImages = imageCount % rowSize;

            Console.WriteLine($"Заполненных рядов: {fullRowCount}, остаток: {remainingImages}");
            Console.ReadKey();
        }
    }
}
