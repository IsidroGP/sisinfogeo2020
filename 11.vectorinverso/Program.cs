using System;

namespace _11.vectorinverso{
    class Program{
        static void Main(string[] args){
            const int MAX = 15;
            double[] A = new double[MAX];
            double[] B = new double[MAX];
            Random aleatorio = new Random();
            int c = 0;

            for (int i = 0; i < MAX; i++){
                A[i] = aleatorio.Next(-100,100);
            }

            for(int i = MAX-1; i>=0; i--){
                B[c] = A[i];
                c++;
            }

            imprimirArreglo(A);
            imprimirArreglo(B);

            static void imprimirArreglo(double[] arreglo){
                for (int i = 0; i < arreglo.Length; i++){
                    Console.Write($"{arreglo[i]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
