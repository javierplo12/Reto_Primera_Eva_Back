

namespace Models
{
    public class Pago
    {
        public int Id { get; set; }

        public int EntradaId { get; set; } // Id de la entrada asociada
        
        public Entrada Entrada { get; set; } // Propiedad de navegación
        
        public decimal Precio { get; set; } // Monto del pago

        public string MetodoPago { get; set; } // Método de pago (Ej.: "Tarjeta", "Efectivo", etc.)

        public DateTime FechaPago { get; set; } // Fecha y hora del pago

        public string Estado { get; set; } // Estado del pago


        public Pago(int id, int entradaId, decimal precio, string metodoPago, DateTime fechaPago, string estado)
        {
            Id = id;
            EntradaId = entradaId;
            Precio = precio;
            MetodoPago = metodoPago;
            FechaPago = fechaPago;
            Estado = estado;
        }
    }
}
