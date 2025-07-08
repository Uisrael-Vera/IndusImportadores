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
    public interface IEmpresaServicio
    {
        [OperationContract]
        Task EmpresaAddAsync(EMPRESA entidad); //insertar
        [OperationContract]
        Task EmpresaUpdateAsync(EMPRESA entidad); //actualizar
        [OperationContract]
        Task EmpresaDeleteAsync(int id); //eliminar
        [OperationContract]
        Task<IEnumerable<EMPRESA>> EmpresaGetAllAsync(); //listar (select * from)
        [OperationContract]
        Task<EMPRESA> EmpresaGetByIdAsync(int id); //buscar por id
    }
}
