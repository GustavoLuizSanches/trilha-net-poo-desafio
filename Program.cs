using System.ComponentModel;
using DesafioPOO.Models;

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone (numero: "90101-0101", modelo: "modelo 1", imei: "000000000000000", memoria: 64);
iphone.Ligar("Luciana");
iphone.InstalarAplicativo("Instagram");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Nokia:");
Nokia nokia = new Nokia (numero: "90202-0202", modelo: "modelo 2", imei: "111111111111111", memoria: 128);
nokia.ReceberLigacao("Gustavo");
nokia.InstalarAplicativo("WhatsApp");