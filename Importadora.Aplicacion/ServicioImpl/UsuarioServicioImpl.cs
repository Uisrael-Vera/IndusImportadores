using Importadora.Aplicacion.ServicioEntidad;
using Importadora.Dominio.Modelo.Abstracciones;
using Importadora.Infraestructura.AccesoDatos;
using Importadora.Infraestructura.AccesoDatos.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Importadora.Aplicacion.ServicioImpl
{
    public class UsuarioServicioImpl : IUsuarioServicio
    {
        private IUsuarioRepositorio _usuarioRepositorio;
        private readonly importadoraDBContext _dbContext;

        public UsuarioServicioImpl(importadoraDBContext dbContext)
        {
            this._dbContext = dbContext;
            _usuarioRepositorio = new UsuarioRepositorioImpl(_dbContext);
        }
        public async Task UsuarioAddAsync(USUARIO entidad)
        {
            await _usuarioRepositorio.AddAsync(entidad);
        }

        public async Task UsuarioDeleteAsync(int id)
        {
            await _usuarioRepositorio.DeleteAsync(id);
        }

        public Task<IEnumerable<USUARIO>> UsuarioGetAllAsync()
        {
            return _usuarioRepositorio.GetAllAsync();
        }

        public Task<USUARIO> UsuarioGetByIdAsync(int id)
        {
            return _usuarioRepositorio.GetByIdAsync(id);
        }

        public async Task UsuarioUpdateAsync(USUARIO entidad)
        {
            await _usuarioRepositorio.UpdateAsync(entidad);
        }
    }
}
