using System.Data;
using DesafioPOO.Models;

bool celular = true;
string num, modelo, imei;
int mem, aux;

Console.WriteLine("Assistente de configuração do Nokia");
Console.Write("Insira o número do telefone: ");
num = Console.ReadLine();
Console.Write("Insira o modelo do telefonee: ");
modelo = Console.ReadLine();
Console.Write("Insira o IMEI do telefone: ");
imei = Console.ReadLine();
Console.Write("Insira a quantidade de memória do telefone: ");
mem = int.Parse(Console.ReadLine());
Console.Clear();
Nokia nokia = new Nokia(num, modelo, imei, mem);

Console.WriteLine("Assistente de configuração do Iphone");
Console.Write("Insira o número do telefone: ");
num = Console.ReadLine();
Console.Write("Insira o modelo do telefonee: ");
modelo = Console.ReadLine();
Console.Write("Insira o IMEI do telefone: ");
imei = Console.ReadLine();
Console.Write("Insira a quantidade de memória do telefone: ");
mem = int.Parse(Console.ReadLine());
Console.Clear();
Iphone iphone = new Iphone(num, modelo, imei, mem);

while(celular){
    Console.WriteLine("Selecione um celular para utilizar:\n1 - Nokia\n2 - Iphone\n3 - Encerrar programa");
    mem = int.Parse(Console.ReadLine());
    
    switch(mem){
        case 1:
        Console.Clear();
        Console.WriteLine("Você deseja\n1 - Fazer uma ligação\n2 - Reeceber uma ligação\n3 - Instalar um aplicativo\n4 - Alterar numero de telefone");
        aux = int.Parse(Console.ReadLine());
        switch(aux){
            case 1:
            nokia.Ligar();
            Task.Delay(2500).Wait();
            Console.Clear();
            break;
            case 2:
            nokia.ReceberLigacao();
            Task.Delay(2500).Wait();
            Console.Clear();
            break;
            case 3:
            Console.Write("Digite o nome do app para instalação: ");
            modelo = Console.ReadLine();
            nokia.InstalarAplicativo(modelo);
            Task.Delay(2500).Wait();
            Console.Clear();
            break;
            case 4:
            num = nokia.Numero;
            Console.Write("Insira o novo número de telefone: ");
            nokia.Numero = Console.ReadLine();
            Console.WriteLine($"Número de telefone alterado de {num} para {nokia.Numero} com sucesso!");
            Task.Delay(2500).Wait();
            Console.Clear();
            break;
            default:
            Console.Clear();
            Console.WriteLine("Selecione uma opção válida!");
            Task.Delay(800).Wait();
            break;
        }
        break;
        
        case 2:
        Console.Clear();
        Console.WriteLine("Você deseja\n1 - Fazer uma ligação\n2 - Reeceber uma ligação\n3 - Instalar um aplicativo\n4 - Alterar numero de telefone");
        aux = int.Parse(Console.ReadLine());
        switch(aux){
            case 1:
            iphone.Ligar();
            Task.Delay(2500).Wait();
            Console.Clear();
            break;
            case 2:
            iphone.ReceberLigacao();
            Task.Delay(2500).Wait();
            Console.Clear();
            break;
            case 3:
            Console.Write("Digite o nome do app para instalação: ");
            modelo = Console.ReadLine();
            iphone.InstalarAplicativo(modelo);
            Task.Delay(2500).Wait();
            Console.Clear();
            break;
            case 4:
            num = iphone.Numero;
            Console.Write("Insira o novo número de telefone: ");
            iphone.Numero = Console.ReadLine();
            Console.WriteLine($"Número de telefone alterado de {num} para {iphone.Numero} com sucesso!");
            Task.Delay(2500).Wait();
            Console.Clear();
            break;
            default:
            Console.Clear();
            Console.WriteLine("Selecione uma opção válida!");
            Task.Delay(800).Wait();
            break;
        }
        break;

        case 3:
        Console.Clear();
        Console.WriteLine("Encerrando programa...");
        celular = false;
        break;  

        default:
        Console.Clear();
        Console.WriteLine("Selecione uma opção válida!");
        Task.Delay(800).Wait();
        break;
    }
}