using Microsoft.AspNetCore.Mvc;

namespace API_JEAC_PROYECTO_FINAL.Controllers
{
    public class AsignacionDeHorariosExposicionesController : ControllerBase
    {
        private static readonly List<HorarioExposicion> ListaHorariosExposicion = new();

        [HttpPost("AsignarExposicion")]
        public IActionResult AsignarExposicion(int idGrupo, string nombreEvaluador1, string nombreEvaluador2,string Hora)
        {
            var exposicionExistente = ListaHorariosExposicion
                .FirstOrDefault(e => e.IdGrupo == idGrupo);

            if (exposicionExistente is not null)
            {
                return Conflict(new
                {
                    mensaje = "El grupo ya tiene una exposición asignada."
                });
            }

            ListaHorariosExposicion.Add(new HorarioExposicion
            {
                IdGrupo = idGrupo,
                NombreEvaluador1 = nombreEvaluador1,
                NombreEvaluador2 = nombreEvaluador2,
                Hora = Hora
            });

            return Ok(new { mensaje = "Exposición asignada correctamente." });
        }
        [HttpGet("ObtenerExposicion")]
        public IActionResult ObtenerExposicion(int idGrupo)
        {
            foreach (var exposicion in ListaHorariosExposicion)
            {
                if (exposicion.IdGrupo == idGrupo)
                {
                    return Ok(new
                    {
                        IdGrupo = exposicion.IdGrupo,
                        NombreEvaluador1 = exposicion.NombreEvaluador1,
                        NombreEvaluador2 = exposicion.NombreEvaluador2,
                        Hora = exposicion.Hora
                    });
                }
            }

            return NotFound(new { mensaje = "No se encontró una exposición para el grupo indicado." });
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
            var exposicion = ListaHorariosExposicion.FirstOrDefault(e => e.IdGrupo == idGrupo);

            if (exposicion is null)
            {
                return NotFound(new
                {
                    mensaje = "No se encontró una exposición para el grupo indicado."
                });
            }

            ListaHorariosExposicion.Remove(exposicion);

            return Ok(new { mensaje = "Exposición eliminada correctamente." });
        }
        [HttpPut("ActualizarExposicion")]
        public IActionResult ActualizarExposicion(int idGrupo, string nombreEvaluador1, string nombreEvaluador2, string Hora)
        {
            var exposicion = ListaHorariosExposicion.FirstOrDefault(e => e.IdGrupo == idGrupo);

            if (exposicion is null)
            {
                return NotFound(new
                {
                    mensaje = "No se encontró una exposición para el grupo indicado."
                });
            }

            exposicion.NombreEvaluador1 = nombreEvaluador1;
            exposicion.NombreEvaluador2 = nombreEvaluador2;
            exposicion.Hora = Hora;

            return Ok(new { mensaje = "Exposición actualizada correctamente." });
        }
        [HttpGet("BuscarPorNombreEvaluador")]
        public IActionResult BuscarPorNombreEvaluador(string nombreEvaluador)
        {
            // Obtiene la lista completa de exposiciones guardadas.
            var exposiciones = ListaHorariosExposicion
                // Filtra las exposiciones donde el nombre coincide con el evaluador recibido.
                .Where(e => string.Equals(e.NombreEvaluador1, nombreEvaluador, StringComparison.OrdinalIgnoreCase)
                         // También comprueba si el evaluador aparece como segundo evaluador.
                         || string.Equals(e.NombreEvaluador2, nombreEvaluador, StringComparison.OrdinalIgnoreCase))
                // Convierte el resultado filtrado en una lista.
                .ToList();

            return Ok(exposiciones);
        }
        [HttpGet("lista de exposiciones")]
        public IActionResult ObtenerListaExposiciones()
        {
            return Ok(ListaHorariosExposicion);
        }

    }
}
