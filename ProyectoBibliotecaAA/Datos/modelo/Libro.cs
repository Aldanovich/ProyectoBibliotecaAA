using System.ComponentModel.DataAnnotations;

namespace ProyectoBibliotecaAA.Datos.modelo
{

    public class Libro
    {
        [Key]
        public int IdentificacionLibro { get; set; }
        public int NumeroPagina { get; set; }
        public int FechaPublicacion { get; set; }
        public string Nombre { get; set; }
        public string Categoria { get; set; }
        public string Autor { get; set; }
        public string Editorial { get; set; }

    }
    
}
