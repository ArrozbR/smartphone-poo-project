namespace DesafioPOO.Models{
    public class Iphone : Smartphone{
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria){}

        public override void InstalarAplicativo(string nomeApp){
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no Iphone...");
            Task.Delay(3000).Wait();
            Console.WriteLine("Instalado com sucesso!");
        }
    }
}