namespace Models
{
    public class Sala
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public bool EsVip { get; set; }

        public Sala(int id, string nombre, bool esVip = false)
        {
            Id = id;
            Nombre = nombre;
            EsVip = esVip;
        }

        public string NombreFinal => EsVip ? "Sala Deluxe" : $"Sala {Id}";
    }
}
