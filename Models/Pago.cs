namespace Models
{
    public class Pago
    {
        public int Id { get; set; }
        public decimal Precio { get; set; } 
        public string MetodoPago { get; set; } 
        public DateTime FechaPago { get; set; } 
        public string Estado { get; set; } 


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
