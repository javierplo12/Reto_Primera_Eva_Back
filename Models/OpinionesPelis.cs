namespace Models;

public class OpinionesPelis
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public DateTime Fecha {get; set;}
    public string Opinion { get; set; }
    public int Puntuacion {get; set;}

    public string FechaFormated => Fecha.ToString("dd/mm/yyyy HH:mm");
    public OpinionesPelis(int id, string nombre, DateTime fecha, string opinion, int puntuacion)
    {
        Id = id;
        Nombre = nombre;
        Fecha = fecha;
        Opinion = opinion;
        Puntuacion = puntuacion;
    }
}