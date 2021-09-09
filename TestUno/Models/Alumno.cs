using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestUno.Models
{
    public class Alumno
    {
        public int Id { get; set; }
        [Display(Name = "Pone tu nombre ")]
        [Required(ErrorMessage ="El nombre es obligatorio")]
        public string Nombre { get; set; }

        [Display(Name = "Last Name")]
        public string Apellido { get; set; }
    }
}
