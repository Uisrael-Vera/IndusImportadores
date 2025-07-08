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
    public interface IContactoServicio
    {
        [OperationContract]
        Task ContactoAddAsync(CONTACTO entidad); //insertar
        [OperationContract]
        Task ContactoUpdateAsync(CONTACTO entidad); //actualizar
        [OperationContract]
        Task ContactoDeleteAsync(int id); //eliminar
        [OperationContract]
        Task<IEnumerable<CONTACTO>> ContactoGetAllAsync(); //listar (select * from)
        [OperationContract]
        Task<CONTACTO> ContactoGetByIdAsync(int id); //buscar por id

        [OperationContract]
        public Task<List<CONTACTO>> ListarContactosEmpresa();
    }
}
