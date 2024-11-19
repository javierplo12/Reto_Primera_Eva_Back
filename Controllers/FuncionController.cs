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
        funcion.Add(new Funcion("Sala 1", "Lunes", DateTime.Parse("10:00")));
        funcion.Add(new Funcion("Sala 1", "Lunes", DateTime.Parse("12:15")));
        funcion.Add(new Funcion("Sala 1", "Lunes", DateTime.Parse("14:15")));
        funcion.Add(new Funcion("Sala 1", "Lunes", DateTime.Parse("16:30")));
        funcion.Add(new Funcion("Sala 1", "Lunes", DateTime.Parse("18:30")));
        funcion.Add(new Funcion("Sala 1", "Lunes", DateTime.Parse("20:45")));

        // Sala 2
        funcion.Add(new Funcion("Sala 2", "Lunes", DateTime.Parse("10:00")));
        funcion.Add(new Funcion("Sala 2", "Lunes", DateTime.Parse("12:15")));
        funcion.Add(new Funcion("Sala 2", "Lunes", DateTime.Parse("14:15")));
        funcion.Add(new Funcion("Sala 2", "Lunes", DateTime.Parse("16:30")));
        funcion.Add(new Funcion("Sala 2", "Lunes", DateTime.Parse("18:30")));
        funcion.Add(new Funcion("Sala 2", "Lunes", DateTime.Parse("20:45")));

        // Sala 3
        funcion.Add(new Funcion("Sala 3", "Lunes", DateTime.Parse("10:00")));
        funcion.Add(new Funcion("Sala 3", "Lunes", DateTime.Parse("12:15")));
        funcion.Add(new Funcion("Sala 3", "Lunes", DateTime.Parse("14:15")));
        funcion.Add(new Funcion("Sala 3", "Lunes", DateTime.Parse("16:30")));
        funcion.Add(new Funcion("Sala 3", "Lunes", DateTime.Parse("18:30")));
        funcion.Add(new Funcion("Sala 3", "Lunes", DateTime.Parse("20:45")));

        // Sala 4
        funcion.Add(new Funcion("Sala 4", "Lunes", DateTime.Parse("10:00")));
        funcion.Add(new Funcion("Sala 4", "Lunes", DateTime.Parse("12:15")));
        funcion.Add(new Funcion("Sala 4", "Lunes", DateTime.Parse("14:15")));
        funcion.Add(new Funcion("Sala 4", "Lunes", DateTime.Parse("16:30")));
        funcion.Add(new Funcion("Sala 4", "Lunes", DateTime.Parse("18:30")));
        funcion.Add(new Funcion("Sala 4", "Lunes", DateTime.Parse("20:45")));

        // Sala 5
        funcion.Add(new Funcion("Sala 5", "Lunes", DateTime.Parse("10:00")));
        funcion.Add(new Funcion("Sala 5", "Lunes", DateTime.Parse("14:15")));
        funcion.Add(new Funcion("Sala 5", "Lunes", DateTime.Parse("18:30")));
    }
}


        // Obtiene todas las salas
        [HttpGet]
        public ActionResult<IEnumerable<Funcion>> GetFuncion()
        {
            return Ok(funcion);
        }
    }
}
