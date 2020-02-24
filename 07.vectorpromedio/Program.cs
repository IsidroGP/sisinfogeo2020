using System;

namespace _07.vectorpromedio{
    class Program{
        static void Main(string[] args){
            int[] vector ={10,20,30,40,50,60,70,80,90,100,
            10,20,30,40,50,60,70,80,90,100,
            10,20,30,40,50,60,70,80,90,100,
            10,20,30,40,50,60,70,80,90,100,
            10,20,30,40,50,60,70,80,90,100};
            
            float promedio = 0;
            Console.WriteLine("Calcular el promedio de 50 valores constantes!\n");
            Console.WriteLine("Los elementos del arreglo son:\n");
            imprimirArreglo(vector);
            promedio = prom(vector);
            Console.WriteLine($"El promedio es {promedio}");
            Console.WriteLine($"Mayores que el promedio {mayores(vector,promedio)}");
        }
        
        static int mayores(int[] arreglo, float p){
            int suma = 0;
            for (int i = 0; i < arreglo.Length; i++){
                if(arreglo[i]>p){
                    suma++;
                }
            }
            return suma;
        }

        static void imprimirArreglo(int[] arreglo){
            for (int i = 0; i < arreglo.Length; i++){
                Console.Write($"{arreglo[i]} ");
            }
            Console.WriteLine();
        }

        static float prom(int[] arreglo){
            int suma = 0;
            for (int i = 0; i < arreglo.Length; i++){
                suma = suma + arreglo[i];
            }
            return suma / arreglo.Length;
        }
    }
}
