using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("стоимости поездки на такси в манатах, в зависимости от расстояния");
            Console.Write("Введите расстояния:");
            // 1 км стоит 1,5$
            // f - доллар равен курсу по ЦБ (на сегодняшний день 1$ - 1,7 манат)

            var f = 2.55;
            double x = Convert.ToDouble(Console.ReadLine());

            double rasstoyaniye  = x * f;

            Console.WriteLine($"расстоляние: {rasstoyaniye} манат");
            Console.ReadKey();



       
        }
    }
}
