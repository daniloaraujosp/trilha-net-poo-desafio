namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {

        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero)
        {
        }

        // TODO: Sobrescrever o método "InstalarAplicativo"

        internal override void InstalarAplicativo()
        {
            Console.WriteLine($"Instalando o aplicativo Instagram da Play Store.");
        }
    }
}