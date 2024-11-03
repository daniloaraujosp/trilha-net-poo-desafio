namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {

        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero)
        {
        }

        // TODO: Sobrescrever o método "InstalarAplicativo"
        
        internal override void InstalarAplicativo()
        {
            Console.WriteLine($"Instalando o aplicativo WhatsApp da Play Store.");
        }
    }
}