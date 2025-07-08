using Importadora.Dominio.Modelo.Abstracciones;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Importadora.Infraestructura.AccesoDatos.Repositorio
{
    public class VentaRepositorioImpl : RepositorioImpl<VENTA>, IVentaRepositorio
    {
        private readonly importadoraDBContext _importadoraDBContext;
        public VentaRepositorioImpl(importadoraDBContext dBContext) : base(dBContext)
        {
            _importadoraDBContext = dBContext;
        }

        //Detalle completo de una venta con los productos involucrados

        public async Task<List<VENTA>> ListarVentas()
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
                ).ToListAsync();

                return resultado;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener detalles de venta con productos: " + ex.Message, ex);
            }
        }

        



        // Ventas y sus detalles con información de contacto y empresa

        public async Task<List<VENTA>> ListarVentasConDetalle()
        {
            try
            {
                var resultado = await (
                    from v in _importadoraDBContext.VENTA
                    join e in _importadoraDBContext.EMPRESA on v.id_empresa equals e.id_empresa
                    join dv in _importadoraDBContext.DETALLEVENTA on v.id_venta equals dv.id_venta
                    join pp in _importadoraDBContext.PRECIOPRODUCTO on dv.id_precio equals pp.id_precio
                    join p in _importadoraDBContext.PRODUCTO on pp.id_producto equals p.id_producto
                    join c in _importadoraDBContext.CONTACTO on e.id_empresa equals c.id_empresa
                    select new
                    {
                        idVenta = v.id_venta,
                        Empresa = e.nombre,
                        Contacto = c.nombre,
                        TotalProducto = dv.totalProducto
                    }
                ).ToListAsync<object>();

                return resultado;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el detalle de la venta: " + ex.Message, ex);
            }
        }

        public async Task<List<VENTA>> ListarVentasTotalesPorEmpresa()
        {
            try
            {
                var resultado = await(
                    from v in _importadoraDBContext.VENTA
                    join e in _importadoraDBContext.EMPRESA on v.id_empresa equals e.id_empresa
                    group v by e.nombre into grupo
                    select new
                    {
                        Empresa = grupo.Key,
                        TotalVentas = grupo.Sum(x => x.totalVenta)
                    }
                ).ToListAsync<object>();

                return resultado;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener ventas totales por empresa: " + ex.Message, ex);
            }
        }

       
    }


}
