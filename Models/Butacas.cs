namespace Models
{
    public class Butaca
    {
        public string Nombre { get; set; } 
        public bool EstaOcupada { get; set; } 

        public Butaca(string nombre)
        {
            Nombre = nombre;
            EstaOcupada = false; 
        }
    }
}
