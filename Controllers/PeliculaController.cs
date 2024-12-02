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
    public class PeliculaController : ControllerBase
    {
        private static List<Pelicula> peliculas = new List<Pelicula>();

        // Método para obtener los datos de todas las peliculas
        [HttpGet]
        public ActionResult<IEnumerable<Pelicula>> GetPeliculas()
        {
            return Ok(peliculas);
        }

        // Método para obtener los datos de una pelicula por su id
        [HttpGet("{id}")]
        public ActionResult<Pelicula> GetPelicula(int id)
        {
            var pelicula = peliculas.FirstOrDefault(p => p.Id == id);
            if (pelicula == null)
            {
                return NotFound();
            }
            return Ok(pelicula);
        }

        // Método para crear una nueva pelicula
        [HttpPost]
        public ActionResult<Pelicula> CreatePelicula(Pelicula pelicula)
        {
            peliculas.Add(pelicula);
            return CreatedAtAction(nameof(GetPelicula), new { id = pelicula.Id }, pelicula);
        }

        // Método para actualizar datos de una pelicula por id
        [HttpPut("{id}")]
        public IActionResult UpdatePelicula(int id, Pelicula updatedPelicula)
        {
            var pelicula = peliculas.FirstOrDefault(p => p.Id == id);
            if (pelicula == null)
            {
                return NotFound();
            }
            pelicula.Nombre = updatedPelicula.Nombre;
            pelicula.Director = updatedPelicula.Director;
            pelicula.Sinopsis = updatedPelicula.Sinopsis;
            pelicula.Duracion = updatedPelicula.Duracion;
            pelicula.FechaEstreno = updatedPelicula.FechaEstreno;
            pelicula.Genero = updatedPelicula.Genero;
            
            return NoContent();
        }

        // Método para borrar una película por id
        [HttpDelete("{id}")]
        public IActionResult DeletePelicula(int id)
        {
            var pelicula = peliculas.FirstOrDefault(p => p.Id == id);
            if (pelicula == null)
            {
                return NotFound();
            }
            peliculas.Remove(pelicula);
            return NoContent();
        }

        // Método para inicializar datos
        public static void InicializarDatos()
        {
            peliculas.Add(new Pelicula(1, "Venom: El último baile", "Kelly Marcel", "Eddie y Venom están a la fuga. Perseguidos por sus sendos mundos y cada vez más cercados, el dúo se ve abocado a tomar una decisión devastadora que hará que caiga el telón sobre el último baile de Venom y Eddie.", 108, new DateTime(2024, 10, 25), "Acción", "https://i.pinimg.com/736x/1a/68/39/1a68392823801862ad0dbbfaaf33f14f.jpg"));
            peliculas.Add(new Pelicula(2, "Borderlands", "Eli Roth", "Película de acción y ciencia ficción basada en la popular franquicia de videojuegos de supervivencia Borderlands. El planeta Pandora es el lugar más extraño, más caótico y más peligroso del universo, allí se encuentran los restos de una antigua civilización alienígena. Y allí va a parar Lilith (Cate Blanchett), una malvada cazarrecompensas con un misterioso pasado. Lilith regresa a Pandora de mala gana. Su objetivo es encontrar un tesoro que está escondido en una cámara secreta.", 100, new DateTime(2024, 8, 9), "Acción", "https://i.pinimg.com/736x/5b/85/26/5b8526d579591c90c9a474966aceab05.jpg"));
            peliculas.Add(new Pelicula(3, "Gladiator II", "Ridley Scott", "Años después de presenciar la muerte del admirado héroe Máximo a manos de su tío, Lucio (Paul Mescal) se ve forzado a entrar en el Coliseo tras ser testigo de la conquista de su hogar por parte de los tiránicos emperadores que dirigen Roma con puño de hierro. Con un corazón desbordante de furia y el futuro del imperio en juego, Lucio debe rememorar su pasado en busca de la fuerza y el honor que devuelvan al pueblo la gloria perdida de Roma.", 147, new DateTime(2024, 11, 15), "Aventura", "https://i.pinimg.com/736x/cb/d6/45/cbd645810402ff227fe96718d33f5baf.jpg"));
            peliculas.Add(new Pelicula(4, "Gru 4 Mi villano favorito", "Chris Renaud", "Gru, Lucy y las niñas -Margo, Edith y Agnes- dan la bienvenida a un nuevo miembro en la familia: Gru Junior, que parece llegar con el propósito de ser un suplicio para su padre. Gru tendrá que enfrentarse en esta ocasión a su nueva némesis Maxime Le Mal y su sofisticada y malévola novia Valentina, lo que obligará a la familia a tener que darse a la fuga.", 94, new DateTime(2024, 7, 3), "Comedia", "https://i.pinimg.com/736x/d6/77/3e/d6773e7471513945d7ba5fa649304196.jpg"));
            peliculas.Add(new Pelicula(5, "La Infiltrada", "Arantxa Echevarría", "Basada en la historia real de Aranzazu Berradre Marín, pseudónimo con el que se infiltró una agente de la Policía nacional en la banda terrorista ETA, durante 8 años. Cuando contaba apenas 20 años, la joven consiguió adentrarse en la izquierda abertzale, siendo la única mujer que convivió en un piso con dirigentes de ETA. Durante su infiltración se vio obligada a cortar totalmente lazos familiares, todo para poder desarticular el comando Donosti en un momento crucial en el que la banda declaraba falsamente estar en tregua. Es la historia de una mujer valiente, que cambió su vida para intentar salvar la de otros.", 118, new DateTime(2024, 10, 11), "Thriller", "https://i.pinimg.com/736x/aa/76/64/aa76649d676c7f1ca38fa9ebbc3422dc.jpg"));
            peliculas.Add(new Pelicula(6, "Red One", "Jake Kasdan", "Tras el secuestro de Papá Noel, nombre en clave: RED ONE, el Jefe de Seguridad del Polo Norte (Dwayne Johnson) debe formar equipo con el cazarrecompensas más infame del mundo (Chris Evans) en una misión trotamundos llena de acción para salvar la Navidad.", 123, new DateTime(2024, 11, 6), "Acción", "https://i.pinimg.com/736x/76/0f/59/760f5902854dde76bdaa730e9d51469d.jpg"));
            peliculas.Add(new Pelicula(7, "Robot Salvaje", "Chris Sanders", "La película sigue el épico viaje de un robot -la unidad 7134 de Roz, que naufraga en una isla deshabitada y debe aprender a adaptarse al duro entorno, entablando gradualmente relaciones con los animales de la isla y convirtiéndose en padre adoptivo de un gosling huérfano.", 101, new DateTime(2024, 10, 11), "Aventura", "https://i.pinimg.com/736x/92/ee/bd/92eebdaf842c84388ee3d76902ab4758.jpg"));
            peliculas.Add(new Pelicula(8, "Smile 2", "Parker Finn", "La estrella del pop mundial Skye Riley (Naomi Scott) está a punto de embarcarse en una nueva gira mundial cuando empieza a experimentar una serie de sucesos cada vez más aterradores e inexplicables. Angustiada por la espiral de horrores y la abrumadora presión de la fama, Skye tendrá que enfrentarse a su oscuro pasado para recuperar el control de su vida antes de que sea demasiado tarde.", 127, new DateTime(2024, 10, 18), "Terror", "https://i.pinimg.com/736x/02/de/1d/02de1d329889b2ed98eb97be68d7b8b0.jpg"));
            peliculas.Add(new Pelicula(9, "Terrifier 3", "Damien Leone", "Este año la Navidad llega antes.El payaso Art desata el caos entre los desprevenidos habitantes del condado de Miles mientras cogen el sueño plácidamente en Nochebuena.Tras sobrevivir a la masacre de Halloween perpetrada por el payaso Art, el peor asesino en serie desde Jack el Destripador, Sienna y su hermano se esfuerzan por reconstruir sus vidas destrozadas. A medida que se acercan las fiestas de Navidad, intentan abrazar el espíritu navideño y dejar atrás los horrores del pasado. Pero justo cuando creen que están a salvo, el payaso Art regresa, decidido a convertir su alegría navideña en una nueva pesadilla.", 125, new DateTime(2024, 10, 31), "Terror", "https://i.pinimg.com/736x/20/7d/b1/207db1d2e7463baba70d45dc8e0a80a6.jpg"));
        }
    }
}
