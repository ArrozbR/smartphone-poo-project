namespace DesafioPOO.Models{
    public class Nokia : Smartphone{
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria){}

        public override void InstalarAplicativo(string nomeApp){
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no Nokia...");
            Task.Delay(3000).Wait();
            Console.WriteLine("Instalado com sucesso!");
        }
    }
}