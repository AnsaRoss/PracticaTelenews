using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PracticaTelenews.Models
{
    public class Persona
    {
        [Key]
        public int id { get; set; }
        [Display(Name ="Nombre")]
        [Required(ErrorMessage = "El campo es obligatorio")]
        public string nombre { get; set; }
        [Display(Name ="Apellidos")]
        [Required(ErrorMessage ="El campo es obligatorio")]
        public string apellidos { get; set; }
        [Display(Name = "Edad")]
        [Required(ErrorMessage = "El campo es obligatorio")]
        public int edad { get; set; }
    }
}
