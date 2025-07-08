using Importadora.Aplicacion.ServicioEntidad;
using Importadora.Aplicacion.ServicioImpl;
using Importadora.Dominio.Modelo.Abstracciones;
using Importadora.Infraestructura.AccesoDatos;
using Importadora.Infraestructura.AccesoDatos.Repositorio;
using Microsoft.EntityFrameworkCore;

namespace TestImportadoraAPI
{
    public class Tests
    {
        private IActividadServicio _actividadServicio;
        private IContactoServicio? _contactoServicio;
        private importadoraDBContext _importadoraDBContext;
        private IUsuarioRepositorio _usuarioRepositorio;
        private IEmpresaRepositorio _empresaRepositorio;
        private INotificacionRepositorio _notificacionRepositorio;
        private IProductoRepositorio _productoRepositorio;
        private IVentaRepositorio _ventaRepositorio;
        private ITipoVentaRepositorio _tipoVentaRepositorio;

        [SetUp]
        public void Setup()
        {
            var options = new DbContextOptionsBuilder<importadoraDBContext>()
                .UseSqlServer("Data Source=LAPTOP-OOU6HUV7;Initial Catalog=GestionComercialDB;Integrated Security=True; TrustServerCertificate= True")
                .Options;
            _importadoraDBContext = new importadoraDBContext(options);
            //_actividadServicio = new ActividadServicioImpl(_importadoraDBContext);
            _contactoServicio = new ContactoServicioImpl(_importadoraDBContext);
            _usuarioRepositorio = new UsuarioRepositorioImpl(_importadoraDBContext);
            _empresaRepositorio = new EmpresaRepositorioImpl(_importadoraDBContext);
            _notificacionRepositorio = new NotificacionRepositorioImpl(_importadoraDBContext);
            _productoRepositorio = new ProductoRepositotioImpl(_importadoraDBContext);
            _ventaRepositorio = new VentaRepositorioImpl(_importadoraDBContext);
            _tipoVentaRepositorio = new TipoVentaRepositorio(_importadoraDBContext);
        }

        [Test]
        public async Task ConsultarNombresEmpresas()
        {
           /* var actividad = new ACTIVIDAD { nombre = "dsd", detalles = "dsfsdf" };
            await _actividadServicio.ActividadAddAsync(actividad);*/
            //Assert.Pass();

            var resultado = await _contactoServicio.ListarContactosEmpresa();
            foreach (var nombreEmpresa in resultado)
            {
                Console.WriteLine($"{nombreEmpresa.nombre}");
            }
            
        }

        [Test]

        public async Task ConsultarUsuariosActivos()
        {
            
            var resultado = await _usuarioRepositorio.ListarUsuariosActivos();
            foreach (var usuActivo in resultado)
            {
                Console.WriteLine($"{usuActivo.nombre}");
            }

        }
        [Test]
        public async Task ConsultarEmpresasSinPaginaWeb()
        {

            var resultado = await _empresaRepositorio.ListarEmpresasSinPaginaWeb();
            foreach (var empresas in resultado)
            {
                Console.WriteLine($"{empresas.nombre}");
            }

        }
        [Test]
        public async Task ListarNotificacionesPorContacto()
        {

            int idContacto = 1; // Reemplaza con un ID válido según tu base de datos

            //llama al método con el ID
            var resultado = await _notificacionRepositorio.ListarNotificacionesPorContacto(idContacto);

            // Assert: asegura que la lista no sea nula
            Assert.IsNotNull(resultado);

            // imprime las notificaciones del contacto
            foreach (var notificacion in resultado)
            {
                Console.WriteLine($"Notificación: {notificacion.nombre}, Fecha: {notificacion.fecha_programada}");
            }

        }

        [Test]
        public async Task ListarProductosPorPrecio()
        {

            var resultado = await _productoRepositorio.ListarProductosPorPrecio();

            foreach (var item in resultado)
            {
                Console.WriteLine(item); // Imprime el objeto 
            }

            Assert.IsNotNull(resultado);

        }

        [Test]
        public async Task ListarVentasConDetalles()
        {

            var resultado = await _ventaRepositorio.ListarVentasConDetalle();

            foreach (var item in resultado)
            {
                Console.WriteLine(item); // Imprime los detalles de la venta
            }

            Assert.IsNotNull(resultado);

        }

        [Test]
        public async Task UsuariosRoles()
        {

            var resultado = await _usuarioRepositorio.ListarUsuariosConEmpresasAsignadas();

            foreach (var item in resultado)
            {
                Console.WriteLine(item); // Si necesitas ver detalles, puedo adaptarlo a dynamic
            }

            Assert.IsNotNull(resultado);

        }

        [Test]
        public async Task ListarHistorialDePrecios()
        {

            var resultado = await _productoRepositorio.ListarHistorialDePrecios();

            foreach (var item in resultado)
            {
                Console.WriteLine(item); // Imprime el historial de precios del producto
            }

            Assert.IsNotNull(resultado);

        }

        [Test]
        public async Task ListarTiposVenta()
        {

            var resultado = await _tipoVentaRepositorio.ListarTiposVenta();

            foreach (var item in resultado)
            {
                Console.WriteLine(item); // Imprime el historial de precios del producto
            }

            Assert.IsNotNull(resultado);

        }

        [Test]
        public async Task ListarVentasTotalesPorEmpresa()
        {

            var resultado = await _ventaRepositorio.ListarVentasTotalesPorEmpresa();

            foreach (var item in resultado)
            {
                Console.WriteLine(item); // Imprime ventas totales por empresa
            }

            Assert.IsNotNull(resultado);

        }
        [TearDown]
        public void DespuesTest()
        {
            _importadoraDBContext.Dispose();
        }
    }
}