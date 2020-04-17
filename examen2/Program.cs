﻿using System;
using System.IO; // Libreria para StreamREader y StreamWriter
using CsvHelper; // Libreria para trabajar con archivos cvs
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace examen2{
    class Program{
        static void Main(string[] args){
            List<Empleado> registros = new List<Empleado>();
            registros = Leer("datos.csv");
            Console.WriteLine("\nRegistros leidos del archivo file.csv\n");
            registros.ForEach(r=>Console.WriteLine(r.ToString()));
            registros[0].setJubilado("Si");
            registros[1].setJubilado("No");
            registros[2].setJubilado("Si");
            registros[3].setJubilado("No");
            registros[4].setJubilado("Si");
            registros[5].setJubilado("No");
            registros[6].setJubilado("No");
            registros[7].setJubilado("Si");
            registros[8].setJubilado("No");
            registros[9].setJubilado("No");
            registros[10].setJubilado("Si");
            registros[11].setJubilado("No");
            registros[12].setJubilado("Si");
            registros[13].setJubilado("No");

            //1. Listado de nómina en el orden original
            Grabar(registros,"nomina2.csv");
            //2. Listado de nómina ordenado por nombre
            var orderByNombre = (from s in registros orderby s.Nombre select s).ToList();
            Grabar(orderByNombre,"nomina3.csv");
            //3. Listado de nómina ordenado por salario
            var orderBySalario = (from s in registros orderby s.Salario select s).ToList();
            Grabar(orderBySalario,"nomina4.csv");
            //4. Listado de nómina con salario > 3500
            var orderBySalario2 = (from s in registros where s.Salario > 3500 select s).ToList();
            Grabar(orderBySalario2,"nomina5.csv");
            //5. Listado de nómina con 77 en el Rfc
            var contain77 = (from s in registros where s.Rfc.Contains("77") select s).ToList();
            Grabar(contain77,"nomina6.csv");
            //6. Listado de nómina con los JUBILADOS
            var jubilados = (from s in registros where s.getJubilado().Contains("Si") select s).ToList();
            Grabar(jubilados,"nomina7.csv");
            //7. Listado de nómina agrupado por área
            var groupbyarea  = (from s in registros orderby s.Area select s).ToList();
            Grabar(groupbyarea,"nomina8.csv");
        }
        public static List<Empleado> Leer(string file) {
            using (var  reader = new StreamReader(file))
            using (var cvs = new CsvReader(reader,CultureInfo.InvariantCulture))
            {
                cvs.Configuration.HasHeaderRecord=false;
                cvs.Read();
                var records=cvs.GetRecords<Empleado>().ToList();
                //Console.WriteLine(records[0].ToString());
                return records;
            }
        }
        public static void Grabar(List<Empleado> records, string file) {
             using (var writer = new StreamWriter(file))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(records);
            }           
        }
    }
}
