using System;
using System.Collections.Generic;

namespace _14.CuentaBancaria{
    class Banco{
        private List<Cliente> clientes;
        private string nombre;
        private string propietario;

        public Banco(string nombre, string propietario){
            this.nombre = nombre;
            this.propietario = propietario;
            clientes = new List<Cliente>();
        }
        public string Nombre{
            get{ return nombre;}
            set{ nombre = value;}
        }
    
        public string Propietario{
            get{ return propietario;}
            set{ propietario = value;}
        }

        public void AgregarCliente(Cliente cte){
            clientes.Add(cte);
        }

        public List<Cliente> Clientes{
            get {return clientes;}
        }


    }
}