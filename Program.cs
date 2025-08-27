using System.Runtime.InteropServices;
using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia (numero: "57846633", modelo: "Nokia G60", imei: "77554245", Memoria: 128);
nokia.Ligar();
nokia.InstalarAplicativo("Super8Plus");
Console.WriteLine ();
Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone(Numero: "53474112", Modelo: "Iphone14", IMEI: "11487874", Memoria: 256);
iphone.Ligar();
iphone.InstalarAplicativo("TikTok");

