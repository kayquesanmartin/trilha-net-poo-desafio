using DesafioPOO.Models;

Random imei = new();

// TODO: Realizar os testes com as classes Nokia e Iphone
Nokia nokia = new("94366-2967", "G11", imei.NextInt64(100000000000000, 999999999999999).ToString(), 32); 
Iphone iphone = new("91275-5336", "15", imei.NextInt64(100000000000000, 999999999999999).ToString(), 256);

Console.WriteLine($"Nokia {nokia.Modelo}, IMEI - {nokia.IMEI}");
nokia.Ligar();
Console.Write("Digite o App que deseja instalar: ");
string appNokia = Console.ReadLine();
iphone.InstalarAplicativo(appNokia);

Console.WriteLine($"iPhone {iphone.Modelo}, IMEI - {iphone.IMEI}");
iphone.ReceberLigacao();
Console.Write("Digite o App que deseja instalar: ");
string appIphone = Console.ReadLine();
iphone.InstalarAplicativo(appIphone);