using Importadora.Dominio.Modelo.Abstracciones;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Importadora.Infraestructura.AccesoDatos.Repositorio
{
    public class RepositorioImpl<T> : IRepositorio<T> where T : class
    {
        private readonly importadoraDBContext _dbContext;
        private readonly DbSet<T> _dbSet;
        public RepositorioImpl(importadoraDBContext dBContext) 
        {
            _dbContext = dBContext;
            _dbSet = dBContext.Set<T>();
        }
        public async Task AddAsync(T entidad)
        {
            try
            {
                await _dbSet.AddAsync(entidad); //insert todas las tablas
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Error: No se pudo insertar datos, " + ex.Message);
            }
        }

        public async Task DeleteAsync(int id)
        {
            try
            {
                var entidad = await GetByIdAsync(id);
                _dbSet.Remove(entidad);//eliminar todas las tablas
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Error: No se pudo eliminar datos, " + ex.Message);
            }
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            try
            {
                return await _dbSet.ToListAsync(); //listar todas las tablas
            }
            catch (Exception ex)
            {
                throw new Exception("Error: No se pudo listar datos, " + ex.Message);
            }
        }

        public async Task<T> GetByIdAsync(int id)
        {
            try
            {
                return await _dbSet.FindAsync(id); //buscar todas las tablas or id
            }
            catch (Exception ex)
            {
                throw new Exception("Error: No se pudo buscar datos, " + ex.Message);
            }
        }

        public async Task UpdateAsync(T entidad)
        {
            try
            {
                _dbSet.Update(entidad); //actualizar todas las tablas
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Error: No se pudo actualizar datos, " + ex.Message);
            }
        }
    }
}
