using System.Collections.Generic;
using System;

namespace examen1{
    class Nodo{
        private string ip;
        private string tipo;
        private int puertos;
        private int saltos;
        private string so;
        private List<Vulnerabilidad> vulnerabilidades = new List<Vulnerabilidad>();

        public Nodo(string ip, string tipo, int puertos, int saltos, string so){
            this.ip = ip;
            this.tipo = tipo;
            this.puertos = puertos;
            this.saltos = saltos;
            this.so = so;
        }

        public string Ip{
            get {return ip;}
            set {ip = value;}
        }

        public string Tipo{
            get {return tipo;}
            set {tipo = value;}
        }

        public int Puertos{
            get {return puertos;}
            set {puertos = value;}
        }

        public int Saltos{
            get {return saltos;}
            set {saltos = value;}
        }

        public string So{
            get {return so;}
            set {so = value;}
        }

        public List<Vulnerabilidad> Vulnerabilidades{
            get {return vulnerabilidades;}
            set {vulnerabilidades = value;}
        }

        public void AgregarVulnerabilidad(Vulnerabilidad vulnerabilidad){
            vulnerabilidades.Add(vulnerabilidad);
        }

        public int TotalVulnerabilidades(){
            return vulnerabilidades.Count;
        }

        public override string ToString(){
            return $"Ip :   {ip}, "+
            $"Tipo  :   {tipo}, "+
            $"Puertos   :   {puertos}, "+
            $"Saltos    :   {saltos}, "+
            $"SO    :   {so}, "+
            $"TotVul    :   {TotalVulnerabilidades()}";
        }

        public void ImprimirVulnerabilidad(){
            Console.WriteLine($"> Ip:{ip}, Tipo:{tipo}");
            if(vulnerabilidades.Count>0){
                Console.WriteLine("Vulnerabilidades:");
                for(int i = 0;i < vulnerabilidades.Count; i++){
                    Console.WriteLine(vulnerabilidades[i].ToString());
                }
            }else{
                Console.WriteLine("No tiene vulnerabilidades");
            }
        }
    }
}