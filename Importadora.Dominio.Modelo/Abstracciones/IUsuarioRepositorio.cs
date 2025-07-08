using Importadora.Infraestructura.AccesoDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Importadora.Dominio.Modelo.Abstracciones
{
    public interface IUsuarioRepositorio : IRepositorio<USUARIO>
    {
        Task<List<USUARIO>> ListarUsuariosActivos(); // Método para listar usuarios activos

        Task<List<USUARIO>> ListarUsuariosConEmpresasAsignadas(); // Método para listar usuarios con empresas asignadas
    }
}
