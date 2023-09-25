using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Proyecto.SistemaVentas.Models;

namespace Proyecto.SistemaVentas.Services
{
    public interface IProductoService
    {
        Task<IEnumerable<Producto>> GetAll();
    }
}
