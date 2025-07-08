using Importadora.Dominio.Modelo.Abstracciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Importadora.Infraestructura.AccesoDatos.Repositorio
{
    public class PrecioProductoRepositorioImpl : RepositorioImpl<PRECIOPRODUCTO>, IPrecioProductoRepositorio
    {
        public PrecioProductoRepositorioImpl(importadoraDBContext dBContext) : base(dBContext)
        {
        }
    }
}
