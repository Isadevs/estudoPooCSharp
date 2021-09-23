using System;

namespace _002EstruturaSequencial
{
    class Program
    {
        static void Main(string[] args)
        {
            double area, raio;
            double pi = 3.14159;

            raio = double.Parse(Console.ReadLine());

            area = pi * Math.Pow(raio, 2);

            Console.WriteLine($"A={area.ToString("N4")}");
        }
    }
}
