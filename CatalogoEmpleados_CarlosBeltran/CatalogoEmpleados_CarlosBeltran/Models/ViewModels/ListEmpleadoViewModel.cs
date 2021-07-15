using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CatalogoEmpleados_CarlosBeltran.Models.ViewModels
{
    public class ListEmpleadoViewModel
    {
        public int IdEmpleado { get; set; }
        public string Nombre { get; set; }
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public float Sueldo { get; set; }
        public string Departamento { get; set; }

    }
}