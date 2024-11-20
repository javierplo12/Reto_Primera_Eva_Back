namespace Models
{
    public class Funcion
    {
        public int Id { get; set; }
        public string Sala { get; set; }
        public string Dia { get; set; }
        public DateTime Hora { get; set; }

        public string HoraFormatted => Hora.ToString("HH:mm");

        public Funcion(int id, string sala, string dia, DateTime hora)
        {
            Id = id;
            Sala = sala;
            Dia = dia;
            Hora = hora;
        }
    }
}
