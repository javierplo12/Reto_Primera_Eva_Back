namespace Models
{
    public class Pedido
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Correo { get; set; }
    public string Telefono { get; set; }
    public string Pelicula { get; set; }
    public string Dia { get; set; }
    public string Hora { get; set; }
    public string ButacasSeleccionadas { get; set; }
    public decimal PrecioTotal { get; set; }

    public Pedido(int id, string nombre, string correo, string telefono, string pelicula, string dia, string hora, string butacasSeleccionadas, decimal preciototal)
    {
        Id = id;
        Nombre = nombre;
        Correo = correo;
        Telefono = telefono;
        Pelicula = pelicula;
        Dia = dia;
        Hora = hora;
        ButacasSeleccionadas = butacasSeleccionadas;
        PrecioTotal = preciototal;
    }
}

}
