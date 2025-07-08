using Importadora.Dominio.Modelo.Abstracciones;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Importadora.Infraestructura.AccesoDatos.Repositorio
{
    public class NotificacionRepositorioImpl : RepositorioImpl<NOTIFICACION>, INotificacionRepositorio
    {
        private readonly importadoraDBContext _importadoraDBContext;
        public NotificacionRepositorioImpl(importadoraDBContext dBContext) : base(dBContext)
        {
            _importadoraDBContext = dBContext;
        }

        public async Task<List<NOTIFICACION>> ListarNotificacionesPorContacto(int idContacto)
        {
            try
            {
                var notificaciones = await _importadoraDBContext.NOTIFICACION.Where(n => n.id_contacto == idContacto).ToListAsync();

                return notificaciones;
            }
            catch (Exception ex)
            {
                // Puedes agregar log aquí si quieres, o personalizar la excepción
                throw new Exception("Error al listar notificaciones por contacto: " + ex.Message, ex);
            }
        }
    }
}
