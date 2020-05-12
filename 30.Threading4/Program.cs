using System;
using System.Threading;

namespace _30.Threading4{
    class Program{
        static void Main(string[] args){
            Console.WriteLine("Hilo principal iniciado");

            Thread t1 = new Thread(Metodo1) {Name = "Cliente1"};
            Thread t2 = new Thread(Metodo2) {Name = "Cliente2"};
            Thread t3 = new Thread(Metodo3) {Name = "Cliente3"};

            t1.Start();
            t2.Start();
            t3.Start();
            Console.WriteLine("Thread principal Terminado");
        }

        static void Metodo1(){
            Console.WriteLine("Metodo 1 Iniciado usanndo " + Thread.CurrentThread.Name);
            for (int i = 1; i <= 5; i++){
                Console.WriteLine("Metodo1 :" + i);    
            }
            Console.WriteLine("Metodo Terminado usando " + Thread.CurrentThread.Name);
        }

         static void Metodo2(){
            Console.WriteLine("Metodo 2 Iniciado usanndo " + Thread.CurrentThread.Name);
            for (int i = 1; i <= 5; i++){
                Console.WriteLine("Metodo2 :" + i);   
                if(i == 3){
                    Console.WriteLine("Iniciando Operacion sobre la base de datos");
                    Thread.Sleep(10000);
                    Console.WriteLine("Operacion sobre la base de dato terminada");
                } 
            }
            Console.WriteLine("Metodo Terminado usando " + Thread.CurrentThread.Name);
        }

         static void Metodo3(){
            Console.WriteLine("Metodo 3 Iniciado usanndo " + Thread.CurrentThread.Name);
            for (int i = 1; i <= 5; i++){
                Console.WriteLine("Metodo3 :" + i);    
            }
            Console.WriteLine("Metodo Terminado usando " + Thread.CurrentThread.Name);
        }
    }
}
