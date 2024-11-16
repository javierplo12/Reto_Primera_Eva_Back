namespace Models
{
    public class Butaca
    {
        public int Id {get; set;}
        public int Fila {get; set;}
        public int Numero {get; set;}
        public bool EstaOcupada {get; set;}

        public Butaca(int id, int fila, int numero, bool estaOcupada)
        {
            Id = id;
            Fila = fila;
            Numero = numero;
            EstaOcupada = estaOcupada;
        }
    }
}

