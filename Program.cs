using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Testes com o Nokia: ");
Nokia nokia = new("999999999", "Modelo 1", "11111111", 64);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Telegram");







Console.WriteLine("Testes com o iPhone: ");
Iphone iphone = new("88888888", "Modelo 2", "22222222", 128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Whatsapp");