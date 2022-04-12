using System;

namespace Aula01_Jogo
{
    internal class NumeroRandomico
    {
        static void Main(string[] args)
        {
            int chute;
            int sorteio = new Random().Next(1, 5);
            string resp;
            int tentativas = 0;


            Console.WriteLine("Tente descobrir o número que eu pensei.\nDica: número de 1 a 5");
            chute = int.Parse(Console.ReadLine());

            if (chute == sorteio)
            {
                Console.WriteLine("Acertou!\nPensei em {0}.", sorteio);
                tentativas += 1;
                Console.WriteLine("Você acertou em {0} tentativa.", tentativas);
            }
            else
            {
                while (chute != sorteio)
                {


                    Console.WriteLine("Errou. Pensei em {0}.\nDeseja tentar novamente? Digite sim ou não.", sorteio);
                    resp = Console.ReadLine();
                    if (resp == "sim")
                    {
                        Console.WriteLine("Digite novamente um número.\nDica: número de 1 a 5");
                        sorteio = new Random().Next(1, 5);
                        chute = int.Parse(Console.ReadLine());
                        tentativas += 1;
                        if (chute == sorteio)
                        {
                            tentativas += 1;
                            Console.WriteLine("Acertou!\nPensei em {0}.", sorteio);
                            Console.WriteLine("Você acertou em {0} tentativas", tentativas);
                        }
                    }
                    else
                    {


                        Console.WriteLine("Finalizado!");
                        tentativas += 1;
                        if (tentativas == 1)
                        {
                            Console.WriteLine("Você desistiu em {0} tentativa", tentativas);
                        }
                        else
                        {
                            Console.WriteLine("Você desistiu em {0} tentativas", tentativas);
                        }
                        break;
                    }


                }



            }

        }
    }
}
