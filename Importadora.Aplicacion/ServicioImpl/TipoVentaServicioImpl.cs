using Importadora.Aplicacion.ServicioEntidad;
using Importadora.Dominio.Modelo.Abstracciones;
using Importadora.Infraestructura.AccesoDatos;
using Importadora.Infraestructura.AccesoDatos.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Importadora.Aplicacion.ServicioImpl
{
    public class TipoVentaServicioImpl : ITipoVentaServicio
    {
        private ITipoVentaRepositorio _tipoVentaRepositorio;
        private readonly importadoraDBContext _dbContext;

        public TipoVentaServicioImpl(importadoraDBContext dbContext)
        {
            this._dbContext = dbContext;
            _tipoVentaRepositorio = new TipoVentaRepositorio(_dbContext);
        }
        public async Task TipoVentaAddAsync(TIPOVENTA entidad)
        {
            await _tipoVentaRepositorio.AddAsync(entidad);
        }

        public async Task TipoVentaDeleteAsync(int id)
        {
            await _tipoVentaRepositorio.DeleteAsync(id);
        }

        public Task<IEnumerable<TIPOVENTA>> TipoVentaGetAllAsync()
        {
            return _tipoVentaRepositorio.GetAllAsync();
        }

        public Task<TIPOVENTA> TipoVentaGetByIdAsync(int id)
        {
            return _tipoVentaRepositorio.GetByIdAsync(id);
        }

        public async Task TipoVentaUpdateAsync(TIPOVENTA entidad)
        {
            await _tipoVentaRepositorio.UpdateAsync(entidad);
        }
    }
}
