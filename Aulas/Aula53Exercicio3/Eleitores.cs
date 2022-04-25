using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula53Exercicio3
{
    public class Eleitores
    {
        private bool Votou { get; set; }

        public Eleitores( bool votou)
        {
            this.Votou = votou;
        }

        public static Eleitores[] InitializeEleitores()
        {
            return new Eleitores[] {
                    new Eleitores(false),
                    new Eleitores(false),
                    new Eleitores(false),
                    new Eleitores(false),
                    new Eleitores(false),
                    new Eleitores(false),
                    new Eleitores(false),
                    new Eleitores(false),
                    new Eleitores(false),
                    new Eleitores(false),


                };

        }
    }
}