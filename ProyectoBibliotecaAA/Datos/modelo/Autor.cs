using System.ComponentModel.DataAnnotations;

namespace ProyectoBibliotecaHD.Datos.modelo
{
    public class Autor
    {
        [Key]
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Pais { get; set; }

    }
}
