using System;

namespace _03.areatriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa que calcula el area de un triangulo");
            double labase, altura, area;

            Console.WriteLine("Dame la base: ");
            labase = float.Parse(Console.ReadLine());
            Console.WriteLine("Dame la altura");
            altura = double.Parse(Console.ReadLine());

            area = (labase*altura)/2;

            Console.Write($"El area es {area}");
            Console.ReadLine();
        }
    }
}
