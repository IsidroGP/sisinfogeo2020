using System;

namespace examen2{
    class Empleado{
        public string Rfc{get; set;}
        public string Nombre{get; set;}
        public string Area{get; set;}
        public int Salario{get; set;}
        private string Jubilado;

        public void setJubilado(string Jubilado){
            this.Jubilado = Jubilado;
        }
        public string getJubilado(){
            return Jubilado;
        }
        public override string ToString() => $"{Rfc} {Nombre} {Area} {Salario}";
    }
}
