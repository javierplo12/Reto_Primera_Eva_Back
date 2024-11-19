namespace Models;

public class Entrada
{
    public int Id { get; set; }
    public DateTime Fecha { get; set; } // Fecha y hora de la función
    public decimal Precio { get; set; } // Precio de la entrada

    public Entrada(int id, DateTime fecha, decimal precio)
    {
        Id = id;
        Fecha = fecha;
        Precio = precio;
    }
}
