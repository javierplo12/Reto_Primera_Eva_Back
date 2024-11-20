namespace Models
{
    public class Funcion
    {
        public int Id { get; set; }
        public string Sala { get; set; }
        public List<string> Butacas { get; set; }
        public string Dia { get; set; }
        public DateTime Hora { get; set; }

        public string HoraFormatted => Hora.ToString("HH:mm");

        public Funcion(int id, string sala, string dia, DateTime hora)
        {
            Id = id;
            Sala = sala;
            Dia = dia;
            Hora = hora;
            Butacas = GenerarButacas();
        }

        private List<string> GenerarButacas()
        {
            List<string> butacas = new List<string>();
            char[] filas = { '1', '2', '3', '4', '5', '6', '7' };

            foreach (var fila in filas)
            {
                for (int asiento = 1; asiento <= 17; asiento++)
                {
                    butacas.Add($"{fila}-{asiento}");
                }
            }

            return butacas;
        }

    }
}