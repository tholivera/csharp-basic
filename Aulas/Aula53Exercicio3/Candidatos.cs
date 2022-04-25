using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula53Exercicio3
{
    internal class Candidatos
    {
        public int Candidato { get; set; }


        public Candidatos(int candidato)
        {
            this.Candidato = candidato;

        }
        public override string ToString() => $"{Candidato}";

        public static Candidatos[] InitializeCandidatos()
        {
            return new Candidatos[] {
                    new Candidatos(13),
                    new Candidatos(25),
                    new Candidatos(37)
            };

        }
    }
}
