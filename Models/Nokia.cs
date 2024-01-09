using System;

namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {        
        public override void Ligar()
        {
            Console.WriteLine("Ligando Nokia...");
        }

        public override void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação no Nokia...");
        }

        public override void InstalarAplicativo(string nome)
        {
            Console.WriteLine($"Instalando aplicativo {nome} no Nokia...");

            // Lógica de instalação específica para Nokia
            Console.WriteLine($"Verificando compatibilidade e instalando o aplicativo {nome} na loja Nokia...");
            Console.WriteLine($"Download e instalação concluídos com sucesso no Nokia!");
        }
    }
}
