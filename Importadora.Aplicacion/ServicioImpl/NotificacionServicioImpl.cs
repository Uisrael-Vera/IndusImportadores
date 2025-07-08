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
    public class NotificacionServicioImpl : INotificacionServicio
    {
        private INotificacionRepositorio _notificacionRepositorio;
        private readonly importadoraDBContext _dbContext;

        public NotificacionServicioImpl(importadoraDBContext dbContext)
        {
            this._dbContext = dbContext;
            _notificacionRepositorio = new NotificacionRepositorioImpl(_dbContext);
        }
        public async Task NotificacionAddAsync(NOTIFICACION entidad)
        {
            await _notificacionRepositorio.AddAsync(entidad);
        }

        public async Task NotificacionDeleteAsync(int id)
        {
            await _notificacionRepositorio.DeleteAsync(id);
        }

        public Task<IEnumerable<NOTIFICACION>> NotificacionGetAllAsync()
        {
            return _notificacionRepositorio.GetAllAsync();
        }

        public Task<NOTIFICACION> NotificacionGetByIdAsync(int id)
        {
            return _notificacionRepositorio.GetByIdAsync(id);
        }

        public async Task NotificacionUpdateAsync(NOTIFICACION entidad)
        {
            await _notificacionRepositorio.UpdateAsync(entidad);
        }

        public Task<List<NOTIFICACION>> ListarNotificacionesPorContacto(int idContacto)
        {
           
        }
    }
}
