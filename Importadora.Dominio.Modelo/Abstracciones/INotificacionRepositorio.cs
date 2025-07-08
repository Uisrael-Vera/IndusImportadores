using Importadora.Infraestructura.AccesoDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Importadora.Dominio.Modelo.Abstracciones
{
    public interface INotificacionRepositorio : IRepositorio<NOTIFICACION>
    {
        Task<List<NOTIFICACION>> ListarNotificacionesPorContacto(int idContacto); // Método para listar notificaciones por contacto y actividad

        
    }
}
