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
                funcion.Add(new Funcion(1, "Sala 1", "1/12", DateTime.Today.AddHours(10).AddMinutes(0)));
                funcion.Add(new Funcion(2, "Sala 1", "1/12", DateTime.Parse("12:15")));
                funcion.Add(new Funcion(3, "Sala 1", "1/12", DateTime.Parse("14:15")));
                funcion.Add(new Funcion(4, "Sala 1", "1/12", DateTime.Parse("16:30")));
                funcion.Add(new Funcion(5, "Sala 1", "1/12", DateTime.Parse("18:30")));
                funcion.Add(new Funcion(6, "Sala 1", "1/12", DateTime.Parse("20:45")));

                // Sala 2 - Día 1
                funcion.Add(new Funcion(7, "Sala 2", "1/12", DateTime.Parse("10:00")));
                funcion.Add(new Funcion(8, "Sala 2", "1/12", DateTime.Parse("12:15")));
                funcion.Add(new Funcion(9, "Sala 2", "1/12", DateTime.Parse("14:15")));
                funcion.Add(new Funcion(10, "Sala 2", "1/12", DateTime.Parse("16:30")));
                funcion.Add(new Funcion(11, "Sala 2", "1/12", DateTime.Parse("18:30")));
                funcion.Add(new Funcion(12, "Sala 2", "1/12", DateTime.Parse("20:45")));

                // Sala 3 - Día 1
                funcion.Add(new Funcion(13, "Sala 3", "1/12", DateTime.Parse("10:00")));
                funcion.Add(new Funcion(14, "Sala 3", "1/12", DateTime.Parse("12:15")));
                funcion.Add(new Funcion(15, "Sala 3", "1/12", DateTime.Parse("14:15")));
                funcion.Add(new Funcion(16, "Sala 3", "1/12", DateTime.Parse("16:30")));
                funcion.Add(new Funcion(17, "Sala 3", "1/12", DateTime.Parse("18:30")));
                funcion.Add(new Funcion(18, "Sala 3", "1/12", DateTime.Parse("20:45")));

                // Sala 4 - Día 1
                funcion.Add(new Funcion(19, "Sala 4", "1/12", DateTime.Parse("10:00")));
                funcion.Add(new Funcion(20, "Sala 4", "1/12", DateTime.Parse("12:15")));
                funcion.Add(new Funcion(21, "Sala 4", "1/12", DateTime.Parse("14:15")));
                funcion.Add(new Funcion(22, "Sala 4", "1/12", DateTime.Parse("16:30")));
                funcion.Add(new Funcion(23, "Sala 4", "1/12", DateTime.Parse("18:30")));
                funcion.Add(new Funcion(24, "Sala 4", "1/12", DateTime.Parse("20:45")));

                // Sala 5 - Día 1
                funcion.Add(new Funcion(25, "Sala 5", "1/12", DateTime.Parse("10:00")));
                funcion.Add(new Funcion(26, "Sala 5", "1/12", DateTime.Parse("14:15")));
                funcion.Add(new Funcion(27, "Sala 5", "1/12", DateTime.Parse("18:30")));

                // Sala 1 - Día 2
                funcion.Add(new Funcion(28, "Sala 1", "2/12", DateTime.Parse("10:00")));
                funcion.Add(new Funcion(29, "Sala 1", "2/12", DateTime.Parse("12:15")));
                funcion.Add(new Funcion(30, "Sala 1", "2/12", DateTime.Parse("14:15")));
                funcion.Add(new Funcion(31, "Sala 1", "2/12", DateTime.Parse("16:30")));
                funcion.Add(new Funcion(32, "Sala 1", "2/12", DateTime.Parse("18:30")));
                funcion.Add(new Funcion(33, "Sala 1", "2/12", DateTime.Parse("20:45")));

                // Sala 2 - Día 2
                funcion.Add(new Funcion(34, "Sala 2", "2/12", DateTime.Parse("10:00")));
                funcion.Add(new Funcion(35, "Sala 2", "2/12", DateTime.Parse("12:15")));
                funcion.Add(new Funcion(36, "Sala 2", "2/12", DateTime.Parse("14:15")));
                funcion.Add(new Funcion(37, "Sala 2", "2/12", DateTime.Parse("16:30")));
                funcion.Add(new Funcion(38, "Sala 2", "2/12", DateTime.Parse("18:30")));
                funcion.Add(new Funcion(39, "Sala 2", "2/12", DateTime.Parse("20:45")));

                // Sala 3 - Día 2
                funcion.Add(new Funcion(40, "Sala 3", "2/12", DateTime.Parse("10:00")));
                funcion.Add(new Funcion(41, "Sala 3", "2/12", DateTime.Parse("12:15")));
                funcion.Add(new Funcion(42, "Sala 3", "2/12", DateTime.Parse("14:15")));
                funcion.Add(new Funcion(43, "Sala 3", "2/12", DateTime.Parse("16:30")));
                funcion.Add(new Funcion(44, "Sala 3", "2/12", DateTime.Parse("18:30")));
                funcion.Add(new Funcion(45, "Sala 3", "2/12", DateTime.Parse("20:45")));

                // Sala 4 - Día 2
                funcion.Add(new Funcion(46, "Sala 4", "2/12", DateTime.Parse("10:00")));
                funcion.Add(new Funcion(47, "Sala 4", "2/12", DateTime.Parse("12:15")));
                funcion.Add(new Funcion(48, "Sala 4", "2/12", DateTime.Parse("14:15")));
                funcion.Add(new Funcion(49, "Sala 4", "2/12", DateTime.Parse("16:30")));
                funcion.Add(new Funcion(50, "Sala 4", "2/12", DateTime.Parse("18:30")));
                funcion.Add(new Funcion(51, "Sala 4", "2/12", DateTime.Parse("20:45")));

                // Sala 5 - Día 2
                funcion.Add(new Funcion(52, "Sala 5", "2/12", DateTime.Parse("10:00")));
                funcion.Add(new Funcion(53, "Sala 5", "2/12", DateTime.Parse("14:15")));
                funcion.Add(new Funcion(54, "Sala 5", "2/12", DateTime.Parse("18:30")));

                // Sala 1 - Día 3
                funcion.Add(new Funcion(55, "Sala 1", "3/12", DateTime.Parse("10:00")));
                funcion.Add(new Funcion(56, "Sala 1", "3/12", DateTime.Parse("12:15")));
                funcion.Add(new Funcion(57, "Sala 1", "3/12", DateTime.Parse("14:15")));
                funcion.Add(new Funcion(58, "Sala 1", "3/12", DateTime.Parse("16:30")));
                funcion.Add(new Funcion(59, "Sala 1", "3/12", DateTime.Parse("18:30")));
                funcion.Add(new Funcion(60, "Sala 1", "3/12", DateTime.Parse("20:45")));

                // Sala 2 - Día 3
                funcion.Add(new Funcion(61, "Sala 2", "3/12", DateTime.Parse("10:00")));
                funcion.Add(new Funcion(62, "Sala 2", "3/12", DateTime.Parse("12:15")));
                funcion.Add(new Funcion(63, "Sala 2", "3/12", DateTime.Parse("14:15")));
                funcion.Add(new Funcion(64, "Sala 2", "3/12", DateTime.Parse("16:30")));
                funcion.Add(new Funcion(65, "Sala 2", "3/12", DateTime.Parse("18:30")));
                funcion.Add(new Funcion(66, "Sala 2", "3/12", DateTime.Parse("20:45")));

                // Sala 3 - Día 3
                funcion.Add(new Funcion(67, "Sala 3", "3/12", DateTime.Parse("10:00")));
                funcion.Add(new Funcion(68, "Sala 3", "3/12", DateTime.Parse("12:15")));
                funcion.Add(new Funcion(69, "Sala 3", "3/12", DateTime.Parse("14:15")));
                funcion.Add(new Funcion(70, "Sala 3", "3/12", DateTime.Parse("16:30")));
                funcion.Add(new Funcion(71, "Sala 3", "3/12", DateTime.Parse("18:30")));
                funcion.Add(new Funcion(72, "Sala 3", "3/12", DateTime.Parse("20:45")));

                // Sala 4 - Día 3
                funcion.Add(new Funcion(73, "Sala 4", "3/12", DateTime.Parse("10:00")));
                funcion.Add(new Funcion(74, "Sala 4", "3/12", DateTime.Parse("12:15")));
                funcion.Add(new Funcion(75, "Sala 4", "3/12", DateTime.Parse("14:15")));
                funcion.Add(new Funcion(76, "Sala 4", "3/12", DateTime.Parse("16:30")));
                funcion.Add(new Funcion(77, "Sala 4", "3/12", DateTime.Parse("18:30")));
                funcion.Add(new Funcion(78, "Sala 4", "3/12", DateTime.Parse("20:45")));

                // Sala 5 - Día 3
                funcion.Add(new Funcion(79, "Sala 5", "3/12", DateTime.Parse("10:00")));
                funcion.Add(new Funcion(80, "Sala 5", "3/12", DateTime.Parse("14:15")));
                funcion.Add(new Funcion(81, "Sala 5", "3/12", DateTime.Parse("18:30")));

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


    }
}
