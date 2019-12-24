using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_crud.models.request
{
    class ConsultaProducto
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public int? cantidad_inicial { get; set; }
        public int? cantidad_final { get; set; }
        public decimal? valor_total { get; set; }
        public decimal? valor_unidad { get; set; }
        public DateTime? fecha { get; set; }
        public string imagen { get; set; }
        public string estado { get; set; }
        public string catalogo { get; set; }
        public int? id_usuario { get; set; }
        public string tipo_cantidad { get; set; }
    }
}
