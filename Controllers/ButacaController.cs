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
    public class ButacaController : ControllerBase
    {
        private static List<Butaca> butacas = new List<Butaca>();

        static ButacaController()
        {
            InicializarButacas();
        }

        public static void InicializarButacas()
        {
            butacas.Clear(); 

            int numeroButacas = 119;
            int filas = 7;
            int butacasPorFila = numeroButacas / filas;

            int id = 1;
            for (int fila = 1; fila <= filas; fila++)
            {
                for (int numero = 1; numero <= butacasPorFila; numero++)
                {
                    butacas.Add(new Butaca(id++, fila, numero, false));
                }
            }
        }


        [HttpGet]
        public ActionResult<IEnumerable<Butaca>> GetButacas()
        {
            return Ok(butacas);
        }

        [HttpGet("{id}")]
        public ActionResult<Butaca> GetButaca(int id)
        {
            var butaca = butacas.Find(b => b.Id == id);
            if (butaca == null)
            {
                return NotFound();
            }
            return Ok(butaca);
        }
    }
}
