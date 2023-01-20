using DesafioPOO.Models;

Nokia novoNokia = new Nokia("21 9891-9929", "NokiaPalm", "1413-F", 64);

Console.WriteLine("----------- NOKIA ----------------");
Console.WriteLine($"Este é meu modelo {novoNokia.Modelo} - IMEI:{novoNokia.Imei} com {novoNokia.Memoria} GB de memória! \nPara me ligar, disque {novoNokia.Numero}");
novoNokia.Ligar();
novoNokia.ReceberLigacao();
novoNokia.InstalarAplicativo("Angrybirds");

Iphone novoIphone = new Iphone("21 9891-9929", "IphoneXV", "1323-F", 128);
Console.WriteLine("----------- IPHONE ----------------");
Console.WriteLine($"Este é meu modelo {novoIphone.Modelo} - IMEI:{novoIphone.Imei} com {novoIphone.Memoria} GB de memória! \nPara me ligar, disque {novoIphone.Numero}");
novoIphone.Ligar();
novoIphone.ReceberLigacao();
novoIphone.InstalarAplicativo("Itunes");