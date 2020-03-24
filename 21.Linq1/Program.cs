using System;
using System.Linq;
using System.Collections.Generic;

namespace _21.Linq1{
    class Program{
        static void Main(string[] args){

            //datos
            int[] numeros = new int []{
                10,20,30,40,50,60,70,80,90,100,
                -10,-20,0,1000,2000,3000,4000,5000,
                10,20,30,40,50,60,70,80,90,101,
                -10,-20,0,1000,2000,3000,4000,5000
            };

            Console.WriteLine("Consula 1");
            //Consulta 1, pares
            var consulta =
            from num in numeros
            where num%2==0
            select num;

            //Ejectuar consulta
            foreach(var num in consulta)
                Console.Write($"{num} ");
            
            Console.WriteLine("\nConsulta 2");
            //Consulta 2, numeros entre 10 y 200, en un arreglo regresa un int[]
            var consulta2 = (from num in numeros where (num>=10 && num<=200) select num).ToArray();

            for(int i = 0; i<consulta2.Count();i++){
                Console.Write($"{consulta2[i]} ");
            }

            Console.WriteLine("\nConsulta 3");
            //Consulta 3, negativos, en una lista (regresa List<int>)
            var consulta3 = 
            (from num in numeros
            where num < 0
            select num).ToList();

            Console.WriteLine("\nNumeros negativos:\n");
            consulta3.ForEach(num=>Console.WriteLine(num));
        }
    }
}
