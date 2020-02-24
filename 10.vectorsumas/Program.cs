using System;

namespace _10.vectorsumas{
    class Program{
        static void Main(string[] args){
            const int MAX = 30;
            double cantidadneg = 0;
            double cantidadpos = 0;
            double cantidadcero = 0;
            double sumaneg = 0;
            double sumapos = 0;
            double[] A = new double[MAX];
            Random aleatorio = new Random();

            for (int i = 0; i < MAX; i++){
                A[i] = aleatorio.Next(-100,100);
            }

            for(int i = 0; i<MAX;i++){
                if(A[i]==0){
                    cantidadcero++;
                }else if(A[i]<0){
                    cantidadneg++;
                    sumaneg = sumaneg + A[i];
                }else if(A[i]>0){
                    cantidadpos++;
                    sumapos = sumapos + A[i];
                }
            }

            imprimirArreglo(A);
            Console.WriteLine($"Cantidad de Negativos: {cantidadneg}, suma de negativos: {sumaneg}");
            Console.WriteLine($"Cantidad de Positivos: {cantidadpos}, suma de positivos: {sumapos}");
            Console.WriteLine($"Cantidad de Ceras: {cantidadcero}");

            static void imprimirArreglo(double[] arreglo){
                for (int i = 0; i < arreglo.Length; i++){
                    Console.Write($"{arreglo[i]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
