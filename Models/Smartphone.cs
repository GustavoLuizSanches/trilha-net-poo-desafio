namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        public string Modelo { get; set; }
        public string Imei { get; set; }
        public int Memoria { get; set; }


        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            Imei = imei;
            Memoria = memoria;
        }

        public void Ligar(string Pessoa)
        {
            Console.WriteLine($"Ligando para {Pessoa}.");
        }

        public void ReceberLigacao(string Pessoa)
        {
            Console.WriteLine($"Recebendo ligação de {Pessoa}.");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}