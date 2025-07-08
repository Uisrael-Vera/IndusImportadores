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
    public interface IRolServicio
    {
        [OperationContract]
        Task RolAddAsync(ROL entidad); //insertar
        [OperationContract]
        Task RolUpdateAsync(ROL entidad); //actualizar
        [OperationContract]
        Task RolDeleteAsync(int id); //eliminar
        [OperationContract]
        Task<IEnumerable<ROL>> RolGetAllAsync(); //listar (select * from)
        [OperationContract]
        Task<ROL> RolGetByIdAsync(int id); //buscar por id
    }
}
