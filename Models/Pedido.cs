namespace Models
{
    public class Pedido
{
    public int Id { get; set; }
    public string Pelicula { get; set; }
    public string Dia { get; set; }
    public string Hora { get; set; }
    public string ButacasSeleccionadas { get; set; }
    public decimal Precio { get; set; }

    public Pedido(int id, string pelicula, string dia, string hora, string butacasSeleccionadas, decimal precio)
    {
        Id = id;
        Pelicula = pelicula;
        Dia = dia;
        Hora = hora;
        ButacasSeleccionadas = butacasSeleccionadas;
        Precio = precio;
    }
}

}
