using Microsoft.AspNetCore.Mvc;
using Models;
using System.Collections.Generic;
using System.Linq;

namespace Reto_Primera_Eva.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EntradaController : ControllerBase
    {
        private static List<Entrada> entradas = new List<Entrada>();

        [HttpGet]
        public ActionResult<IEnumerable<Entrada>> GetEntradas()
        {
            return Ok(entradas);
        }

        [HttpGet("{id}")]
        public ActionResult<Entrada> GetEntrada(int id)
        {
            var entrada = entradas.FirstOrDefault(e => e.Id == id);
            if (entrada == null)
            {
                return NotFound();
            }
            return Ok(entrada);
        }

        [HttpPost]
        public ActionResult<Entrada> CreateEntrada(Entrada entrada)
        {
            entradas.Add(entrada);
            return CreatedAtAction(nameof(GetEntrada), new { id = entrada.Id }, entrada);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateEntrada(int id, Entrada updatedEntrada)
        {
            var entrada = entradas.FirstOrDefault(e => e.Id == id);
            if (entrada == null)
            {
                return NotFound();
            }

            entrada.Fecha = updatedEntrada.Fecha;
            entrada.Precio = updatedEntrada.Precio;

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteEntrada(int id)
        {
            var entrada = entradas.FirstOrDefault(e => e.Id == id);
            if (entrada == null)
            {
                return NotFound();
            }
            entradas.Remove(entrada);
            return NoContent();
        }

        // Método para inicializar datos de ejemplo
        public static void InicializarDatos()
        {
            entradas.Add(new Entrada(1, new DateTime(2024, 11, 20, 18, 30, 0), 5));
        }
    }
}
