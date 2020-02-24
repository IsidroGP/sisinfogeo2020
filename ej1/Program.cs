using System;

namespace ej1
{
    class Program
    {
        static void Main(string[] args)
        {
            empleado empleado01 = new empleado();
            empleado empleado02;
            empleado02 = new empleado();

            empleado01.Nombre = "Juan";
            empleado01.Edad = 25;
            
            Console.WriteLine("El nombre es {0} y la edad {1}", empleado01.Nombre,empleado01.Edad);
            Console.WriteLine(empleado01.ToString());
            Console.WriteLine($"Te vas de vacaciones el dia: {DateTime.Now.ToString("dd/MM/yy")}");
            Console.WriteLine($"Regresas: {empleado01.Vacaciones(DateTime.Now,30)}");
        }
    }
}
