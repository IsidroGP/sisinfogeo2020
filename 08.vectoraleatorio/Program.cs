using System;

namespace _08.vectoraleatorio{
    class Program{
        static void Main(string[] args){
            const int MAX = 15;

            int[] A = new int[MAX];
            int[] B = new int[MAX];
            int[] C = new int[MAX];

            Random aleatorio = new Random();

            // Generar numeros aleatorios
            for (int i = 0; i < MAX; i++){
                A[i] = aleatorio.Next(1,100);
                B[i] = aleatorio.Next(1,100);
                C[i] = A[i] + B[i];
            }

            imprimirArreglo(A);
            imprimirArreglo(B);
            imprimirArreglo(C);

            Console.WriteLine("Suma de 2 vectores aleatorios con 15 elementos");
        }

        static void imprimirArreglo(int[] arreglo){
            for (int i = 0; i < arreglo.Length; i++){
                Console.Write($"{arreglo[i]} ");
            }
            Console.WriteLine();
        }

    }
}
