using System;

namespace Aula53Exercicio01
{
    internal class Program
    {
        public class Produto
        {
            public decimal Valor { get; set; }

            public DateTime DtPedido { get; set; }

            public decimal DescontoVIP => Valor * 0.15M;

        }


        static void Main(string[] args)
        {
            var valorProduto = new Produto();
            int vip;
            string verificarVip;

            valorProduto.DtPedido = DateTime.Today;
            
            
            
            Console.WriteLine("Qual o valor do produto?");
            valorProduto.Valor = int.Parse(Console.ReadLine());
            Console.WriteLine("\nVocê é cliente VIP? \nDigite 1 para SIM e 2 para NÃO");
            vip = int.Parse(Console.ReadLine());

            if (vip == 1)
            {
                valorProduto.Valor = valorProduto.Valor - valorProduto.DescontoVIP;
                verificarVip = "Sim";
                Console.WriteLine($"\nData: {valorProduto.DtPedido:dd/MM/yyyy}");
                Console.WriteLine($"Cliente VIP: {verificarVip}");
                Console.WriteLine($"Total com desconto para cliente VIP: R$ {valorProduto.Valor}");

            }
            else
            {
                verificarVip = "Não";
                Console.WriteLine($"\nData: {valorProduto.DtPedido:dd/MM/yyyy}");
                Console.WriteLine($"Cliente VIP: {verificarVip}");
                Console.WriteLine($"Você não é cliente VIP. Desconto não aplicável.\nTotal: R$ {valorProduto.Valor}");
            }
        }
    }
}
