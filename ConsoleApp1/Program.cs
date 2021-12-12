using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("стоимости поездки на такси в манатах, в зависимости от расстояния");
            Console.Write("Введите расстояния:");
          
            double usd = 1.7;
            double rate = 1.5;
            double distance = Convert.ToDouble(Console.ReadLine());

            double price  = distance * rate * usd;

            Console.WriteLine($"цена за поездку: {price} манат");
            Console.ReadKey();



       
        }
    }
}
