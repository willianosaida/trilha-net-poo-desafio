using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia = new Nokia(numero: "48984901765", modelo: "Nokia-3620", imei: "4825436236", memoria: 128);
nokia.Ligar();
nokia.InstalarAplicativo("Google Maps");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone: ");
Smartphone iphone = new Iphone(numero: "48984257650", modelo: "Iphone-XR-Plus", imei: "2854254243", memoria: 256);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Waze");