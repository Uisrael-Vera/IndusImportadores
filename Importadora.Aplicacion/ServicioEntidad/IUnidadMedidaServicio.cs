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
    public interface IUnidadMedidaServicio
    {
        [OperationContract]
        Task UnidadMedidaAddAsync(UNIDADMEDIDA entidad); //insertar
        [OperationContract]
        Task UnidadMedidaUpdateAsync(UNIDADMEDIDA entidad); //actualizar
        [OperationContract]
        Task UnidadMedidaDeleteAsync(int id); //eliminar
        [OperationContract]
        Task<IEnumerable<UNIDADMEDIDA>> UnidadMedidaGetAllAsync(); //listar (select * from)
        [OperationContract]
        Task<UNIDADMEDIDA> UnidadMedidaGetByIdAsync(int id); //buscar por id
    }
}
