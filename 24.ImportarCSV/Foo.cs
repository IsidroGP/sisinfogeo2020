using System;

namespace p24.ImportarCSV
{
    public class Foo
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public double Salario {get; set;}
        public string Fecha {get; set;}
        public override string ToString() => $"{Id} {Nombre} {Salario} {Fecha}";
    }
}