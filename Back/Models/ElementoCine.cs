using System.Numerics;

namespace Models;

public abstract class ElementoCine {

    public int Id {get; set;}
    public string Nombre {get; set;}

    public ElementoCine(int id, string nombre){
        Id = id;
        Nombre = nombre;
    }
    

    public abstract void MostrarDetalles();
}

