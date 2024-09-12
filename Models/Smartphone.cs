namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public string SistemaOperacional { get; set; }

        public Smartphone(string numero, string modelo, string marca, string sistemaOperacional)
        {
            Numero = numero;
            Modelo = modelo;
            Marca = marca;
            SistemaOperacional = sistemaOperacional;
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
