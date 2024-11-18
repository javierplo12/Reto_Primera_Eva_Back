namespace Models;

public class Entrada
{
    public int Id { get; set; }
    public int SalaId { get; set; } // Id de la sala asociada
    public Sala Sala { get; set; } // Propiedad de navegación
    public int PeliculaId { get; set; } // Id de la película asociada
    public Pelicula Pelicula { get; set; } // Propiedad de navegación¡
    public int ButacaId { get; set; } // Id de la butaca asignada
    public Butaca Butaca { get; set; } // Propiedad de navegación
    public DateTime Fecha { get; set; } // Fecha y hora de la función
    public decimal Precio { get; set; } // Precio de la entrada

    public Entrada(int id, int salaId, int peliculaId, int butacaId, DateTime fecha, decimal precio)
    {
        Id = id;
        SalaId = salaId;
        PeliculaId = peliculaId;
        ButacaId = butacaId;
        Fecha = fecha;
        Precio = precio;
    }
}
