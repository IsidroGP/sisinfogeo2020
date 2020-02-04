using System;

namespace _05.pizzas{
    class Program{
        static int Main(string[] args){
            if(args.Length==0){
                Menu();
                return 1;
            }
            char tam = char.Parse(args[0]);
            string[] ings = args[1].Split("+");
            char cub = char.Parse(args[2]);
            char don = char.Parse(args[3]);
            string tamaño = "", ingredientes="",cubierta="",donde="";
            if(tam == 'P'){
                tamaño = "Pequeña";
            }else if (tam == 'M'){
                tamaño = "Mediana";
            }else{
                tamaño = "Grande";
            }

            foreach (string i in ings){
                switch (char.Parse(i))
                {
                    case 'E': ingredientes+="Extra Queso, ";break;
                    case 'C': ingredientes+="Champiñones, ";break;
                    case 'T': ingredientes+="Tomate, ";break;
                    case 'P': ingredientes+="Piña, ";break;
                }
            }

            if(cub =='D'){
                cubierta = "Delgada";
            }else{
                cubierta = "Gruesa";
            }

            if(don == 'C'){
                donde = "Comer aqui";
            }else{
                donde = "Para llevar";
            }

            Console.Clear();
            Console.WriteLine($"Tamaño       : {tamaño}");
            Console.WriteLine($"Ingredientes : {ingredientes}");
            Console.WriteLine($"Cumbierta    : {cubierta}");
            Console.WriteLine($"Comer donde  : {donde}.\n\n");
            return 0;
        }
        static void Menu(){
            Console.WriteLine("Procesando Pizzas \n");
            Console.WriteLine("Tamaño       : (P)equeña,        (M)ediana o     (G)rande");
            Console.WriteLine("Ingredientes : (E)xtra Queso,    (C)hampiñoes,   (T)omates, (P)iña.");
            Console.WriteLine("Cumbierta    : (D)elgada o       (G)ruesa");
            Console.WriteLine("Comer donde  : (C)omer aquí o    (P)ara Llevar.\n\n");
            Console.WriteLine("<Tamaño> <ing1+ing2...> <Cubierta> <Donde>");
        }
    }
}
