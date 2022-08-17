using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DESAFIOFUNDAMENTOS.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoHora = 0;
        List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoHora)
        {
            this.precoInicial = precoInicial;
            this.precoHora = precoHora;
        }
        public void CadastrarVeiculo()
        {
            Console.WriteLine("A placa do veículo para estacionar:");
            string placa = Console.ReadLine();
            veiculos.Add(placa);
            
        }
        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo");
            string placaVeiculo = Console.ReadLine();
            veiculos.Remove(placaVeiculo);
            Console.WriteLine("Digite a quantidades de horas que ficou estacionado");
            string quantidadeHora = Console.ReadLine();
            decimal valor = precoInicial + precoHora * Convert.ToInt32(quantidadeHora);
            Console.WriteLine($"O veículo {placaVeiculo} foi removido e o preço total foi de: {valor}");
        }
        public void ListarVeiculo()
        {
            foreach(string item in veiculos)
            {
                Console.WriteLine(item);
            }
        }
    }
}