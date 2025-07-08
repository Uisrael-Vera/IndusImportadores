using Importadora.Dominio.Modelo.Abstracciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Importadora.Infraestructura.AccesoDatos.Repositorio
{
    public class DetalleVentaRepositorioImpl : RepositorioImpl<DETALLEVENTA>, IDetalleVentaRepositorio
    {
        private readonly importadoraDBContext _importadoraDBContext;
        public DetalleVentaRepositorioImpl(importadoraDBContext dBContext) : base(dBContext)
        {
            _importadoraDBContext = dBContext;
        }
    }
}
