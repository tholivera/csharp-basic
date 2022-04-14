using System;

namespace CalculoMedias
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] alunos = new string[4];
            double[] notas = new double[4];
            double soma = 0;
            double media;
            int aprovado = 0, reprovado = 0, recuperação = 0;

            for (int i = 0; i < alunos.Length; i++)
            {
                Console.WriteLine($"Digite o nome do aluno {i + 1}");
                alunos[i] = Console.ReadLine();
                for (int j = 0; j < notas.Length; j++)
                {

                    Console.WriteLine($"\nDigite a nota do {j + 1} bimestre do(a) aluno(a) {alunos[i]} ");
                    notas[j] = double.Parse(Console.ReadLine());
                    soma += notas[j];
                }
                media = soma / notas.Length;
                Console.WriteLine($"\nA média do aluno é {media}");

                if (media >= 5)
                {
                    Console.WriteLine($"A situação do(a) aluno(a) {alunos[i]} é: APROVADO\n");
                    aprovado += 1;
                }
                else if (media < 5 && media >= 3)
                {
                    Console.WriteLine($"A situação do(a) aluno(a) {alunos[i]} é: RECUPERAÇÃO\n");
                    recuperação += 1;
                }
                else
                {
                    Console.WriteLine($"A situação do(a) aluno(a) {alunos[i]} é: REPROVADO\n");
                    reprovado += 1;
                }

                soma = 0;
                Console.WriteLine("----------------------------------------------\n");
            }

            Console.WriteLine($"Quantidade de alunos APROVADOS: {aprovado}\n");
            Console.WriteLine($"Quantidade de alunos em RECUPERAÇÃO: {recuperação}\n");
            Console.WriteLine($"Quantidade de alunos REPROVADOS: {reprovado}\n");

        }

    }
}
