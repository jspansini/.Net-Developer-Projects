namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos { get; set; } = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placasInserir = Console.ReadLine(); 
            veiculos.Add(placasInserir);    
        }

        public void RemoverVeiculo()
        {
           Console.WriteLine("Digite a placa do veículo para remover:");
            string saidaDePlaca = Console.ReadLine();

            if (veiculos.Any(x => x.ToUpper() == saidaDePlaca.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                int horas = 0;
                horas = int.Parse(Console.ReadLine());
                decimal valorTotal = 0; 
                valorTotal = precoInicial + (precoPorHora * horas);

                veiculos.Remove(saidaDePlaca);

                Console.WriteLine($"O veículo {saidaDePlaca} foi removido e o preço total foi de: R$ {valorTotal}");
                Console.WriteLine("Obrigada e volte sempre!");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são: ");
                foreach(string i in veiculos){
                    Console.WriteLine(i);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
