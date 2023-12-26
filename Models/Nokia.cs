namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
    public Nokia(string numero, string imei, string modelo, string memoria) : base(numero, imei, modelo, memoria)
    {
        

    }

        public override void InstalarAplicativo(string nomeApp)
        {
            // Implementa o método abstrato
            Console.WriteLine($"Instalando o aplicativo {nomeApp} em um Nokia..." );
        }
    }
}