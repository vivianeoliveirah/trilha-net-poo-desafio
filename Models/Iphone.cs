namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        // Implementação específica para iPhone
        public override void Ligar()
        {
            Console.WriteLine("Ligando iPhone...");
        }

        public override void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação no iPhone...");
        }

        public override void InstalarAplicativo(string nome)
        {
            Console.WriteLine($"Instalando aplicativo {nome} no iPhone...");           

            Console.WriteLine($"Verificando compatibilidade e instalando o aplicativo {nome} na loja iPhone...");
            Console.WriteLine($"Download e instalação concluídos com sucesso no iPhone!");
        }
    }
}
