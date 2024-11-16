namespace Models;

public class Pelicula 
{
    public int Id {get; set;}
    public string Nombre {get; set;}
    public string Director {get; set;}
    public string Sinopsis {get; set;}
    public double Duracion {get; set;} 
    public DateTime FechaEstreno {get; set;}
    public string Genero {get; set;}

    public Pelicula(int id, string nombre, string director, string sinopsis, double duracion, DateTime fechaestreno, string genero) 
    {
        Id = id;
        Nombre = nombre;
        Director = director;
        Sinopsis = sinopsis;
        Duracion = duracion;
        FechaEstreno = fechaestreno;
        Genero = genero;
    }
}
