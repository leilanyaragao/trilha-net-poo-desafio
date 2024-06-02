namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        private string Imei {get; set;}
        private int Memoria {get; set;}
        private string Modelo {get; set;}
        public string Numero { get; set; }


        public Smartphone(string imei, int memoria, string modelo, string numero)
        {
            Imei = imei;
            Memoria = memoria;
            Modelo = modelo;
            Numero = numero;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}