using System.ComponentModel.DataAnnotations;

namespace ProyectoBibliotecaAA.Datos.modelo
{
    public class Estudiante
    {
        [Key]
        public int Identificacion { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Carrera { get; set; }
        public int Grado { get; set; }
        public int Edad { get; set; }
    }
}
