using Importadora.Infraestructura.AccesoDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Importadora.Aplicacion.ServicioEntidad
{
    [ServiceContract]
    public interface INotificacionServicio
    {
        [OperationContract]
        Task NotificacionAddAsync(NOTIFICACION entidad); //insertar
        [OperationContract]
        Task NotificacionUpdateAsync(NOTIFICACION entidad); //actualizar
        [OperationContract]
        Task NotificacionDeleteAsync(int id); //eliminar
        [OperationContract]
        Task<IEnumerable<NOTIFICACION>> NotificacionGetAllAsync(); //listar (select * from)
        [OperationContract]
        Task<NOTIFICACION> NotificacionGetByIdAsync(int id); //buscar por id
        
    }
}
