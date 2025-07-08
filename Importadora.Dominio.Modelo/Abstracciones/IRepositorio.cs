using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Importadora.Dominio.Modelo.Abstracciones
{
    public interface IRepositorio<T> where T : class
    {
        Task AddAsync(T entidad); //insertar
        Task UpdateAsync(T entidad); //actualizar
        Task DeleteAsync(int id); //eliminar
        Task<IEnumerable<T>> GetAllAsync(); //listar (select * from)
        Task<T> GetByIdAsync(int id); //buscar por id
    }
}
