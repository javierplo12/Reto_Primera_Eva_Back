namespace Models
{
    public class Pago
    {
        public int Id { get; set; }
        public decimal Precio { get; set; } 
        public string MetodoPago { get; set; } // Método de pago (Ej.: "Tarjeta", "Efectivo", etc.)
        public DateTime FechaPago { get; set; } // Fecha y hora del pago
        public string Estado { get; set; } // Estado del pago


        public Pago(int id, decimal precio, string metodoPago, DateTime fechaPago, string estado)
        {
            Id = id;
            Precio = precio;
            MetodoPago = metodoPago;
            FechaPago = fechaPago;
            Estado = estado;
        }
    }
}
