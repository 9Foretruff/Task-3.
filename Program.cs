using System;
using System.Text;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Порівняння швидкостей");
            Console.WriteLine("\nЦя програма порівнює дві швидкості, одну в кілометрах на годину, а іншу в метрах за секунду, і визначає, яка з них більша.");
            Console.WriteLine("\nАвтор: Рокітько Максим Володимирович");
            
            var v1KmPerHour = GetValidSpeed("Введіть швидкість v1 (км/год): ");
            var v2MetersPerSecond = GetValidSpeed("Введіть швидкість v2 (м/с): ");

            var v1MetersPerSecond = v1KmPerHour * 1000 / 3600;

            Console.WriteLine($"\nШвидкість v1: {v1KmPerHour} км/год {v1MetersPerSecond:0.00} м/с");
            Console.WriteLine($"Швидкість v2: {v2MetersPerSecond * 3.6:0.00} км/год {v2MetersPerSecond} м/с");

            if (v1MetersPerSecond > v2MetersPerSecond)
                Console.WriteLine($"\nШвидкість v1={v1KmPerHour} км/год більша ніж швидкість v2={v2MetersPerSecond} м/с");
            else if (v1MetersPerSecond < v2MetersPerSecond)
                Console.WriteLine($"\nШвидкість v1={v1KmPerHour} км/год менша ніж швидкість v2={v2MetersPerSecond} м/с");
            else
                Console.WriteLine("\nШвидкості v1 та v2 рівні.");

            Console.ReadLine();
        }

        private static double GetValidSpeed(string message)
        {
            double speed;
            while (true)
            {
                Console.Write(message);
                if (double.TryParse(Console.ReadLine(), out speed) && speed >= 0)
                    break;
                Console.WriteLine("Некоректні дані! Швидкість не може бути від'ємною.");
            }
            return speed;
        }
    }
}