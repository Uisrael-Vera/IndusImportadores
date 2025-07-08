using Importadora.Dominio.Modelo.Abstracciones;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Importadora.Infraestructura.AccesoDatos.Repositorio
{
    public class ContactoRepositorioImpl : RepositorioImpl<CONTACTO>, IContactoRepositorio
    {
        private readonly importadoraDBContext _importadoraDBContext;
        public ContactoRepositorioImpl(importadoraDBContext dBContext) : base(dBContext)
        {
            _importadoraDBContext = dBContext;
        }

        public async Task<List<CONTACTO>> ListarContactosEmpresa()
        {
           

            // Esta consulta obtiene la informacion de nombre de los contactos 
            try
            {
                var resultado = await _importadoraDBContext.CONTACTO.Where(c => c.nombre != null).ToListAsync();

       
                return resultado;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener nombres de contactos: " + ex.Message);
            }
        }
    }
}
