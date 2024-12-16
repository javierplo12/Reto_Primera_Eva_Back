using Microsoft.AspNetCore.Mvc;
using Models;
using System.Collections.Generic;
using System.Linq;

namespace Reto_Primera_Eva.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FuncionController : ControllerBase
    {
        public static List<Funcion> funcion = new List<Funcion>();

        static FuncionController()
        {
            InicializarFunciones();
        }

        // Funcion para crear todas las funciones
        public static void InicializarFunciones()
        {
            if (!funcion.Any())
            {
                // Sala 1 - Día 1
                funcion.Add(new Funcion(1, "Sala 1", "1/12", DateTime.Parse("10:00"), 2));
                funcion.Add(new Funcion(2, "Sala 1", "1/12", DateTime.Parse("12:15"), 2));
                funcion.Add(new Funcion(3, "Sala 1", "1/12", DateTime.Parse("14:15"), 2));
                funcion.Add(new Funcion(4, "Sala 1", "1/12", DateTime.Parse("16:30"), 3));
                funcion.Add(new Funcion(5, "Sala 1", "1/12", DateTime.Parse("18:30"), 3));
                funcion.Add(new Funcion(6, "Sala 1", "1/12", DateTime.Parse("20:45"), 3));

                // Sala 2 - Día 1
                funcion.Add(new Funcion(7, "Sala 2", "1/12", DateTime.Parse("10:00"), 4));
                funcion.Add(new Funcion(8, "Sala 2", "1/12", DateTime.Parse("12:15"), 4));
                funcion.Add(new Funcion(9, "Sala 2", "1/12", DateTime.Parse("14:15"), 4));
                funcion.Add(new Funcion(10, "Sala 2", "1/12", DateTime.Parse("16:30"), 5));
                funcion.Add(new Funcion(11, "Sala 2", "1/12", DateTime.Parse("18:30"), 5));
                funcion.Add(new Funcion(12, "Sala 2", "1/12", DateTime.Parse("20:45"), 5));

                // Sala 3 - Día 1
                funcion.Add(new Funcion(13, "Sala 3", "1/12", DateTime.Parse("10:00"), 6));
                funcion.Add(new Funcion(14, "Sala 3", "1/12", DateTime.Parse("12:15"), 6));
                funcion.Add(new Funcion(15, "Sala 3", "1/12", DateTime.Parse("14:15"), 6));
                funcion.Add(new Funcion(16, "Sala 3", "1/12", DateTime.Parse("16:30"), 7));
                funcion.Add(new Funcion(17, "Sala 3", "1/12", DateTime.Parse("18:30"), 7));
                funcion.Add(new Funcion(18, "Sala 3", "1/12", DateTime.Parse("20:45"), 7));

                // Sala 4 - Día 1
                funcion.Add(new Funcion(19, "Sala 4", "1/12", DateTime.Parse("10:00"), 8));
                funcion.Add(new Funcion(20, "Sala 4", "1/12", DateTime.Parse("12:15"), 8));
                funcion.Add(new Funcion(21, "Sala 4", "1/12", DateTime.Parse("14:15"), 8));
                funcion.Add(new Funcion(22, "Sala 4", "1/12", DateTime.Parse("16:30"), 9));
                funcion.Add(new Funcion(23, "Sala 4", "1/12", DateTime.Parse("18:30"), 9));
                funcion.Add(new Funcion(24, "Sala 4", "1/12", DateTime.Parse("20:45"), 9));

                // Sala 5 - Día 1
                funcion.Add(new Funcion(25, "Sala 5", "1/12", DateTime.Parse("10:00"), 1));
                funcion.Add(new Funcion(26, "Sala 5", "1/12", DateTime.Parse("14:15"), 1));
                funcion.Add(new Funcion(27, "Sala 5", "1/12", DateTime.Parse("18:30"), 1));

                // Sala 1 - Día 2
                funcion.Add(new Funcion(28, "Sala 1", "2/12", DateTime.Parse("10:00"), 9));
                funcion.Add(new Funcion(29, "Sala 1", "2/12", DateTime.Parse("12:15"), 9));
                funcion.Add(new Funcion(30, "Sala 1", "2/12", DateTime.Parse("14:15"), 9));
                funcion.Add(new Funcion(31, "Sala 1", "2/12", DateTime.Parse("16:30"), 8));
                funcion.Add(new Funcion(32, "Sala 1", "2/12", DateTime.Parse("18:30"), 8));
                funcion.Add(new Funcion(33, "Sala 1", "2/12", DateTime.Parse("20:45"), 8));

                // Sala 2 - Día 2
                funcion.Add(new Funcion(34, "Sala 2", "2/12", DateTime.Parse("10:00"), 7));
                funcion.Add(new Funcion(35, "Sala 2", "2/12", DateTime.Parse("12:15"), 7));
                funcion.Add(new Funcion(36, "Sala 2", "2/12", DateTime.Parse("14:15"), 7));
                funcion.Add(new Funcion(37, "Sala 2", "2/12", DateTime.Parse("16:30"), 6));
                funcion.Add(new Funcion(38, "Sala 2", "2/12", DateTime.Parse("18:30"), 6));
                funcion.Add(new Funcion(39, "Sala 2", "2/12", DateTime.Parse("20:45"), 6));

                // Sala 3 - Día 2
                funcion.Add(new Funcion(40, "Sala 3", "2/12", DateTime.Parse("10:00"), 5));
                funcion.Add(new Funcion(41, "Sala 3", "2/12", DateTime.Parse("12:15"), 5));
                funcion.Add(new Funcion(42, "Sala 3", "2/12", DateTime.Parse("14:15"), 5));
                funcion.Add(new Funcion(43, "Sala 3", "2/12", DateTime.Parse("16:30"), 4));
                funcion.Add(new Funcion(44, "Sala 3", "2/12", DateTime.Parse("18:30"), 4));
                funcion.Add(new Funcion(45, "Sala 3", "2/12", DateTime.Parse("20:45"), 4));

                // Sala 4 - Día 2
                funcion.Add(new Funcion(46, "Sala 4", "2/12", DateTime.Parse("10:00"), 3));
                funcion.Add(new Funcion(47, "Sala 4", "2/12", DateTime.Parse("12:15"), 3));
                funcion.Add(new Funcion(48, "Sala 4", "2/12", DateTime.Parse("14:15"), 3));
                funcion.Add(new Funcion(49, "Sala 4", "2/12", DateTime.Parse("16:30"), 1));
                funcion.Add(new Funcion(50, "Sala 4", "2/12", DateTime.Parse("18:30"), 1));
                funcion.Add(new Funcion(51, "Sala 4", "2/12", DateTime.Parse("20:45"), 1));

                // Sala 5 - Día 2
                funcion.Add(new Funcion(52, "Sala 5", "2/12", DateTime.Parse("10:00"), 2));
                funcion.Add(new Funcion(53, "Sala 5", "2/12", DateTime.Parse("14:15"), 2));
                funcion.Add(new Funcion(54, "Sala 5", "2/12", DateTime.Parse("18:30"), 2));

                // Sala 1 - Día 3
                funcion.Add(new Funcion(55, "Sala 1", "3/12", DateTime.Parse("10:00"), 4));
                funcion.Add(new Funcion(56, "Sala 1", "3/12", DateTime.Parse("12:15"), 4));
                funcion.Add(new Funcion(57, "Sala 1", "3/12", DateTime.Parse("14:15"), 4));
                funcion.Add(new Funcion(58, "Sala 1", "3/12", DateTime.Parse("16:30"), 7));
                funcion.Add(new Funcion(59, "Sala 1", "3/12", DateTime.Parse("18:30"), 7));
                funcion.Add(new Funcion(60, "Sala 1", "3/12", DateTime.Parse("20:45"), 7));

                // Sala 2 - Día 3
                funcion.Add(new Funcion(61, "Sala 2", "3/12", DateTime.Parse("10:00"), 9));
                funcion.Add(new Funcion(62, "Sala 2", "3/12", DateTime.Parse("12:15"), 9));
                funcion.Add(new Funcion(63, "Sala 2", "3/12", DateTime.Parse("14:15"), 9));
                funcion.Add(new Funcion(64, "Sala 2", "3/12", DateTime.Parse("16:30"), 2));
                funcion.Add(new Funcion(65, "Sala 2", "3/12", DateTime.Parse("18:30"), 2));
                funcion.Add(new Funcion(66, "Sala 2", "3/12", DateTime.Parse("20:45"), 2));

                // Sala 3 - Día 3
                funcion.Add(new Funcion(67, "Sala 3", "3/12", DateTime.Parse("10:00"), 8));
                funcion.Add(new Funcion(68, "Sala 3", "3/12", DateTime.Parse("12:15"), 8));
                funcion.Add(new Funcion(69, "Sala 3", "3/12", DateTime.Parse("14:15"), 8));
                funcion.Add(new Funcion(70, "Sala 3", "3/12", DateTime.Parse("16:30"), 6));
                funcion.Add(new Funcion(71, "Sala 3", "3/12", DateTime.Parse("18:30"), 6));
                funcion.Add(new Funcion(72, "Sala 3", "3/12", DateTime.Parse("20:45"), 6));

                // Sala 4 - Día 3
                funcion.Add(new Funcion(73, "Sala 4", "3/12", DateTime.Parse("10:00"), 5));
                funcion.Add(new Funcion(74, "Sala 4", "3/12", DateTime.Parse("12:15"), 5));
                funcion.Add(new Funcion(75, "Sala 4", "3/12", DateTime.Parse("14:15"), 5));
                funcion.Add(new Funcion(76, "Sala 4", "3/12", DateTime.Parse("16:30"), 3));
                funcion.Add(new Funcion(77, "Sala 4", "3/12", DateTime.Parse("18:30"), 3));
                funcion.Add(new Funcion(78, "Sala 4", "3/12", DateTime.Parse("20:45"), 3));

                // Sala 5 - Día 3
                funcion.Add(new Funcion(79, "Sala 5", "3/12", DateTime.Parse("10:00"), 1));
                funcion.Add(new Funcion(80, "Sala 5", "3/12", DateTime.Parse("14:15"), 1));
                funcion.Add(new Funcion(81, "Sala 5", "3/12", DateTime.Parse("18:30"), 1));

            }
        }

        // Obtiene todas las funciones
        [HttpGet]
        public ActionResult<IEnumerable<Funcion>> GetFuncion()
        {
            return Ok(funcion);
        }

        // Obtiene una función por ID
        [HttpGet("{id}")]
        public ActionResult<Funcion> GetFuncionById(int id)
        {
            var funcionExistente = funcion.FirstOrDefault(f => f.Id == id);

            if (funcionExistente == null)
            {
                return NotFound("Función no encontrada.");
            }

            return Ok(funcionExistente);
        }


        // Añade una nueva función
        [HttpPost]
        public ActionResult<Funcion> AddFuncion(Funcion nuevaFuncion)
        {
            if (nuevaFuncion == null)
            {
                return BadRequest("La función no puede ser nula.");
            }

            nuevaFuncion.Id = funcion.Any() ? funcion.Max(f => f.Id) + 1 : 1;
            funcion.Add(nuevaFuncion);
            return CreatedAtAction(nameof(GetFuncionById), new { id = nuevaFuncion.Id }, nuevaFuncion);
        }

        // Actualiza una función existente por ID
        [HttpPut("{id}")]
        public ActionResult UpdateFuncion(int id, Funcion actualizadaFuncion)
        {
            var funcionExistente = funcion.FirstOrDefault(f => f.Id == id);

            if (funcionExistente == null)
            {
                return NotFound("Función no encontrada.");
            }

            funcionExistente.Sala = actualizadaFuncion.Sala;
            funcionExistente.Dia = actualizadaFuncion.Dia;
            funcionExistente.Hora = actualizadaFuncion.Hora;

            return NoContent();
        }

        [HttpPut("{id}/butacas")]
        public ActionResult ActualizarButacas(int id, [FromBody] List<Butaca> butacasActualizadas)
        {
            // Busca la función con el ID especificado
            var funcionExistente = funcion.FirstOrDefault(f => f.Id == id);

            if (funcionExistente == null)
            {
                return NotFound("Función no encontrada.");
            }

            // Recorre las butacas enviadas en el cuerpo de la solicitud
            foreach (var butacaActualizada in butacasActualizadas)
            {
                // Busca la butaca por su nombre en la función existente
                var butacaExistente = funcionExistente.Butacas.FirstOrDefault(b => b.Nombre == butacaActualizada.Nombre);

                if (butacaExistente != null)
                {
                    // Actualiza el estado de la butaca
                    butacaExistente.EstaOcupada = butacaActualizada.EstaOcupada;
                }
                else
                {
                    // Si la butaca no existe, devuelve un error
                    return BadRequest($"La butaca '{butacaActualizada.Nombre}' no existe en la función.");
                }
            }

            return Ok(new { mensaje = "Estados de butacas actualizados correctamente." });
        }



        // Elimina una función existente por ID
        [HttpDelete("{id}")]
        public ActionResult DeleteFuncion(int id)
        {
            var funcionExistente = funcion.FirstOrDefault(f => f.Id == id);

            if (funcionExistente == null)
            {
                return NotFound("Función no encontrada.");
            }

            funcion.Remove(funcionExistente);
            return NoContent();
        }

        [HttpGet("pelicula/{idPelicula}/funciones")]
        public IActionResult GetFuncionesPorPelicula(int idPelicula, [FromQuery] string dia = null)
        {
            var funciones = funcion.Where(f => f.IdPelicula == idPelicula);

            if (!string.IsNullOrEmpty(dia))
            {
                funciones = funciones.Where(f => f.Dia == dia);
            }

            return Ok(funciones);
        }


    }
}
