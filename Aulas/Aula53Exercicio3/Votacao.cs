using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula53Exercicio3
{
    internal class Votacao
    {
        int titulo;

                

                

            public void InitializeVotacao()
        {
            Candidatos[] todosCandidatos = Candidatos.InitializeCandidatos();
            Eleitores[] todosEleitores = Eleitores.InitializeEleitores();

            Console.WriteLine("|----------------------------|");
            Console.WriteLine("|      Digite seu título     |");
            Console.WriteLine("|----------------------------|");
            titulo = int.Parse(Console.ReadLine());

            Eleitores votou = new Eleitores(false);

            if (this.votou = true)
            {

            }

            Console.WriteLine("|----------------------------|");
            Console.WriteLine("|Digite o número do candidato|");
            Console.WriteLine("|         13 - Aldair        |");
            Console.WriteLine("|         25 - Mussim        |");
            Console.WriteLine("|         37 - Rosana        |");
            Console.WriteLine("|         00 - Branco        |");
            Console.WriteLine("|         01 - Nulo          |");
            Console.WriteLine("|----------------------------|");

            if ()
        }
    }
    
}
