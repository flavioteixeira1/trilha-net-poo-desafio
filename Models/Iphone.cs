using System.Threading;

namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        public Iphone(string Numero, string Modelo, string IMEI, int Memoria) : base(Numero, Modelo, IMEI, Memoria)

        {

        }
        
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"instalando aplicativo {nomeApp} no Iphone ");
            Console.Write($"instalando aplicativo {nomeApp} no Iphone ");
            Console.Write(" Aguarde");
            for (int n = 0; n < 3; n++)
            {
                Thread.Sleep(200);
                Console.Write(".");
            }
            Console.WriteLine($"aplicativo {nomeApp} instalado.");
        }
    }
}