using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("SmartPhone Nokia: ");
Smartphone nokia = new Nokia(numero:"(11)9999-9999", modelo:"modelo 3310", imei:"101010", memoria: 8);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");
nokia.InstalarAplicativo("CAll OF DUTY MOBILE");

Console.WriteLine("\n");

Console.WriteLine("SmartPhone Iphone: ");
Smartphone iphone = new Iphone(numero: "(11)8888-8888", modelo: "modelo 13 Pro", imei: "23459876", memoria: 512);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");
iphone.InstalarAplicativo("Facebook");