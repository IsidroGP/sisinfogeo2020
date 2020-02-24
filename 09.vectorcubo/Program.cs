using System;

namespace _09.vectorcubo
{
    class Program
    {
        static void Main(string[] args){
            const int MAX = 20;

            double[] A = new double[MAX];
            double[] B = new double[MAX];


            Random aleatorio = new Random();

            // Generar numeros aleatorios
            for (int i = 0; i < MAX; i++){
                A[i] = aleatorio.Next(1,100);
                B[i] = Math.Pow(A[i],3);
            }

            Console.WriteLine("Elevar al cubo un vector y almacenarlo en otro");

            imprimirArreglo(A);
            imprimirArreglo(B);

        }

        static void imprimirArreglo(double[] arreglo){
            for (int i = 0; i < arreglo.Length; i++){
                Console.Write($"{arreglo[i]} ");
            }
            Console.WriteLine();
        }
    }
}
