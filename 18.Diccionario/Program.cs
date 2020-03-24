using System;
using System.Collections.Generic;

namespace _18.Diccionario{
    class Program{
        static void Main(string[] args){

            //Definimos el diccionario y reservamos espacio en memoria para el
            //Dictionary<string, string> oceano = new Dictionary<string, string>();

            SortedDictionary<string, string> oceano = new SortedDictionary<string, string>();

            //Agregar entradas al diccionario
            oceano.Add("txt","Archivo de texto");
            oceano.Add("jpg","Archivo de imagen");
            oceano.Add("mp3","Archivo de sonido");
            oceano.Add("htm","Archivo HTML");
            oceano.Add("exe","Archivo ejecutable de windows");
            oceano.Add("lll","Archivo de tipo desconocido");

            //Acceder a un elemento en base a la llave
            Console.WriteLine(oceano["htm"]);

            //Verifiar si una llave existe, si no agregarla
            if(oceano.ContainsKey("elf")){
                Console.WriteLine("La llava ya existe");
            }else{
                oceano.Add("elf","Archivo ejecutable de linux");
            }

            //Borrar una entrada si la llave existe
            if(oceano.ContainsKey("lll")){
                oceano.Remove("lll");
            }

            //Recorrer el diccionario e Imprimir la llave y su valor
            foreach(KeyValuePair<String,String> val in oceano){
                Console.WriteLine($"{val.Key} - {val.Value}");
            }

            //Imprimir solo las llaves del diccionario
            foreach(string llave in oceano.Keys){
                Console.WriteLine(llave);
            }

            //Imprimir solo los valores del diccionario
            foreach(string valor in oceano.Values){
                Console.WriteLine(valor);
            }

            //Borrar todas las entradas al diccionaio
            oceano.Clear();
            
        }
    }
}
