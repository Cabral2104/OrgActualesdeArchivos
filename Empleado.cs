using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrgActualesdeArchivos
{
    public class Empleado
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public decimal Salario { get; set; }

        public Empleado(string nombre, string apellido, decimal salario)
        {
            Nombre = nombre;
            Apellido = apellido;
            Salario = salario;
        }

        public override string ToString()
        {
            return $"{Nombre} {Apellido} - Salario: {Salario:C}";
        }
    }
}
