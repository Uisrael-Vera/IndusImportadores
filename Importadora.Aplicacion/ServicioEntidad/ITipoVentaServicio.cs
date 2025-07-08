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
    public interface ITipoVentaServicio
    {
        [OperationContract]
        Task TipoVentaAddAsync(TIPOVENTA entidad); //insertar
        [OperationContract]
        Task TipoVentaUpdateAsync(TIPOVENTA entidad); //actualizar
        [OperationContract]
        Task TipoVentaDeleteAsync(int id); //eliminar
        [OperationContract]
        Task<IEnumerable<TIPOVENTA>> TipoVentaGetAllAsync(); //listar (select * from)
        [OperationContract]
        Task<TIPOVENTA> TipoVentaGetByIdAsync(int id); //buscar por id
    }
}
