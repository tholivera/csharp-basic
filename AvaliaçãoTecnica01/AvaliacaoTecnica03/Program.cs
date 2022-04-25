using System;
using System.Collections.Generic;
namespace AvaliacaoTecnica03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> listaRemedios = new List<string>();
            int opcao, posicao, continua;
            string resultado, busca;

            Console.WriteLine("|----------------------------|");
            Console.WriteLine("|   Digite a opção desejada  |");
            Console.WriteLine("|    1 - Adicionar remédio   |");
            Console.WriteLine("|    2 - Buscar remédio      |");
            Console.WriteLine("|    3 - Localização remédio |");
            Console.WriteLine("|    4 - Quantidade remédio  |");
            Console.WriteLine("|    5 - Listar todos        |");
            Console.WriteLine("|    0 - Sair                |");
            Console.WriteLine("|----------------------------|");

            opcao = int.Parse(Console.ReadLine());

            while (opcao != 0)
            {

                switch (opcao)
                {


                    case 1:
                        Console.WriteLine("Opção: 1 - Adicionar remédio");
                        Console.WriteLine("\nDigite o nome do remédio que deseja adicionar");
                        listaRemedios.Add(Console.ReadLine());
                        Console.Clear();
                        Console.WriteLine("Adicionado com  sucesso!");
                        Console.WriteLine("\nDeseja continuar?\n1 - Sim\n2 - Não");
                        continua = int.Parse(Console.ReadLine());
                        Console.Clear();
                        if (continua == 1)
                        {
                            Console.WriteLine("|----------------------------|");
                            Console.WriteLine("|   Digite a opção desejada  |");
                            Console.WriteLine("|    1 - Adicionar remédio   |");
                            Console.WriteLine("|    2 - Buscar remédio      |");
                            Console.WriteLine("|    3 - Localização remédio |");
                            Console.WriteLine("|    4 - Quantidade remédio  |");
                            Console.WriteLine("|    5 - Listar todos        |");
                            Console.WriteLine("|    0 - Sair                |");
                            Console.WriteLine("|----------------------------|");
                            opcao = int.Parse(Console.ReadLine());
                        } else
                        {
                            opcao = 0;
                            Console.WriteLine("Finalizado");
                        }
                        break;

                    case 2:
                        Console.WriteLine("Opção: 2 - Buscar remédio");
                        Console.WriteLine("\nDigite o nome ou parte do nome do remédio que deseja buscar");
                        busca = Console.ReadLine();
                        resultado = listaRemedios.Find(x => x.Contains(busca));
                        if (resultado == null)
                        {
                            Console.WriteLine("Não encontrado");
                        }
                        Console.WriteLine("Encontrado: " + resultado);
                        Console.WriteLine("\nDeseja continuar?\n1 - Sim\n2 - Não");
                        continua = int.Parse(Console.ReadLine());
                        Console.Clear();
                        if (continua == 1)
                        {
                            Console.WriteLine("|----------------------------|");
                            Console.WriteLine("|   Digite a opção desejada  |");
                            Console.WriteLine("|    1 - Adicionar remédio   |");
                            Console.WriteLine("|    2 - Buscar remédio      |");
                            Console.WriteLine("|    3 - Localização remédio |");
                            Console.WriteLine("|    4 - Quantidade remédio  |");
                            Console.WriteLine("|    5 - Listar todos        |");
                            Console.WriteLine("|    0 - Sair                |");
                            Console.WriteLine("|----------------------------|");
                            opcao = int.Parse(Console.ReadLine());
                        }
                        else
                        {
                            opcao = 0;
                            Console.WriteLine("Finalizado");
                        }
                        break;

                    case 3:
                        Console.WriteLine("Opção: 3 - Localização remédio");
                        Console.WriteLine("\nDigite o nome do remédio que deseja saber a localização");
                        posicao = listaRemedios.IndexOf(busca = Console.ReadLine());
                        Console.WriteLine($"A posição do remédio informado é: {posicao}");
                        Console.WriteLine("\nDeseja continuar?\n1 - Sim\n2 - Não");
                        continua = int.Parse(Console.ReadLine());
                        Console.Clear();
                        if (continua == 1)
                        {
                            Console.WriteLine("|----------------------------|");
                            Console.WriteLine("|   Digite a opção desejada  |");
                            Console.WriteLine("|    1 - Adicionar remédio   |");
                            Console.WriteLine("|    2 - Buscar remédio      |");
                            Console.WriteLine("|    3 - Localização remédio |");
                            Console.WriteLine("|    4 - Quantidade remédio  |");
                            Console.WriteLine("|    5 - Listar todos        |");
                            Console.WriteLine("|    0 - Sair                |");
                            Console.WriteLine("|----------------------------|");
                            opcao = int.Parse(Console.ReadLine());
                        }
                        else
                        {
                            opcao = 0;
                            Console.WriteLine("Finalizado");
                        }
                        break;

                    case 4:
                        Console.WriteLine("Opção: 4 - Quantidade remédio");
                        Console.WriteLine($"\nQuantidade de remédios cadastrados: {listaRemedios.Capacity}");
                        Console.WriteLine("\nDeseja continuar?\n1 - Sim\n2 - Não");
                        continua = int.Parse(Console.ReadLine());
                        Console.Clear();
                        if (continua == 1)
                        {
                            Console.WriteLine("|----------------------------|");
                            Console.WriteLine("|   Digite a opção desejada  |");
                            Console.WriteLine("|    1 - Adicionar remédio   |");
                            Console.WriteLine("|    2 - Buscar remédio      |");
                            Console.WriteLine("|    3 - Localização remédio |");
                            Console.WriteLine("|    4 - Quantidade remédio  |");
                            Console.WriteLine("|    0 - Sair                |");
                            Console.WriteLine("|----------------------------|");
                            opcao = int.Parse(Console.ReadLine());
                        }
                        else
                        {
                            opcao = 0;
                            Console.WriteLine("Finalizado");
                        }
                        break;

                    case 5:
                        Console.WriteLine("Opção: 5 - Listar todos os remédios\n");
                        
                        listaRemedios.Sort();
                        foreach (string lista in listaRemedios)
                        {
                            Console.WriteLine(lista);
                        }
                        Console.WriteLine("\nDeseja continuar?\n1 - Sim\n2 - Não");
                        continua = int.Parse(Console.ReadLine());
                        Console.Clear();
                        if (continua == 1)
                        {
                            Console.WriteLine("|----------------------------|");
                            Console.WriteLine("|   Digite a opção desejada  |");
                            Console.WriteLine("|    1 - Adicionar remédio   |");
                            Console.WriteLine("|    2 - Buscar remédio      |");
                            Console.WriteLine("|    3 - Localização remédio |");
                            Console.WriteLine("|    4 - Quantidade remédio  |");
                            Console.WriteLine("|    5 - Listar todos        |");
                            Console.WriteLine("|    0 - Sair                |");
                            Console.WriteLine("|----------------------------|");
                            opcao = int.Parse(Console.ReadLine());
                        }
                        else
                        {
                            opcao = 0;
                            Console.WriteLine("Finalizado");
                        }
                        break;
                }

            }


        }
    }
}
