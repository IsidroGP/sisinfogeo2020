using System.Collections.Generic;
using System;

namespace examen1{
    class Red{
        private string empresa;
        private string propietario;
        private string domicilio;
        private List<Nodo> nodos = new List<Nodo>();

        public Red(string empresa, string propietario, string domicilio){
            this.empresa = empresa;
            this.propietario = propietario;
            this.domicilio = domicilio;
        }

        public string Empresa{
            get {return empresa;}
            set {empresa = value;}
        }

        public string Propietario{
            get {return propietario;}
            set {propietario = value;}
        }

        public string Domicilio{
            get {return domicilio;}
            set {domicilio = value;}
        }

        public List<Nodo> Nodos { 
            get {return nodos;} 
            set {nodos = value;}
        }

        public void AgregarNodo(Nodo nodo){
            nodos.Add(nodo);
        }

        public string toString(){
            return $"Empresa    :   {empresa}\n"+
            $"Propietario  :   {propietario}\n"+
            $"Domicilio    :   {domicilio}";
        }
        public int TotalNodos(){
            return nodos.Count;
        }

        public int TotalVulnerabilidades(){
            int totalvulnerabilidades = 0;
            for(int i = 0;i<Nodos.Count;i++){
                totalvulnerabilidades += Nodos[i].TotalVulnerabilidades();
            }
            return totalvulnerabilidades;
        }

        public int SaltoMenor(){
            int saltomenor=0;
            for(int i = 0; i<nodos.Count;i++){
                if(saltomenor==0||saltomenor>nodos[i].Saltos){
                    saltomenor = nodos[i].Saltos;
                }
            }
            return saltomenor;
        }

        public int SaltoMayor(){
            int saltomayor=0;
            for(int i = 0; i<nodos.Count;i++){
                if(saltomayor==0||saltomayor<nodos[i].Saltos){
                    saltomayor = nodos[i].Saltos;
                }
            }
            return saltomayor;
        }

        public void ImprimirNodos(){
            for(int j = 0; j<Nodos.Count; j++){
                Console.WriteLine(Nodos[j].ToString());
            }
        }

        public void ImprimirVulnerabilidades(){
            for(int i = 0;i<Nodos.Count;i++){
                Nodos[i].ImprimirVulnerabilidad();
            }
        }
    }
}