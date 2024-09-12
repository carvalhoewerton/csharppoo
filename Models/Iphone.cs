namespace DesafioPOO.Models
{
    public class iPhone : Smartphone
    {
        public iPhone(string numero, string modelo, string marca, string sistemaOperacional)
            : base(numero, modelo, marca, sistemaOperacional)
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no iPhone.");
        }
    }
}
