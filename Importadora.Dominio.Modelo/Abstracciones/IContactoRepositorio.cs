using Importadora.Infraestructura.AccesoDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Importadora.Dominio.Modelo.Abstracciones
{
    public interface IContactoRepositorio : IRepositorio<CONTACTO>
    {
        Task<List<CONTACTO>> ListarContactosEmpresa(); // listar contactos de la empresa
    }
}
