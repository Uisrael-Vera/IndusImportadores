using Importadora.Infraestructura.AccesoDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Importadora.Dominio.Modelo.Abstracciones
{
    public interface IProductoRepositorio : IRepositorio<PRODUCTO>
    {
        Task<List<PRODUCTO>> ListarProductosPorPrecio(); // Método para listar productos ordenados por precio

        Task<List<PRODUCTO>> ListarHistorialDePrecios(); // Método para listar el historial de precios de productos

    }
}
