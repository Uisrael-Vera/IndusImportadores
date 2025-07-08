using Importadora.Dominio.Modelo.Abstracciones;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Importadora.Infraestructura.AccesoDatos.Repositorio
{
    public class ProductoRepositotioImpl : RepositorioImpl<PRODUCTO>, IProductoRepositorio
    {
        private readonly importadoraDBContext _importadoraDBContext;
        public ProductoRepositotioImpl(importadoraDBContext dBContext) : base(dBContext)
        {

            _importadoraDBContext = dBContext;
        }

        

        public async Task<List<PRODUCTO>> ListarProductosPorPrecio()
        {
            try
            {
                var resultado = await (
                    from v in _importadoraDBContext.VENTA
                    join dv in _importadoraDBContext.DETALLEVENTA on v.id_venta equals dv.id_venta
                    join pp in _importadoraDBContext.PRECIOPRODUCTO on dv.id_precio equals pp.id_precio
                    join p in _importadoraDBContext.PRODUCTO on pp.id_producto equals p.id_producto
                    select new
                    {
                        idVenta = v.id_venta,
                        Producto = p.nombre,
                        Cantidad = dv.cantidad,
                        TotalProducto = dv.totalProducto
                    }
                ).ToListAsync(); // Cast para que puedas devolver como List<object>

                return resultado;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener detalles de venta con productos: " + ex.Message, ex);
            }
        }

        public async Task<List<PRODUCTO>> ListarHistorialDePrecios( string nombreProducto)
        {
            try
            {
                var resultado = await(
                    from p in _importadoraDBContext.PRODUCTO
                    join pp in _importadoraDBContext.PRECIOPRODUCTO on p.id_producto equals pp.id_producto
                    where p.nombre == nombreProducto
                    select new
                    {
                        Producto = p.nombre,
                        Precio = pp.precio,
                        FechaInicio = pp.fechaInicio,
                        FechaFin = pp.fechaFin
                    }
                ).ToListAsync<object>();

                return resultado;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener historial de precios: " + ex.Message, ex);
            }
        }
    }
}
