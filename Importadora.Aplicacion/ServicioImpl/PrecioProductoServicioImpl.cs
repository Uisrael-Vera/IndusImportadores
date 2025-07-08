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
    public class PrecioProductoServicioImpl : IPrecioProductoServicio
    {
        private IPrecioProductoRepositorio _precioProductoRepositorio;
        private readonly importadoraDBContext _dbContext;

        public PrecioProductoServicioImpl(importadoraDBContext dbContext)
        {
            this._dbContext = dbContext;
            _precioProductoRepositorio = new PrecioProductoRepositorioImpl(_dbContext);
        }

        public async Task PrecioProductoAddAsync(PRECIOPRODUCTO entidad)
        {
            await _precioProductoRepositorio.AddAsync(entidad);
        }

        public async Task PrecioProductoDeleteAsync(int id)
        {
            await _precioProductoRepositorio.DeleteAsync(id);
        }

        public Task<IEnumerable<PRECIOPRODUCTO>> PrecioProductoGetAllAsync()
        {
            return _precioProductoRepositorio.GetAllAsync();
        }

        public Task<PRECIOPRODUCTO> PrecioProductoGetByIdAsync(int id)
        {
            return _precioProductoRepositorio.GetByIdAsync(id);
        }

        public async Task PrecioProductoUpdateAsync(PRECIOPRODUCTO entidad)
        {
            await _precioProductoRepositorio.UpdateAsync(entidad);
        }
    }
}
