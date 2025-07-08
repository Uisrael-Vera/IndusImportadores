using Importadora.Dominio.Modelo.Abstracciones;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Importadora.Infraestructura.AccesoDatos.Repositorio
{
    public class TipoVentaRepositorio : RepositorioImpl<TIPOVENTA>, ITipoVentaRepositorio
    {
        private readonly importadoraDBContext _importadoraDBContext;
        public TipoVentaRepositorio(importadoraDBContext dBContext) : base(dBContext)
        {

            _importadoraDBContext = dBContext;
        }

        public async Task<List<TIPOVENTA>> ListarTiposVenta()
        {
            try
            {
                var resultado = await(
                    from v in _importadoraDBContext.VENTA
                    join tv in _importadoraDBContext.TIPOVENTA on v.id_tipoventa equals tv.id_tipoventa
                    join u in _importadoraDBContext.USUARIO on v.id_usuario equals u.id_usuario
                    group v by new { tv.nombreTipo, u.nombre } into grupo
                    select new
                    {
                        TipoVenta = grupo.Key.nombreTipo,
                        Vendedor = grupo.Key.nombre,
                        TotalVentas = grupo.Count()
                    }
                ).ToListAsync();

                return resultado;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener ventas por tipo de venta y vendedor: " + ex.Message, ex);
            }
        }
    }

  
}
