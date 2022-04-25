using System;

namespace Aula53Exercicio3
{
    internal class Program
    {
        


        static void Main(string[] args)
        {
            Eleitores[] listaEleitores = {
                new Eleitores("123", 1, false),
                new Eleitores("456", 1, false),
                new Eleitores("789", 1, false),
                new Eleitores("223", 1, false),
                new Eleitores("323", 1, false),
                new Eleitores("423", 1, false),
                new Eleitores("523", 1, false),
                new Eleitores("623", 1, false),
                new Eleitores("723", 1, false)



            };
            foreach (Eleitores eleitores in listaEleitores)
            {
                Console.WriteLine("Digite seu titulo: ");
                string tituloDigitado = Console.ReadLine();
                if (tituloDigitado == eleitores.titulo)
                {
                    eleitores.votar(eleitores);
                }
                else
                {
                    Console.WriteLine("Titulo Invalido");
                }



            }
        }
    }
}