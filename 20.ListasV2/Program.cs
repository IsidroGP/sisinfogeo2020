using System;
using System.Collections.Generic;

namespace _20.ListasV2{
    class Program{
        static void Main(string[] args){

            // Crear una lista de tipo pieza
            List<Pieza> mp = new List<Pieza>();

            // Agregar elementos a la lista
            mp.Add(new Pieza(1234,"Tuerca de rosca interior"));
            mp.Add(new Pieza(5678,"Tornillo cabeza grande"));
            mp.Add(new Pieza(9345,"Bateria 12v"));

            // Agregar un rango de elementos
            var proveedor = new List<Pieza>(){
                new Pieza(8888,"Tornillo de cabeza pequeña"),
                new Pieza(9999,"Cable para pasar corriente"),
                new Pieza(6666,"Triendente del diamentro")
            };

            mp.AddRange(proveedor);

            mp.ForEach(p=>Console.WriteLine(p.ToString()));

            mp.RemoveAt(mp.Count-1);

            Console.WriteLine("Insertar un elemento en la posición 2");
            mp.Insert(1,new Pieza(7825,"Piececita nueva"));
            mp.ForEach(p=>Console.WriteLine(p.ToString()));

            Console.WriteLine("Pieza que contienen tornillo");
            var t = mp.FindAll(x=>x.Nombre.Contains("Tornillo"));
            t.ForEach(p=>Console.WriteLine(p.ToString()));

            Console.WriteLine("Piezas con id > 5000");
            var t1 = mp.FindAll(x=>x.Id>5000);
            t1.ForEach(p=>Console.WriteLine(p.ToString()));
        }
    }
}
