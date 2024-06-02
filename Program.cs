using DesafioPOO.Models;

Console.WriteLine("Iphone: ");
Smartphone iphone = new Iphone(numero:"819976545", modelo:"15pro", imei:"1111111111", memoria:128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Linkedin");

Console.WriteLine("\n");

Console.WriteLine("Nokia");
Smartphone nokia = new Nokia(numero: "8199765453", modelo: "xxx", imei: "2222222222", memoria: 256);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Dion");