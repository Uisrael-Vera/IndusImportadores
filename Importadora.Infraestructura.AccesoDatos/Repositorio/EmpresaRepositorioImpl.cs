using Importadora.Dominio.Modelo.Abstracciones;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Importadora.Infraestructura.AccesoDatos.Repositorio
{
    public class EmpresaRepositorioImpl : RepositorioImpl<EMPRESA>, IEmpresaRepositorio
    {
        private readonly importadoraDBContext _importadoraDBContext;
        public EmpresaRepositorioImpl(importadoraDBContext dBContext) : base(dBContext)
        {
            _importadoraDBContext = dBContext;
        }

        public async Task<List<EMPRESA>> ListarEmpresasSinPaginaWeb()
        {
            
            try
            {
                var resultado = await _importadoraDBContext.EMPRESA.Where(e => e.pagina_web == null).ToListAsync();

                return resultado;
            }
            catch (Exception ex)
            {

                throw new Exception("Error al obtener nombres de contactos: " + ex.Message);
            }
        }
    }
}
