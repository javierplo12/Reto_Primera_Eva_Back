namespace Models
{
    public class Funcion
    {
        public string Sala { get; set; }
        public string Dia {get; set;}
        public DateTime Hora {get; set;}

        public Funcion(string sala, string dia, DateTime hora)
        {
            Sala = sala;
            Dia = dia;           
            Hora = hora;
        }
    }
}
