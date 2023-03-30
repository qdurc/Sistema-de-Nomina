using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desarrollo_de_software
{
    class Empleado
    {
        private string nombre;
        private string apellido;
        private double sueldoBruto;
        public string Nombre
        {
            get{return this.nombre;}
            set{this.nombre = value;}
        }
        public string Apellido
        {
            get{return this.apellido;}
            set{this.apellido = value;}
        }
        public double SueldoBruto
        {
            get{return this.sueldoBruto;}
            set{this.sueldoBruto = value;}
        }
        public Empleado(string nombre, string apellido, double sueldoBruto)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.sueldoBruto = sueldoBruto;
        }

        public void AgregarEmpleado(List<Empleado> listaEmpleados)
        {
            Console.Write("Cantidad de empleados a ingresar: ");
            int cantEmpleados = int.Parse(Console.ReadLine());

            for (int i = 0; i < cantEmpleados; i++)
            {
                Console.Write($"\nIngrese nombre del Empleado {i + 1}: ");
                string nombre = Console.ReadLine();
                Console.Write($"Ingrese el apellido del Empleado {i + 1}: ");
                string apellido = Console.ReadLine();
                Console.Write($"Ingrese el sueldo bruto del Empleado {i + 1}: ");
                double salarioBruto = double.Parse(Console.ReadLine());
                Empleado empleado = new Empleado(nombre, apellido, salarioBruto);
                listaEmpleados.Add(empleado);
            }
        }

        public void CalcularDeduccionesEmpleados(List<Empleado> listaEmpleados)
        {
            int contador = 1;
            double totalSueldoBruto = 0.0;
            double totalAFP = 0;
            double totalSFS = 0;
            double totalDedTotales = 0;
            double totalSueldoNeto = 0;

            Console.WriteLine("\n-----Reporte de Nomina-----\n");
            foreach (Empleado empleado in listaEmpleados)
            {
                double descSFS = empleado.SueldoBruto * 0.0304;
                double descAFP = empleado.SueldoBruto * 0.0287;
                double deduccTotales = descAFP + descSFS;
                double sueldoNeto = empleado.sueldoBruto - deduccTotales;

                Console.WriteLine(
                        $"Empleado {contador++}:\n" +
                        $"Nombre Completo: {empleado.Nombre}" + $" {empleado.apellido}\n" +
                        $"Sueldo Bruto: {empleado.SueldoBruto}\n" +
                        $"AFP: {descAFP}\n" +
                        $"SFS: {descSFS}\n" +
                        $"Deducciones totales: {deduccTotales}\n" +
                        $"Sueldo Neto: {sueldoNeto}\n"
                        );

                totalSueldoBruto += empleado.sueldoBruto;
                totalAFP += descAFP;
                totalSFS += descSFS;
                totalDedTotales += deduccTotales;
                totalSueldoNeto += sueldoNeto;

                if (listaEmpleados.IndexOf(empleado) == listaEmpleados.Count - 1)
                {
                    Console.WriteLine(
                        "-----Totales Generales-----\n" +
                        $"\nSueldo Bruto: {totalSueldoBruto}\n" +
                        $"AFP: {totalAFP}\n" +
                        $"SFS: {totalSFS}\n" +
                        $"Deducciones totales: {totalDedTotales}\n" +
                        $"Sueldo Neto: {totalSueldoNeto}"
                        );
                }
            }
        }
    }
}
