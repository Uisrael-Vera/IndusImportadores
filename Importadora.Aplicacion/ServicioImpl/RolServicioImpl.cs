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
    public class RolServicioImpl : IRolServicio
    {
        private IRolRepositorio _rolRepositorio;
        private readonly importadoraDBContext _dbContext;

        public RolServicioImpl(importadoraDBContext dbContext)
        {
            this._dbContext = dbContext;
            _rolRepositorio = new RolRepositorioImpl(_dbContext);
        }
        public async Task RolAddAsync(ROL entidad)
        {
            await _rolRepositorio.AddAsync(entidad);
        }

        public async Task RolDeleteAsync(int id)
        {
            await _rolRepositorio.DeleteAsync(id);
        }

        public Task<IEnumerable<ROL>> RolGetAllAsync()
        {
            return _rolRepositorio.GetAllAsync();
        }

        public Task<ROL> RolGetByIdAsync(int id)
        {
            return _rolRepositorio.GetByIdAsync(id);
        }

        public async Task RolUpdateAsync(ROL entidad)
        {
            await _rolRepositorio.UpdateAsync(entidad);
        }
    }
}
