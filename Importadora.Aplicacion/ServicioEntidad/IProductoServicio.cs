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
    public interface IProductoServicio
    {
        [OperationContract]
        Task ProductoAddAsync(PRODUCTO entidad); //insertar
        [OperationContract]
        Task ProductoUpdateAsync(PRODUCTO entidad); //actualizar
        [OperationContract]
        Task ProductoDeleteAsync(int id); //eliminar
        [OperationContract]
        Task<IEnumerable<PRODUCTO>> ProductoGetAllAsync(); //listar (select * from)
        [OperationContract]
        Task<PRODUCTO> ProductoGetByIdAsync(int id); //buscar por id
    }
}
