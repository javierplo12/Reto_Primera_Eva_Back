namespace Models;

public class Entrada
{
    public int Id {get; set;}
    public string Nombre {get; set;}
    public int SalaId { get; set; }
    public DateTime FechaHora { get; set; }
    public double Precio { get; set; }
    public int ButacaId { get; set; }

    public Entrada(int id, string nombre, int salaId, DateTime fechaHora, double precio, int butacaId) 
    {
        Id = id;
        Nombre = nombre;
        SalaId = salaId;
        FechaHora = fechaHora;
        Precio = precio;
        ButacaId = butacaId;
    }

}
