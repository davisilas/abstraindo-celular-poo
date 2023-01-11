using DesafioPOO.Models;

Console.WriteLine("Teste Nokia");
Smartphone nokia = new Nokia("(11) 92862-4562", "Muito bom", "654765532", 54);
nokia.Ligar();
nokia.InstalarAplicativo("Facebook");

Console.WriteLine("\n");

Console.WriteLine("Teste iPhone");
Smartphone iphone = new Iphone("(11) 99999-9999", "Modelo Top", "321321321", 163);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");
