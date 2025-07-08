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
    public class UnidadMedidaServicioImpl : IUnidadMedidaServicio
    {
        private IUnidadMedidaRepositorio _unidadMedidaRepositorio;
        private readonly importadoraDBContext _dbContext;

        public UnidadMedidaServicioImpl(importadoraDBContext dbContext)
        {
            this._dbContext = dbContext;
            _unidadMedidaRepositorio = new UnidadMedidaRepositorioImpl(_dbContext);
        }
        public async Task UnidadMedidaAddAsync(UNIDADMEDIDA entidad)
        {
            await _unidadMedidaRepositorio.AddAsync(entidad);
        }

        public async Task UnidadMedidaDeleteAsync(int id)
        {
            await _unidadMedidaRepositorio.DeleteAsync(id);
        }

        public Task<IEnumerable<UNIDADMEDIDA>> UnidadMedidaGetAllAsync()
        {
            return _unidadMedidaRepositorio.GetAllAsync();
        }

        public Task<UNIDADMEDIDA> UnidadMedidaGetByIdAsync(int id)
        {
            return _unidadMedidaRepositorio.GetByIdAsync(id);
        }

        public async Task UnidadMedidaUpdateAsync(UNIDADMEDIDA entidad)
        {
           await _unidadMedidaRepositorio.UpdateAsync(entidad);
        }
    }
}
