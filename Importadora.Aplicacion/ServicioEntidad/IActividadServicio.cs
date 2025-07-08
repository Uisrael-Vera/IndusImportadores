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
    public interface IActividadServicio
    {        
        [OperationContract]
        Task ActividadAddAsync(ACTIVIDAD entidad); //insertar
        [OperationContract]
        Task ActividadUpdateAsync(ACTIVIDAD entidad); //actualizar
        [OperationContract]
        Task ActividadDeleteAsync(int id); //eliminar
        [OperationContract]
        Task<IEnumerable<ACTIVIDAD>> ActividadGetAllAsync(); //listar (select * from)
        [OperationContract]
        Task<ACTIVIDAD> ActividadGetByIdAsync(int id); //buscar por id
    }
}
