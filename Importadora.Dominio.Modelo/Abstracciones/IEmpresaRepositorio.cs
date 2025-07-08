using Importadora.Infraestructura.AccesoDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Importadora.Dominio.Modelo.Abstracciones
{
    public interface IEmpresaRepositorio : IRepositorio<EMPRESA>
    {
        Task<List<EMPRESA>> ListarEmpresasSinPaginaWeb(); // Método para listar empresas que no tienen página web
    }
}
