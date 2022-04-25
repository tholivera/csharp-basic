using System;

namespace AvaliaçãoTecnica02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int chute;
            int sorteio = new Random().Next(1, 5);
            string resp;
            int tentativas = 0, passouPertoMais=0, passouPertoMenos = 0;


            Console.WriteLine("Tente descobrir o número que eu pensei.\nDica: número de 1 a 5");
            chute = int.Parse(Console.ReadLine());

            if (chute == sorteio)
            {
                Console.WriteLine("\nAcertou de primeira!\nPensei em {0}.", sorteio);
                tentativas += 1;
                Console.WriteLine("\nVocê acertou em {0} tentativa.", tentativas);
            }
            else
            {
                while (chute != sorteio)
                {
                    if (sorteio == (chute - 1))
                    {
                        passouPertoMais += 1;
                    }
                    else if (sorteio == (chute + 1))
                    {
                        passouPertoMenos += 1;
                    }


                    Console.WriteLine("\nXiiii! Errou. Pensei em {0}.\n\nDeseja tentar novamente? Digite sim ou não.", sorteio);
                    resp = Console.ReadLine();
                    if (resp == "sim")
                    {
                        Console.WriteLine("\nDigite novamente um número.\nDica: número de 1 a 5");
                        sorteio = new Random().Next(1, 5);
                        chute = int.Parse(Console.ReadLine());
                        tentativas += 1;
                        if (chute == sorteio)
                        {
                            tentativas += 1;
                            Console.WriteLine("\nAcertou!\nPensei em {0}.", sorteio);
                            Console.WriteLine("Você acertou em {0} tentativas", tentativas);
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nFinalizado!");
                        tentativas += 1;
                        if (tentativas == 1)
                        {
                            Console.WriteLine("\nVocê desistiu em {0} tentativa", tentativas);
                        }
                        else
                        {
                            Console.WriteLine("\nVocê desistiu em {0} tentativas", tentativas);
                        }
                        break;
                    }
                }
            }

            Console.WriteLine($"\nDurante as tentativas, você se aproximou do número com a diferença de 1 para menos: {passouPertoMenos} vez(es)");
            Console.WriteLine($"\nDurante as tentativas, você se aproximou do número com a diferença de 1 para mais: {passouPertoMais} vez(es)");
        
        }
    }
}
