
namespace Models
{
    public class Opinon
{
    public int Id { get; set; }
    public string Nombre {get;set ;}
    public int Valoracion {get;set;}





    public Opinon(int id, string nombre, int valoracion)
    {
        Id = id;
        Nombre = nombre;
        Valoracion = valoracion;
    }

        internal void Remove(Opinon opinon)
        {
            throw new NotImplementedException();
        }
    }


}
