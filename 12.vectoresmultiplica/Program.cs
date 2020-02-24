using System;

namespace _12.vectoresmultiplica{
    class Program{
        static void Main(string[] args){
            const int MAX = 10;
            double[] A = new double[MAX];
            double[] B = new double[MAX];
            double[] C = new double[MAX];
            int MAX2 = MAX-1;
            Random aleatorio = new Random();

            for (int i = 0; i < MAX; i++){
                A[i] = aleatorio.Next(1,100);
                B[i] = aleatorio.Next(1,100);
            }

            for(int i = 0; i<MAX; i++){
                C[i] = A[i]*B[MAX2];
                MAX2--;
            }

            imprimirArreglo(A);
            imprimirArreglo(B);
            imprimirArreglo(C);

            static void imprimirArreglo(double[] arreglo){
                for (int i = 0; i < arreglo.Length; i++){
                    Console.Write($"{arreglo[i]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
