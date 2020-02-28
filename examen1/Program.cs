using System;

namespace examen1{
    class Program{
        static void Main(string[] args){
            Red red1 = new Red("Red Patito, S.A. de C.V.", "Mr Pato Macdonlad", "Av. Princeton 123, Orlando Florida");
            Nodo nodo1 = new Nodo("192.168.0.10","servidor",5,10,"linux");
            Nodo nodo2 = new Nodo("192.168.0.12","equipoactivo",2,12,"ios");
            Nodo nodo3 = new Nodo("192.168.0.20","computadora",8,5,"windows");
            Nodo nodo4 = new Nodo("192.168.0.15","servidor",10,22,"linux");
            red1.AgregarNodo(nodo1);
            red1.AgregarNodo(nodo2);
            red1.AgregarNodo(nodo3);
            red1.AgregarNodo(nodo4);
            Vulnerabilidad v1 = new Vulnerabilidad("CVE-2015-1635","microsoft","HTTP.sys permite a atacantes remotos ejecutar código arbitrario", "remota", "14/04/2015");
            Vulnerabilidad v2 = new Vulnerabilidad("CVE-2017-0004","microsoft","El servicio LSASS permite causar una denegación de servicio", "local", "10/01/2019");
            red1.Nodos[0].AgregarVulnerabilidad(v1);
            red1.Nodos[0].AgregarVulnerabilidad(v2);
            Vulnerabilidad v3 = new Vulnerabilidad("CVE-2017-3847","cisco","Cisco Firepower Management Center XSS", "remota", "21/02/2017");
            red1.Nodos[1].AgregarVulnerabilidad(v3);
            Vulnerabilidad v4 = new Vulnerabilidad("CVE-2009-2504","microsoft","Múltiples desbordamientos de enteros en APIs Microsoft .NET 1.1", "local", "13/11/2009");
            Vulnerabilidad v5 = new Vulnerabilidad("CVE-2016-7271","microsoft","Elevación de privilegios Kernel Segura en Windows 10 Gold", "local", "20/12/2016");
            Vulnerabilidad v6 = new Vulnerabilidad("CVE-2017-2996","adobe","Adobe Flash Player 24.0.0.194 corrupción de memoria explotable", "remota", "15/02/2017");
            red1.Nodos[2].AgregarVulnerabilidad(v4);
            red1.Nodos[2].AgregarVulnerabilidad(v5);
            red1.Nodos[2].AgregarVulnerabilidad(v6);


            



            Console.WriteLine(">> Datos generales de la red:");
            Console.WriteLine(red1.toString());
            Console.WriteLine($"Total nodos red  :  {red1.TotalNodos()}\n"+
            $"Total vulnerabilidades :   {red1.TotalVulnerabilidades()}");
            Console.WriteLine(">> Datos generales de los nodos");
            red1.ImprimirNodos();
            Console.WriteLine($"Mayor numero de saltos: {red1.SaltoMayor()}");
            Console.WriteLine($"Menor numero de saltos: {red1.SaltoMenor()}");
            Console.WriteLine(">> Vulnerabiliades por Nodo");
            red1.ImprimirVulnerabilidades();

        }
    }
}
