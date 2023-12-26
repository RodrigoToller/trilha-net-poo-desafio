namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
           public Iphone(string numero, string imei, string modelo, string memoria) : base(numero, imei, modelo, memoria)
            {
        

            }


        // TODO: Sobrescrever o método "InstalarAplicativo"

                public override void InstalarAplicativo(string nomeApp)
        {
            // Implementa o método abstrato
            Console.WriteLine($"Instalando o aplicativo {nomeApp} em um Iphone...");
        }

    }
}