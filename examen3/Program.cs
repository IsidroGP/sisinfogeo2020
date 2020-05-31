using System;
using System.Collections.Generic;

namespace examen3{
    class Program{
        static void Main(string[] args){
            Menu();
            string menu = Console.ReadLine();
            switch (menu){
                case "1":
                    cliente cliente1  = new cliente();
                    cliente1.id = 1;
                    cliente1.nombre = "Juan";
                    Console.WriteLine(cliente1.ToString());
                    break;
                case "2":
                   string Basura = DiasBasura(Dias.Lunes);
                   Console.WriteLine(Basura);
                   break;
                case "3":
                    string Color = Colores("Rojo","Azul");
                    Console.WriteLine(Color);
                    break;
                case "4":
                    Point po = new Point(5,-4);
                    Console.WriteLine(GetQuadrant(po));
                    break;
                case "5":
                    IEnumerable<string> lista = new string[] {"H","o","l","a"};
                    EscribirEnTXT(lista);
                    EscribirEnTXT2(lista);
                    break;
                case "6":
                    Console.WriteLine(ejemplo());
                    Console.WriteLine(ejemplo2());
                    break;
                case "7":
                    var palabras = new string[]{
                        "azul",
                        "rojo",
                        "verde",
                        "mexico",
                        "argentina",
                        "brasil",
                    };
                    Console.WriteLine($"La primer PALABRA {palabras[^6]}");
                    Console.WriteLine($"La ultima PALABRA {palabras[^1]}");
                    var colores = palabras[^6..^4];
                    var paises = palabras[3..5];
                    break;
                case "8":
                    List<int> numeros = null; //se declara en null
                    int? a = null; //se declara en null con ?
                    int? b = null;
                    numeros ??= new List<int>(); //con ??= se asigna un valor o se inicializa algo declarado en null
                    numeros.Add(a ??= 20);
                    numeros.Add(b ??= 17);
                    Console.WriteLine(string.Join(" ", numeros));  // output: 17 17
                    Console.WriteLine(a);
                    Console.WriteLine(b);
                    break;
                default:
                    Console.WriteLine("No se selecciono opcion");
                    break;
            }
        }

        static void Menu(){
            Console.WriteLine("Caracteristicas nuevas en C# V8.0");
            Console.WriteLine("1.- Miembros de solo lectura");
            Console.WriteLine("2.- Expresiones switch");
            Console.WriteLine("3.- Patrones de tupla");
            Console.WriteLine("4.- Patrones posicionales");
            Console.WriteLine("5.- Declaraciones Using");
            Console.WriteLine("6.- Funciones locales estáticas");
            Console.WriteLine("7.- Indices y rangos");
            Console.WriteLine("8.- Asignación de uso combinado de NULL");
        }

        public struct cliente{
            public int id {get; set;}
            public string nombre {get; set;}

            public readonly override string ToString(){
                return $"ID:{id}, Nombre: {nombre}";
            }
        }

        public enum Dias{
            Lunes,Martes,Miercoles,Jueves,Viernes,Sabado,Domingo
        }

        public static string DiasBasura(Dias diasrecoleccion) => diasrecoleccion switch
        {
            Dias.Lunes => "Pasa la basura",
            Dias.Martes => "No pasa la basura",
            Dias.Miercoles => "No pasa la basura",
            Dias.Jueves => "Pasa la basura",
            Dias.Viernes => "No pasa la basura",
            Dias.Sabado => "No pasa la basura",
            Dias.Domingo => "Pasa la basura",
            _ => "Pos un error",
        };

        public static string Colores(string color, string color2) =>
            (color, color2) switch{
                ("Rojo", "Azul") => "Morado",
                ("Rojo", "Verde") => "Amarillo",
                ("Azul", "Verde") => "Azul cielo",
                _ => "Blanco",
            };
        

        public class Point{
            public int X { get; }
            public int Y { get; }

            public Point(int x, int y) => (X, Y) = (x, y);

            public void Deconstruct(out int x, out int y) =>
                (x, y) = (X, Y);
        }

        public enum Quadrant{
            Unknown,Origin,One,Two,Three,Four,OnBorder
        }

        static Quadrant GetQuadrant(Point point) => point switch{
            (0, 0) => Quadrant.Origin,
            var (x, y) when x > 0 && y > 0 => Quadrant.One,
            var (x, y) when x < 0 && y > 0 => Quadrant.Two,
            var (x, y) when x < 0 && y < 0 => Quadrant.Three,
            var (x, y) when x > 0 && y < 0 => Quadrant.Four,
            var (_, _) => Quadrant.OnBorder,
            _ => Quadrant.Unknown
        };


        static int EscribirEnTXT(IEnumerable<string> lines){
            using var file = new System.IO.StreamWriter("hola.txt");
            int skippedLines = 0;
            foreach (string line in lines){
                if (!line.Contains("Second")){
                    file.WriteLine(line);
                }else{
                    skippedLines++;
                }
            }
            return skippedLines;
            //El documento se cierra aquí
        }

        static int EscribirEnTXT2(IEnumerable<string> lines) {
            int skippedLines = 0;
            using (var file = new System.IO.StreamWriter("hola2.txt")){
                foreach (string line in lines){
                    if (!line.Contains("Second")){
                        file.WriteLine(line);
                    }else{
                        skippedLines++;
                    }
                }
            } // El documento se cierra aqui
            return skippedLines;
        }

        public static int ejemplo(){
            int y;
            LocalFuntion();
            return y;
            // LocalFunction no puede ser static por que accede directamente a la variable
            void LocalFuntion() => y = 0;
        }

        public static int ejemplo2(){
            int y = 5;
            int x = 7 ;
            return Add(x,y);
            //Add si puede ser static por que no accede directamente a la variable
            static int Add(int left, int right) => left + right;
        }

        
    }
}
