using Importadora.Infraestructura.AccesoDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Importadora.Dominio.Modelo.Abstracciones
{
    public interface IVentaRepositorio : IRepositorio<VENTA>
    {
        Task<List<VENTA>> ListarVentas(); // Método para listar todas las ventas con productos

        Task<List<VENTA>> ListarVentasConDetalle(); // Método para listar todas las ventas y todos sus detalles con información de contacto y empresa

        Task<List<VENTA>> ListarVentasTotalesPorEmpresa(); // Método para listar todas las ventas totales por empresa
    }
}
