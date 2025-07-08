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
    public class ActividadServicioImpl : IActividadServicio
    {
        private IActividadRepositorio _actividadRepositorio;
        private readonly importadoraDBContext _dbContext;

        public ActividadServicioImpl(importadoraDBContext dbContext)
        {
            this._dbContext = dbContext;
            _actividadRepositorio = new ActividadRepositorioImpl(_dbContext);
        }
        public async Task ActividadAddAsync(ACTIVIDAD entidad)
        {
            await _actividadRepositorio.AddAsync(entidad);
        }

        public async Task ActividadDeleteAsync(int id)
        {
            await _actividadRepositorio.DeleteAsync(id);
        }

        public Task<IEnumerable<ACTIVIDAD>> ActividadGetAllAsync()
        {
            return _actividadRepositorio.GetAllAsync();
        }

        public Task<ACTIVIDAD> ActividadGetByIdAsync(int id)
        {
            return _actividadRepositorio.GetByIdAsync(id);
        }

        public async Task ActividadUpdateAsync(ACTIVIDAD entidad)
        {
            await _actividadRepositorio.UpdateAsync(entidad);
        }
    }
}
