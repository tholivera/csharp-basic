using System;

namespace Aula06._1
{
    internal class Program
    {
        static void Main(string[] args) { 

            int carrosVendidos;
            double valorCarrosVendidos, salarioFixo, comissaoFixa, salarioFinal;

            salarioFixo = 1000;
            comissaoFixa = 100;

            Console.WriteLine("Quantos carros você vendeu esse mês?");
            carrosVendidos = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual o total em R$ que você vendeu?");
            valorCarrosVendidos = double.Parse(Console.ReadLine());

            salarioFinal = salarioFixo +  (comissaoFixa * carrosVendidos) + (valorCarrosVendidos * 0.05);

            Console.WriteLine($"Total de vendas em R$: {valorCarrosVendidos}" 
                + $"\nTotal de carros vendidos: {carrosVendidos}" 
                + $"\nSalário fixo: {salarioFixo}" 
                + $"\nComissão fixa: {comissaoFixa}"
                + $"\nComissão pelas vendas: {comissaoFixa * carrosVendidos}"
                + $"\nComissão de 5% sobre o valor de vendas: {valorCarrosVendidos * 0.05}" 
                + $"\nSalário final: {salarioFinal}");

        }
    }
}
