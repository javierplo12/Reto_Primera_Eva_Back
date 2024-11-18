namespace Models
{
    public class Butaca
    {
        public int Id { get; set; }
        public int Fila { get; set; }
        public int Numero { get; set; }
        public bool EstaOcupada { get; set; }
        public int SalaId { get; set; } 
        public Sala Sala { get; set; } 
        public Butaca(int id, int fila, int numero, bool estaOcupada, int salaId)
        {
            Id = id;
            Fila = fila;
            Numero = numero;
            EstaOcupada = estaOcupada;
            SalaId = salaId;
        }
    }
}
