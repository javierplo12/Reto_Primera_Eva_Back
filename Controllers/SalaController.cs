using Microsoft.AspNetCore.Mvc;
using Models;
using System.Collections.Generic;
using System.Linq;

namespace Reto_Primera_Eva.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalaController : ControllerBase
    {
        private static List<Sala> salas = new List<Sala>();

        static SalaController()
        {
            InicializarSalas();
        }

        public static void InicializarSalas()
        {
            salas.Add(new Sala(1, ""));
            salas.Add(new Sala(2, ""));
            salas.Add(new Sala(3, ""));
            salas.Add(new Sala(4, ""));
            salas.Add(new Sala(5, "", esVip: true));
        }

        // Obtiene todas las salas
        [HttpGet]
        public ActionResult<IEnumerable<object>> GetSalas()
        {
            var resultado = salas.Select(s => new
            {
                s.Id,
                Nombre = s.NombreFinal,
                s.EsVip
            });
            return Ok(resultado);
        }

        // Obtiene una sala por su ID
        [HttpGet("{id}")]
        public ActionResult<object> GetSala(int id)
        {
            var sala = salas.FirstOrDefault(s => s.Id == id);
            if (sala == null)
            {
                return NotFound("Sala no encontrada.");
            }

            var resultado = new
            {
                sala.Id,
                Nombre = sala.NombreFinal,
                sala.EsVip
            };
            return Ok(resultado);
        }

        // Crea una nueva sala
        [HttpPost]
        public ActionResult CrearSala(Sala nuevaSala)
        {
            if (salas.Any(s => s.Id == nuevaSala.Id))
            {
                return BadRequest("Ya existe una sala con el mismo ID.");
            }

            salas.Add(nuevaSala);
            return CreatedAtAction(nameof(GetSala), new { id = nuevaSala.Id }, nuevaSala);
        }

        // Actualiza los datos de una sala existente
        [HttpPut("{id}")]
        public IActionResult ActualizarSala(int id, Sala salaActualizada)
        {
            var sala = salas.FirstOrDefault(s => s.Id == id);
            if (sala == null)
            {
                return NotFound("Sala no encontrada.");
            }

            sala.Nombre = salaActualizada.Nombre;
            sala.EsVip = salaActualizada.EsVip;
            return NoContent();
        }

        // Elimina una sala por su ID
        [HttpDelete("{id}")]
        public IActionResult EliminarSala(int id)
        {
            var sala = salas.FirstOrDefault(s => s.Id == id);
            if (sala == null)
            {
                return NotFound("Sala no encontrada.");
            }

            salas.Remove(sala);
            return NoContent();
        }

        // Obtiene si una sala es VIP
        [HttpGet("{id}/esvip")]
        public IActionResult EsSalaVip(int id)
        {
            var sala = salas.FirstOrDefault(s => s.Id == id);
            if (sala == null)
            {
                return NotFound("Sala no encontrada.");
            }

            return Ok(new { SalaId = sala.Id, EsVip = sala.EsVip });
        }
    }
}
