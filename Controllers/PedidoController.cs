using Microsoft.AspNetCore.Mvc;
using Models;
using System.Collections.Generic;
using System.Linq;

namespace Reto_Primera_Eva.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PedidoController : ControllerBase
    {
        private static List<Pedido> pedidos = new List<Pedido>();

        // GET para obtener los pedidos
        [HttpGet]
        public ActionResult<IEnumerable<Pedido>> GetPagos()
        {
            return Ok(pedidos);
        }

        // GET para obtener los pedidos por id
        [HttpGet("{id}")]
        public ActionResult<Pedido> GetPagoById(int id)
        {
            var pago = pedidos.FirstOrDefault(p => p.Id == id);
            if (pago == null)
            {
                return NotFound(new { message = $"El pago con ID {id} no existe." });
            }
            return Ok(pago);
        }

        // Metodo para añadir un nuevo pedido
        [HttpPost]
        public ActionResult<Pedido> CreatePago([FromBody] Pedido nuevoPago)
        {
            // Asignar un ID único a cada pedido
            nuevoPago.Id = pedidos.Count > 0 ? pedidos.Max(p => p.Id) + 1 : 1;

            // Agregar el nuevo pago
            pedidos.Add(nuevoPago);

            // Devolver el pedido creado con su nuevo ID
            return CreatedAtAction(nameof(GetPagoById), new { id = nuevoPago.Id }, nuevoPago);
        }

        // Elimina una función existente por ID
        [HttpDelete("{id}")]
        public ActionResult DeletePedido(int id)
        {
            var pedidoExistente = pedidos.FirstOrDefault(f => f.Id == id);

            if (pedidoExistente == null)
            {
                return NotFound("Pedido no encontrado.");
            }

            pedidos.Remove(pedidoExistente);
            return NoContent();
        }
    }
}
