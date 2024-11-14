namespace Models
{
    public class Sala : ElementoCine
    {
        public bool EsVip { get; set; }

        public Sala(int id, string nombreSala, bool esVip = false) 
            : base(id, nombreSala)
        {
            EsVip = esVip;
        }

        public string NombreFinal => EsVip ? "Sala Deluxe" : $"Sala {Id}";
    }
}
