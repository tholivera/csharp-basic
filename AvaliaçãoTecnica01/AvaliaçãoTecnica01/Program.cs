using System;
using System.Collections.Generic;

namespace AvaliaçãoTecnicaExercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vendedor vendedor = new Vendedor();
            List<Vendedor> vendedorLista = new List<Vendedor>();
            List<Produto> produto = new List<Produto>();

            int quantidade, quant;
            string nomeProduto;
            double preco;

            Console.WriteLine("----------------------------------");
            Console.WriteLine("\t   ORDEM DE VENDA");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Informar quantidade de produtos");
            Console.WriteLine("disponíveis para venda");
            Console.WriteLine("----------------------------------");
            quant = int.Parse(Console.ReadLine());

            Console.WriteLine("----------------------------------");
            Console.WriteLine("      Digite o ID do vendedor");
            Console.WriteLine("----------------------------------");
            vendedor.IdVendedor = int.Parse(Console.ReadLine());

            int[] vetor = new int[quant];

            quantidade = quant;

            for (int i = 0; i < vetor.Length; i++)
            {

                Console.WriteLine("----------------------------------");
                Console.WriteLine($"Quantidade de produtos em estoque:\n{quantidade} unidade(s)");
                Console.WriteLine("----------------------------------");
                Console.Write($"Digite o nome do produto {i + 1}: ");
                nomeProduto = Console.ReadLine();
                Console.WriteLine("----------------------------------");
                Console.Write($"Digite o valor do produto {nomeProduto}: R$ ");
                preco = double.Parse(Console.ReadLine());
                Console.WriteLine("----------------------------------");

                produto.Add(new Produto(nomeProduto));

                vendedorLista.Add(new Vendedor(preco));

                vendedor.SomaVendas();
                vendedor.SomarValores(preco);
                quantidade--;

            }
            Console.WriteLine(vendedor.ToString());









        }
    }
}
