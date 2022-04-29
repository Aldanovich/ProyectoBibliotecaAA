
using Microsoft.AspNetCore.Mvc;

namespace ProyectoBibliotecaAA.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class BibliotecaController:ControllerBase
    {
        public string PropiedadBiblioteca { get; set; }

        public BibliotecaController()
        {
            //constructor
        }
        public string ObtenerLibro()
        {
            return "El libro fue obtenido correctamente";
        }
        public string AgregarLibro()
        {
            return "El libro fue agregado correctamente";
        }
        public string ActualizarLibro()
        {
            return "El libro fue actualizado correctamente";
        }
        public string EliminarLibro()
        {
            return "El libro fue elimindo correctamente";
        }
        public string ObtenerEstudiante()
        {
            return "El estudiante fue obtenido correctamente";
        }
        public string AgregarEstudiante()
        {
            return "El estudiante fue agregado correctamente";
        }
        public string ActualizarEstudiante()
        {
            return "El estudiante fue actualizado correctamente";
        }
        public string EliminarEstudiante()
        {
            return "El estudiante fue eliminado correctamente";
        }
        public string ObtenerAutor()
        {
            return "El autor fue obtenido correctamente";
        }
        public string AgregarAutor()
        {
            return "El autor fue agregado correctamente";
        }
        public string ActualizarAutor()
        {
            return "El autor fue actualizado correctamente";
        }
        public string EliminarAutor()
        {
            return "El autor fue eliminado correctamente";
        }
        public string ObtenerPrestamo()
        {
            return "El prestamo fue obtenido correctamente";
        }
        public string AgregarPrestamo()
        {
            return "El prestamo fue agregado correctamente";
        }
        public string ActualizarPrestamo()
        {
            return "El prestamo fue actualizado correctamente";
        }
        public string EliminarPrestamo()
        {
            return "El prestamo fue eliminado correctamente";
        }
    }
}
