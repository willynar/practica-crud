using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_crud.models.request
{
    public partial class personaRequest
    {
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string correo { get; set; }
        public string contrasena { get; set; }


    }
}
