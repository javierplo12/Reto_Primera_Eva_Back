namespace Models;

public class Entrada : ElementoCine
{
    public int SalaId { get; set; }
    public DateTime FechaHora { get; set; }
    public double Precio { get; set; }
    public int ButacaId { get; set; }

    public Entrada(int id, string nombre, int salaId, DateTime fechaHora, double precio, int butacaId) 
        : base(id, nombre)
    {
        SalaId = salaId;
        FechaHora = fechaHora;
        Precio = precio;
        ButacaId = butacaId;
    }

}
