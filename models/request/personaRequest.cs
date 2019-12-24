using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_crud.models.request
{
    public partial class personaRequest
    {
        [DataType(DataType.Text)]
        [MaxLength(10), MinLength(6)]
        [Required(ErrorMessage = "Please enter name")]
        [Display(Name = "Nombre")]
        public string nombre { get; set; }

        public string apellido { get; set; }

        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Please enter Email")]
        [RegularExpression(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$", ErrorMessage = "Email is not valid.")]
        [Display(Name = "Correo")]
        public string correo { get; set; }
        public string contrasena { get; set; }


    }
}
