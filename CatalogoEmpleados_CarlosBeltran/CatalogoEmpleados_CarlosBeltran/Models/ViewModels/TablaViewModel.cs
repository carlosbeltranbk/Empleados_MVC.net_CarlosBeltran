using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CatalogoEmpleados_CarlosBeltran.Models.ViewModels
{
    public class TablaViewModel
    {
        public int IdEmpleado { get; set; }
        [Required]
        [StringLength(45)]
        [Display(Name = "Nombre")]
        public string Nombre { get; set; }
        [Required]
        [StringLength(45)]
        [Display(Name = "Apellido paterno")]
        public string Apellido1 { get; set; }
        [Required]
        [StringLength(45)]
        [Display(Name = "Apellido materno")]
        public string Apellido2 { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Fecha de nacimiento")]
        public DateTime FechaNacimiento { get; set; }
        [Required]
        [Display(Name = "Sueldo")]
        public float Sueldo { get; set; }
        [Required]
        [Display(Name = "Departamento")]
        public string Departamento { get; set; }
    }
}