using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia= new Nokia(numero: "98877-5544", modelo: "Nokia N1", imei: "1111111111", memoria: 256);
nokia.Ligar();
nokia.InstalarAplicativo("Notion");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone: ");
Smartphone iphone = new Iphone(numero: "97788-5566", modelo: "Iphone 29", imei: "222222222", memoria: 128);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");