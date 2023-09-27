using Proyecto.SistemaVentas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace Proyecto.SistemaVentas.Services
{
    public class ProductoService : IProductoService
    {
        //inyeccion de dependencias de HttpClient
        private readonly HttpClient _httpClient;
        public ProductoService(HttpClient httpClient)
        {
            httpClient = httpClient;
        }

        public async Task <IEnumerable<Producto>> GetAll()
        {
            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            string resp = await _httpClient.GetStringAsync($"Producto");
            return JsonSerializer.Deserialize<IEnumerable<Producto>>(resp, options);
        }
    }
}
