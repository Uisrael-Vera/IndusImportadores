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
    public class ContactoServicioImpl : IContactoServicio
    {
        private IContactoRepositorio _contactoRepositorio;
        private readonly importadoraDBContext _dbContext;

        public ContactoServicioImpl(importadoraDBContext dbContext)
        {
            this._dbContext = dbContext;
            _contactoRepositorio = new ContactoRepositorioImpl(_dbContext);
        }

        public async Task ContactoAddAsync(CONTACTO entidad)
        {
            await _contactoRepositorio.AddAsync(entidad);
        }

        public async Task ContactoDeleteAsync(int id)
        {
            await _contactoRepositorio.DeleteAsync(id);
        }

        public Task<IEnumerable<CONTACTO>> ContactoGetAllAsync()
        {
            return _contactoRepositorio.GetAllAsync();
        }

        public Task<CONTACTO> ContactoGetByIdAsync(int id)
        {
            return _contactoRepositorio.GetByIdAsync(id);
        }

        public async Task ContactoUpdateAsync(CONTACTO entidad)
        {
            await _contactoRepositorio.UpdateAsync(entidad);
        }

        public  Task<List<CONTACTO>> ListarContactosEmpresa()
        {
            return _contactoRepositorio.ListarContactosEmpresa();
        }
    }
}
