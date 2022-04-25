using System;

namespace Aula60
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double valorCarro, valorDistrib, valorImposto;

            Console.WriteLine("Qual o valor de fábrica do carro?");
            valorCarro = double.Parse(Console.ReadLine());

            valorDistrib = valorCarro * 0.28;
            valorImposto = valorCarro * 0.45;

            Console.WriteLine($"O valor total do carro é: {valorCarro + valorDistrib + valorImposto}\nImposto: {valorImposto}\nDistribuição: {valorDistrib}");
        }
    }
}
