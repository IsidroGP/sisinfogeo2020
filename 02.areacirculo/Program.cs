﻿using System;

namespace _02.areacirculo
{
    class Program
    {
        static void Main(string[] args)
        {
            double radio, area;

            Console.WriteLine("Programa que calcula el area de un circulo");

            Console.WriteLine("Dame la radio > ");
            radio = double.Parse(Console.ReadLine());
            
            area = Math.PI * Math.Pow(radio,2);
            
            Console.WriteLine($"El area del circulo es {area}");
            Console.ReadLine();
        }
    }
}
