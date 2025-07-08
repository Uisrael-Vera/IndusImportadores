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
    public interface IVentaServicio
    {
        [OperationContract]
        Task VentaAddAsync(VENTA entidad); //insertar
        [OperationContract]
        Task VentaUpdateAsync(VENTA entidad); //actualizar
        [OperationContract]
        Task VentaDeleteAsync(int id); //eliminar
        [OperationContract]
        Task<IEnumerable<VENTA>> VentaGetAllAsync(); //listar (select * from)
        [OperationContract]
        Task<VENTA> VentaGetByIdAsync(int id); //buscar por id
    }
}
