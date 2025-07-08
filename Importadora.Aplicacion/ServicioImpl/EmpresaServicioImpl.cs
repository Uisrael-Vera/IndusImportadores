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
    public class EmpresaServicioImpl : IEmpresaServicio
    {
        private IEmpresaRepositorio _empresaRepositorio;
        private readonly importadoraDBContext _dbContext;

        public EmpresaServicioImpl(importadoraDBContext dbContext)
        {
            this._dbContext = dbContext;
            _empresaRepositorio = new EmpresaRepositorioImpl(_dbContext);
        }
        public async Task EmpresaAddAsync(EMPRESA entidad)
        {
            await _empresaRepositorio.AddAsync(entidad);
        }

        public async Task EmpresaDeleteAsync(int id)
        {
            await _empresaRepositorio.DeleteAsync(id);
        }

        public Task<IEnumerable<EMPRESA>> EmpresaGetAllAsync()
        {
            return _empresaRepositorio.GetAllAsync();
        }

        public Task<EMPRESA> EmpresaGetByIdAsync(int id)
        {
            return _empresaRepositorio.GetByIdAsync(id);
        }

        public async Task EmpresaUpdateAsync(EMPRESA entidad)
        {
            await _empresaRepositorio.UpdateAsync(entidad);
        }
    }
}
