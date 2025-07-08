using Importadora.Infraestructura.AccesoDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Importadora.Dominio.Modelo.Abstracciones
{
    public interface ITipoVentaRepositorio : IRepositorio<TIPOVENTA>
    {
        Task<List<TIPOVENTA>> ListarTiposVenta(); // Método para listar todos los tipos de venta
        
    }
}
