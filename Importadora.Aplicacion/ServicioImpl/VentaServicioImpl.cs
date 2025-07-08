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
    public class VentaServicioImpl : IVentaServicio
    {
        private IVentaRepositorio _ventaRepositorio;
        private readonly importadoraDBContext _dbContext;

        public VentaServicioImpl(importadoraDBContext dbContext)
        {
            this._dbContext = dbContext;
            _ventaRepositorio = new VentaRepositorioImpl(_dbContext);
        }
        public async Task VentaAddAsync(VENTA entidad)
        {
            await _ventaRepositorio.AddAsync(entidad);
        }

        public async Task VentaDeleteAsync(int id)
        {
            await _ventaRepositorio.DeleteAsync(id);
        }

        public Task<IEnumerable<VENTA>> VentaGetAllAsync()
        {
            return _ventaRepositorio.GetAllAsync();
        }

        public Task<VENTA> VentaGetByIdAsync(int id)
        {
            return _ventaRepositorio.GetByIdAsync(id);
        }

        public async Task VentaUpdateAsync(VENTA entidad)
        {
            await _ventaRepositorio.UpdateAsync(entidad);
        }
    }
}
