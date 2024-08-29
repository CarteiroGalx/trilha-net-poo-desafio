using DesafioPOO.Models;

Iphone iphone = new Iphone("12421321", "14", "11111111111111", 90);
iphone.InstalarAplicativo("Telegram");
iphone.ReceberLigacao();

Nokia nokia= new Nokia("1242131", "8", "22222222222222", 500);
nokia.ReceberLigacao();
nokia.Ligar();
nokia.InstalarAplicativo("Instagram");
// TODO: Realizar os testes com as classes Nokia e Iphone