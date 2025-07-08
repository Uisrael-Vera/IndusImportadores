using Importadora.Dominio.Modelo.Abstracciones;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Importadora.Infraestructura.AccesoDatos.Repositorio
{
    public class UsuarioRepositorioImpl : RepositorioImpl<USUARIO>, IUsuarioRepositorio
    {   private readonly importadoraDBContext _importadoraDBContext;
        public UsuarioRepositorioImpl(importadoraDBContext dBContext) : base(dBContext)
        {
            _importadoraDBContext = dBContext;
        }

        public Task<List<USUARIO>> ListarUsuariosActivos()
        {
            var resultado = _importadoraDBContext.USUARIO.Where(u => u.estado == true).ToListAsync();
            return resultado;
        }

        public async Task<List<USUARIO>> ListarUsuariosConEmpresasAsignadas()
        {
            try
            {
                var resultado = await(
                    from u in _importadoraDBContext.USUARIO
                    join ur in _importadoraDBContext.USUARIO on u.id_usuario equals ur.id_usuario
                    join r in _importadoraDBContext.USUARIO on ur.id_rol equals r.id_rol
                    select new
                    {
                        Usuario = u.nombre,
                        Rol = r.id_rol
                    }
                ).ToListAsync<object>();

                return resultado;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener usuarios : " + ex.Message, ex);
            }
        }
    }
}
