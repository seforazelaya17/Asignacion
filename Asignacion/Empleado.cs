using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asignacion
{
    public class Empleado
    {
        public string Nombre { get; set; }
        public int NumeroEmpleado { get; set; }
        public decimal Salario { get; set; }
        public bool Activo { get; set; }

        public Empleado(string nombre, int numeroEmpleado, decimal salario)
        {
            Nombre = nombre;
            NumeroEmpleado = numeroEmpleado;
            Salario = salario;
            Activo = true;
        }

        public void MostrarDetalles()
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Número de Empleado: {NumeroEmpleado}");
            Console.WriteLine($"Salario: ${Salario}");
            Console.WriteLine($"Estado: {(Activo ? "Activo" : "Inactivo")}\n");
        }

        public void CambiarEstado(bool nuevoEstado)
        {
            Activo = nuevoEstado;
        }

    }
}
