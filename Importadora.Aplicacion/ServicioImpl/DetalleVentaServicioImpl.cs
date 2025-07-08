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
    public class DetalleVentaServicioImpl : IDetalleVentaServicio
    {
        private IDetalleVentaRepositorio _detalleventaRepositorio;
        private readonly importadoraDBContext _dbContext;

        public DetalleVentaServicioImpl(importadoraDBContext dbContext)
        {
            this._dbContext = dbContext;
            _detalleventaRepositorio = new DetalleVentaRepositorioImpl(_dbContext);
        }
        public async Task DetalleVentaAddAsync(DETALLEVENTA entidad)
        {
            await _detalleventaRepositorio.AddAsync(entidad);
        }

        public async Task DetalleVentaDeleteAsync(int id)
        {
            await _detalleventaRepositorio.DeleteAsync(id);
        }

        public Task<IEnumerable<DETALLEVENTA>> DetalleVentaGetAllAsync()
        {
            return _detalleventaRepositorio.GetAllAsync();
        }

        public Task<DETALLEVENTA> DetalleVentaGetByIdAsync(int id)
        {
            return _detalleventaRepositorio.GetByIdAsync(id);
        }

        public async Task DetalleVentaUpdateAsync(DETALLEVENTA entidad)
        {
            await _detalleventaRepositorio.UpdateAsync(entidad);
        }
    }
}
