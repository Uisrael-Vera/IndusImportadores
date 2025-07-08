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
    public interface IDetalleVentaServicio
    {
         [OperationContract]
         Task DetalleVentaAddAsync(DETALLEVENTA entidad); //insertar
         [OperationContract]
         Task DetalleVentaUpdateAsync(DETALLEVENTA entidad); //actualizar
         [OperationContract]
         Task DetalleVentaDeleteAsync(int id); //eliminar
         [OperationContract]
         Task<IEnumerable<DETALLEVENTA>> DetalleVentaGetAllAsync(); //listar (select * from)
         [OperationContract]
         Task<DETALLEVENTA> DetalleVentaGetByIdAsync(int id); //buscar por id
    }
}

