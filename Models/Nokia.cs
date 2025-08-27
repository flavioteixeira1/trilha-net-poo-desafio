using System.Threading;


namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int Memoria) : base(numero, modelo, imei, Memoria)
        {

        }

        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {

            //throw new NotImplementedException();
            Console.Write($"instalando aplicativo {nomeApp} no Nokia ");
            Console.Write(" Aguarde");
            for (int n = 0; n < 3; n++)
            {
                Thread.Sleep(600);
                Console.Write(".");
            }
            Console.WriteLine($"aplicativo {nomeApp} instalado.");
        }
    }
}