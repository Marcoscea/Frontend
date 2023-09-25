using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Channels;
namespace Proyecto.SistemaVentas.Models
{
    public class Producto
    {
        public int id { get; set; }
        public int idCategoria { get; set; }
        public String Codigo { get; set; }
        public String Nombre { get; set; }
        public DateTime FechaRegistro { get; set; }
        public String Categoria { get; set; }
        public String Precio { get; set; }
        public String Descripcion { get; set; }
    }
}
