using System;

namespace _06.tablas
{
    class Program
    {
        static int Main(string[] args){
            int opcion;
            do{
                Menu();
                Console.WriteLine("Escoja una opciòn");
                opcion = int.Parse(Console.ReadLine());
                if(opcion==1){
                    Console.WriteLine("Escribe en el siguiente orden [Numero de la tabla] [Numero que empiza] [Numero que termina]");
                    Console.WriteLine("Separados por espaciós y sin corchetes");
                    String tablas = Console.ReadLine();
                    for (int numeroMultiplicando = int.Parse(tablas.Split(" ")[1]); numeroMultiplicando<=int.Parse(tablas.Split(" ")[2]); numeroMultiplicando++){
                        int numeroMultiplicador = int.Parse(tablas.Split(" ")[0]);
                        int resultado = numeroMultiplicador * numeroMultiplicando;
                        Console.WriteLine($" {numeroMultiplicador} * {numeroMultiplicando} = {resultado}");
                    }
                }else if(opcion==2){
                    Console.WriteLine("Escribe en el siguiente orden [Hasta que tabla] [Numero que empiza] [Numero que termina]");
                    Console.WriteLine("Separados por espaciós y sin corchetes");
                    String tablas = Console.ReadLine();
                    for (int numeroMultiplicando = 1; numeroMultiplicando <= int.Parse(tablas.Split(" ")[0]); numeroMultiplicando++){
                        for (int tabla = int.Parse(tablas.Split(" ")[1]); tabla<=int.Parse(tablas.Split(" ")[2]); tabla++){
                            int numeroMultiplicador = numeroMultiplicando;
                            int resultado = numeroMultiplicador * tabla;
                            Console.WriteLine($" {numeroMultiplicador} * {tabla} = {resultado}");
                        }
                        Console.WriteLine("\n");
                    }
                }else{
                    return 1;
                }
            }while (opcion!=3);
            return 0;
        }
        static void Menu(){
            Console.WriteLine("1. Imprimir una tabla de multiplicar específica hasta cierto número (ej. la tabla del 5 , del 1 al 10)");
            Console.WriteLine("2. Imprimir las tablas deseadas hasta el número deseado. (ej. hasta la table del 5, del 1 al 11)");
            Console.WriteLine("3. Salir");
        }
    }
}
