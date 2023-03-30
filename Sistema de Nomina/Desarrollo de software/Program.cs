using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desarrollo_de_software
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Empleado> listaEmpleados = new List<Empleado>();
            Empleado prueba = new Empleado(null, null, 0.0);

            prueba.AgregarEmpleado(listaEmpleados);
            prueba.CalcularDeduccionesEmpleados(listaEmpleados);

            Console.ReadKey();
        }
    }
}
