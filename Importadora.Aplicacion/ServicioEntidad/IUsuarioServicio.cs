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
    public interface IUsuarioServicio
    {
        [OperationContract]
        Task UsuarioAddAsync(USUARIO entidad); //insertar
        [OperationContract]
        Task UsuarioUpdateAsync(USUARIO entidad); //actualizar
        [OperationContract]
        Task UsuarioDeleteAsync(int id); //eliminar
        [OperationContract]
        Task<IEnumerable<USUARIO>> UsuarioGetAllAsync(); //listar (select * from)
        [OperationContract]
        Task<USUARIO> UsuarioGetByIdAsync(int id); //buscar por id
    }
}
