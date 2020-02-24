using System;

namespace _14.CuentaBancaria{
    class Program{
        static void PruebaCuentaBancaria(){
           CuentaBancaria chelines = new CuentaBancaria(1000);
           Console.WriteLine($"Saldo al crear {chelines.Saldo}");
           chelines.Depostia(500);
           Console.WriteLine($"Saldo despues del domingo {chelines.Saldo}");
           if(chelines.Retira(2500)){
               Console.WriteLine($"Saldo despues de la peda {chelines.Saldo}");
           }else{
               Console.WriteLine($"No puedes organizar pedas");
           }
        }

        static void PruebaCliente(){
            Cliente cliente1 = new Cliente("Juan Perez");
            Cliente cliente2 = new Cliente("Maria Lopez");
            Cliente cliente3 = new Cliente("Mario Lopez");

            CuentaBancaria cuenta1 = new CuentaBancaria(100);
            cliente1.Cuenta = cuenta1;
            cliente1.Cuenta.Depostia(500);

            cliente2.Cuenta = new CuentaBancaria(200);
            cliente3.Cuenta = cliente2.Cuenta;
            cliente2.Cuenta.Retira(50);
            cliente3.Cuenta.Depostia(100);

            Console.WriteLine($"Cliente {cliente1.Nombre} tiene un saldo de {cliente1.Cuenta.Saldo}");
            Console.WriteLine($"Cliente {cliente2.Nombre} tiene un saldo de {cliente2.Cuenta.Saldo}");
            Console.WriteLine($"Cliente {cliente3.Nombre} tiene un saldo de {cliente3.Cuenta.Saldo}");
        }
        
        static void Main(){
            Banco bancoaztea = new Banco("Banco Azteca","El de TVAzteca");

            bancoaztea.AgregarCliente(new Cliente("Genaro Borrego"));
            bancoaztea.AgregarCliente(new Cliente("Arturo Romo"));
            bancoaztea.AgregarCliente(new Cliente("Ricardo Monreal"));
            bancoaztea.AgregarCliente(new Cliente("Amalia Garcia"));
            bancoaztea.AgregarCliente(new Cliente("Miguel Alonso"));
            bancoaztea.AgregarCliente(new Cliente("Alejandro Tello"));

            bancoaztea.Clientes[0].Cuenta = new CuentaBancaria(150000);
            bancoaztea.Clientes[1].Cuenta = new CuentaBancaria(250000);
            bancoaztea.Clientes[2].Cuenta = new CuentaBancaria(350000);
            bancoaztea.Clientes[3].Cuenta = new CuentaBancaria(450000);
            bancoaztea.Clientes[4].Cuenta = new CuentaBancaria(550000);
            bancoaztea.Clientes[5].Cuenta = new CuentaBancaria(650000);

            bancoaztea.Clientes[2].Cuenta.Retira(2000);
        }
    }
}
