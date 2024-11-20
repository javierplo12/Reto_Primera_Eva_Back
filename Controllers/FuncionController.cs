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

        public static void InicializarFunciones()
        {
            if (!funcion.Any())
            {
                // Sala 1
                funcion.Add(new Funcion(1, "Sala 1", "1/12", DateTime.Parse("10:00")));
                funcion.Add(new Funcion(2, "Sala 1", "1/12", DateTime.Parse("12:15")));
                funcion.Add(new Funcion(3, "Sala 1", "1/12", DateTime.Parse("14:15")));
                funcion.Add(new Funcion(4, "Sala 1", "1/12", DateTime.Parse("16:30")));
                funcion.Add(new Funcion(5, "Sala 1", "1/12", DateTime.Parse("18:30")));
                funcion.Add(new Funcion(6, "Sala 1", "1/12", DateTime.Parse("20:45")));

                // Sala 2
                funcion.Add(new Funcion(7, "Sala 2", "1/12", DateTime.Parse("10:00")));
                funcion.Add(new Funcion(8, "Sala 2", "1/12", DateTime.Parse("12:15")));
                funcion.Add(new Funcion(9, "Sala 2", "1/12", DateTime.Parse("14:15")));
                funcion.Add(new Funcion(10, "Sala 2", "1/12", DateTime.Parse("16:30")));
                funcion.Add(new Funcion(11, "Sala 2", "1/12", DateTime.Parse("18:30")));
                funcion.Add(new Funcion(12, "Sala 2", "1/12", DateTime.Parse("20:45")));

                // Sala 3
                funcion.Add(new Funcion(13, "Sala 3", "1/12", DateTime.Parse("10:00")));
                funcion.Add(new Funcion(14, "Sala 3", "1/12", DateTime.Parse("12:15")));
                funcion.Add(new Funcion(15, "Sala 3", "1/12", DateTime.Parse("14:15")));
                funcion.Add(new Funcion(16, "Sala 3", "1/12", DateTime.Parse("16:30")));
                funcion.Add(new Funcion(17, "Sala 3", "1/12", DateTime.Parse("18:30")));
                funcion.Add(new Funcion(18, "Sala 3", "1/12", DateTime.Parse("20:45")));

                // Sala 4
                funcion.Add(new Funcion(19, "Sala 4", "1/12", DateTime.Parse("10:00")));
                funcion.Add(new Funcion(20, "Sala 4", "1/12", DateTime.Parse("12:15")));
                funcion.Add(new Funcion(21, "Sala 4", "1/12", DateTime.Parse("14:15")));
                funcion.Add(new Funcion(22, "Sala 4", "1/12", DateTime.Parse("16:30")));
                funcion.Add(new Funcion(23, "Sala 4", "1/12", DateTime.Parse("18:30")));
                funcion.Add(new Funcion(24, "Sala 4", "1/12", DateTime.Parse("20:45")));

                // Sala 5
                funcion.Add(new Funcion(25, "Sala 5", "1/12", DateTime.Parse("10:00")));
                funcion.Add(new Funcion(26, "Sala 5", "1/12", DateTime.Parse("14:15")));
                funcion.Add(new Funcion(27, "Sala 5", "1/12", DateTime.Parse("18:30")));
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
