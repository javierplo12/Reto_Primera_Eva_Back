namespace Models
{
    public class Butaca : ElementoCine
    {
        public int Fila {get; set;}
        public int Numero {get; set;}
        public bool EstaOcupada {get; set;}

        public Butaca(int id, int fila, int numero, bool estaOcupada) : base(id, $"{fila}-{numero}")
        {
            Fila = fila;
            Numero = numero;
            EstaOcupada = estaOcupada;
        }

        public override void MostrarDetalles()
        {
            Console.WriteLine($"Butaca: {Fila}-{Numero}, Ocupada: {EstaOcupada}");
        }
    }
}

