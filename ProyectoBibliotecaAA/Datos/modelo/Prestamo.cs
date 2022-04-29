using System.ComponentModel.DataAnnotations;

namespace ProyectoBibliotecaHD.Datos.modelo
{
    public class Prestamo
    {
        [Key]
        public int Id { get; set; }
        public int IdentificacionLibro { get; set; }
        public int Fecha { get; set; }
        public int IdEstudiante { get; set; }
    }
}
