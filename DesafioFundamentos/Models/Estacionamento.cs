namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        // Uso de readonly para garantir que os preços não sejam alterados acidentalmente.
        private readonly decimal precoInicial;
        private readonly decimal precoPorHora;
        private readonly List<string> veiculos = new();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            
            // Melhoria na validação da placa, convertendo para maiúscula e removendo espaços em branco com Trim().
            string placa = Console.ReadLine()?.Trim().ToUpper();

            //  Substituição de Any(x => x.ToUpper() == placa.ToUpper()) por Contains(), que melhora a eficiência.
            // VERIFICAR SE A PLACA É VÁLIDA

            if (!string.IsNullOrEmpty(placa) && !veiculos.Contains(placa))
            {
                veiculos.Add(placa);
                Console.WriteLine($"O veículo {placa} foi adicionado com sucesso!");
            }
            else
            {
                Console.WriteLine("Placa inválida ou veículo já está estacionado.");
            }
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            // Uso de ?.Trim().ToUpper() para evitar possíveis null em entradas.
            string placa = Console.ReadLine()?.Trim().ToUpper();

            if (!veiculos.Contains(placa))
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente.");
                return;
            }

            Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

            if (!int.TryParse(Console.ReadLine(), out int horas) || horas < 0)
            {
                Console.WriteLine("Quantidade de horas inválida. O veículo não será removido.");
                return;
            }

            decimal valorTotal = precoInicial + precoPorHora * horas;
            veiculos.Remove(placa);

            Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
        }

        public void ListarVeiculos()
        {
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");

                // usando ForEach(Console.WriteLine) para um código mais conciso.
                veiculos.ForEach(Console.WriteLine);
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}