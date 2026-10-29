using Microsoft.AspNetCore.Mvc;

namespace API_JEAC_PROYECTO_FINAL.Controllers
{
    public class AsignacionDeHorariosExposicionesController : ControllerBase
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost("AsignarExposicion")]
        public IActionResult AsignarExposicion(int idGrupo, int idEvaluador1, int idEvaluador2, string nombreEvaluador1, string nombreEvaluador2)
        {
            // Lógica para asignar la exposición a los evaluadores
            // Aquí puedes implementar la lógica para verificar la disponibilidad de los evaluadores y asignarles la exposición
            // Ejemplo de respuesta
            return Ok(new { mensaje = "Exposición asignada correctamente." });
        }
        [HttpGet("ObtenerExposicion")]
        public IActionResult ObtenerExposicion(int idGrupo)
        {
            // Lógica para obtener la exposición asignada al grupo
            // Ejemplo de respuesta
            return Ok(new { mensaje = "Exposición obtenida correctamente." });
        }
        [HttpGet("ObtenerEvaluadoresDisponibles")]
        public IActionResult ObtenerEvaluadoresDisponibles()
        {
            // Lógica para obtener los evaluadores disponibles
            // Ejemplo de respuesta
            return Ok(new { mensaje = "Evaluadores disponibles obtenidos correctamente." });
        }
        [HttpDelete("EliminarExposicion")]
        public IActionResult EliminarExposicion(int idGrupo)
        {
            // Lógica para eliminar la exposición asignada al grupo
            // Ejemplo de respuesta
            return Ok(new { mensaje = "Exposición eliminada correctamente." });
        }
        [HttpPut("ActualizarExposicion")]
        public IActionResult ActualizarExposicion(int idGrupo, int idEvaluador1, int idEvaluador2, string nombreEvaluador1, string nombreEvaluador2)
        {
            // Lógica para actualizar la exposición asignada al grupo
            // Ejemplo de respuesta
            return Ok(new { mensaje = "Exposición actualizada correctamente." });
        }
        [HttpGet("BuscarPorID/Nombre")]
        public IActionResult BuscarPorIDNombre(int idGrupo, string nombreEvaluador)
        {
            // Lógica para buscar la exposición asignada al grupo por ID y nombre del evaluador
            // Ejemplo de respuesta
            return Ok(new { mensaje = "Exposición encontrada correctamente." });
        }
    }
}
