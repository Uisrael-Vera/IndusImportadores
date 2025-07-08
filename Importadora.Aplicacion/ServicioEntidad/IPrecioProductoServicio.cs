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
    public interface IPrecioProductoServicio
    {
        [OperationContract]
        Task PrecioProductoAddAsync(PRECIOPRODUCTO entidad); //insertar
        [OperationContract]
        Task PrecioProductoUpdateAsync(PRECIOPRODUCTO entidad); //actualizar
        [OperationContract]
        Task PrecioProductoDeleteAsync(int id); //eliminar
        [OperationContract]
        Task<IEnumerable<PRECIOPRODUCTO>> PrecioProductoGetAllAsync(); //listar (select * from)
        [OperationContract]
        Task<PRECIOPRODUCTO> PrecioProductoGetByIdAsync(int id); //buscar por id
    }
}

