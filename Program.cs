using System;
using DesafioPOO.Models;

class Program
{
    static void Main()
    {
        Nokia nokia = new Nokia();
        Iphone iphone = new Iphone();

        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("WhatsApp");

        Console.WriteLine();

        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Instagram");
    }
}


