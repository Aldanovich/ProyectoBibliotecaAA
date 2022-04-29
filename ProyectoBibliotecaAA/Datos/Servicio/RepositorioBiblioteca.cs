using Microsoft.EntityFrameworkCore;
using ProyectoBibliotecaAA.Datos.modelo;

namespace ProyectoBibliotecaHD.Datos.Servicio
{
    public class RepositorioBiblioteca : DbContext

    {
        public RepositorioBiblioteca(DbContextOptions<RepositorioBiblioteca>options):base(options)
        {

        }
        public DbSet<Libro> Libros { get; set; }
    }
}
