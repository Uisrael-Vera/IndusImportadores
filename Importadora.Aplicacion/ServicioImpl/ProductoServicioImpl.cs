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
    public class ProductoServicioImpl : IProductoServicio
    {
        private IProductoRepositorio _productoRepositorio;
        private readonly importadoraDBContext _dbContext;

        public ProductoServicioImpl(importadoraDBContext dbContext)
        {
            this._dbContext = dbContext;
            _productoRepositorio = new ProductoRepositotioImpl(_dbContext);
        }
        public async Task ProductoAddAsync(PRODUCTO entidad)
        {
            await _productoRepositorio.AddAsync(entidad);
        }

        public async Task ProductoDeleteAsync(int id)
        {
            await _productoRepositorio.DeleteAsync(id);
        }

        public Task<IEnumerable<PRODUCTO>> ProductoGetAllAsync()
        {
            return _productoRepositorio.GetAllAsync();
        }

        public Task<PRODUCTO> ProductoGetByIdAsync(int id)
        {
            return _productoRepositorio.GetByIdAsync(id);
        }

        public async Task ProductoUpdateAsync(PRODUCTO entidad)
        {
            await _productoRepositorio.UpdateAsync(entidad);
        }
    }
}
