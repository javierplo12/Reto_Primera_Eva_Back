using Microsoft.AspNetCore.Mvc;
using Models;
using System.Collections.Generic;
using System.Linq;

namespace Reto_Primera_Eva.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PagoController : ControllerBase
    {
        // Lista estática para almacenar los pagos (simula una base de datos)
        public static List<Pago> pagos = new List<Pago>();

        static PagoController()
        {
            InicializarPagos();
        }

        // Método para inicializar algunos pagos de ejemplo
        public static void InicializarPagos()
        {
            if (!pagos.Any())
            {
                pagos.Add(new Pago(1, 50.00m, "Tarjeta", DateTime.Now, "Completado"));
                pagos.Add(new Pago(2, 30.00m, "Efectivo", DateTime.Now.AddHours(-1), "Pendiente"));
                pagos.Add(new Pago(3, 100.00m, "Tarjeta", DateTime.Now.AddDays(-1), "Cancelado"));
            }
        }

        // Obtiene todos los pagos
        [HttpGet]
        public ActionResult<IEnumerable<object>> GetPagos()
        {
            var resultado = pagos.Select(p => new
            {
                p.Id,
                p.Precio,
                p.MetodoPago,
                p.FechaPago,
                p.Estado
            });
            return Ok(resultado);
        }

        // Obtiene un pago por su ID
        [HttpGet("{id}")]
        public ActionResult<object> GetPago(int id)
        {
            var pago = pagos.FirstOrDefault(p => p.Id == id);
            if (pago == null)
            {
                return NotFound("Pago no encontrado.");
            }

            var resultado = new
            {
                pago.Id,
                pago.Precio,
                pago.MetodoPago,
                pago.FechaPago,
                pago.Estado
            };
            return Ok(resultado);
        }

        // Crea un nuevo pago
        [HttpPost]
        public ActionResult CrearPago(Pago nuevoPago)
        {
            if (pagos.Any(p => p.Id == nuevoPago.Id))
            {
                return BadRequest("Ya existe un pago con el mismo ID.");
            }

            pagos.Add(nuevoPago);
            return CreatedAtAction(nameof(GetPago), new { id = nuevoPago.Id }, nuevoPago);
        }

        // Actualiza un pago existente
        [HttpPut("{id}")]
        public IActionResult ActualizarPago(int id, Pago pagoActualizado)
        {
            var pago = pagos.FirstOrDefault(p => p.Id == id);
            if (pago == null)
            {
                return NotFound("Pago no encontrado.");
            }

            pago.Precio = pagoActualizado.Precio;
            pago.MetodoPago = pagoActualizado.MetodoPago;
            pago.FechaPago = pagoActualizado.FechaPago;
            pago.Estado = pagoActualizado.Estado;

            return NoContent();
        }

        // Elimina un pago por su ID
        [HttpDelete("{id}")]
        public IActionResult EliminarPago(int id)
        {
            var pago = pagos.FirstOrDefault(p => p.Id == id);
            if (pago == null)
            {
                return NotFound("Pago no encontrado.");
            }

            pagos.Remove(pago);
            return NoContent();
        }
    }
}