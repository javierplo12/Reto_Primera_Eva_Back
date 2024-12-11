using Microsoft.AspNetCore.Mvc;
using Models;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace Reto_Primera_Eva.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OpinionesPelisController : ControllerBase
    {
        private static List<OpinionesPelis> opinionesPelis = new List<OpinionesPelis>();

        // Método para obtener los datos de todas las opiniones de peliculas
        [HttpGet]
        public ActionResult<IEnumerable<OpinionesPelis>> GetOpinionesPelis()
        {
            return Ok(opinionesPelis);
        }

        // Método para obtener los datos de una opinion de pelicula por su id
        [HttpGet("{id}")]
        public ActionResult<Pelicula> GetOpinionPeliculaById(int id)
        {
            var opinion = opinionesPelis.FirstOrDefault(o => o.Id == id);
            if (opinion == null)
            {
                return NotFound();
            }
            return Ok(opinion);
        }

        // Metodo para añadir una nueva opinion
        [HttpPost]
        public ActionResult<OpinionesPelis> CreateOpìnion([FromBody] OpinionesPelis nuevaOpinion)
        {
            // Asignar un ID único a cada opinion
            nuevaOpinion.Id = opinionesPelis.Count > 0 ? opinionesPelis.Max(p => p.Id) + 1 : 1;

            // Agregar el nuevo comentario
            opinionesPelis.Add(nuevaOpinion);

            // Devolver la opinion creada con su nuevo ID
            return CreatedAtAction(nameof(GetOpinionPeliculaById), new { id = nuevaOpinion.Id }, nuevaOpinion);
        }
        public static void InicializarOpiniones()
        {
            opinionesPelis.Add(new OpinionesPelis(1, "Ruben", DateTime.Now, "La peli es una mierda", 1));
        }
    }
}
