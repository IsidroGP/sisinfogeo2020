using System;

namespace ej1{
    class empleado{
        private string nombre;
        private int edad; 
        public string Nombre{
            get { return nombre; } 
            set { nombre = value; }
        }
        public int Edad{
            get { return edad; } 
            set { edad = value; }
        }

        public string Vacaciones(DateTime inicio, int dias){
            DateTime fin;
            fin =inicio.AddDays(dias);
            return fin.ToString("dd/MM/yy");
        }
        public override string ToString() {
            return $"Nombre:{nombre}, Edad:{edad}";
        }
    }
}