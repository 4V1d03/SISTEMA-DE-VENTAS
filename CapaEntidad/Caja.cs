using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Caja
    {
        public Usuario oUsuario { get; set; }
        public int Codigo { get; set; }

        public string FechaInicio { get; set; } 

        public decimal CantidadInicial { get; set; }

        public decimal CantidadFinal { get; set; }

        public string Empleado { get; set; }

        public string FechaCierre { get; set;}

        public bool EstadoCaja { get; set; } 

        public decimal TotalVentas { get; set; }
    }
}
