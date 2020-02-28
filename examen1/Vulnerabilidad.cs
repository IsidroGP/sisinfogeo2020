using System;

namespace examen1{
    class Vulnerabilidad{
        private string clave;
        private string vendedor;
        private string descripcion;
        private string tipo;
        private string fecha;
        private string antiguedad;

        public Vulnerabilidad(string clave, string vendedor, string descripcion, string tipo, string fecha){
            this.clave = clave;
            this.vendedor = vendedor;
            this.descripcion = descripcion;
            this.tipo = tipo;
            this.fecha = fecha;
            antiguedad = CalcularAntiguedad(fecha);
        }

        public string Clave{
            get {return clave;}
            set {clave = value;}
        }

        public string Vendedor{
            get {return vendedor;}
            set {vendedor = value;}
        }

        public string Descripcion{
            get {return descripcion;}
            set {descripcion = value;}
        }

        public string Tipo{
            get {return Tipo;}
            set {tipo = value;}
        }

        public string Fecha{
            get {return fecha;}
            set {fecha = value;}
        }

        public string CalcularAntiguedad(string fecha){
            int antiguedad = DateTime.Now.Year-DateTime.ParseExact(fecha,"dd/MM/yyyy",null).Year;
            return antiguedad.ToString();
        }

        public override string ToString(){
            return $"Clave: {clave}, Vendedor: {vendedor}, Descripcion: {descripcion}, Tipo: {tipo}, Fecha: {fecha}, Antiguedad: {antiguedad}";
        }
    }
}