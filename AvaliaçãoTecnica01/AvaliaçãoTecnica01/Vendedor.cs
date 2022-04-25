using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaliaçãoTecnicaExercicio01
{
    public class Vendedor
    {

        public int IdVendedor { get; set; }


        public double Preco { get; set; }

        public int TotalVendas { get; set; }

        public double SomaValores { get; set; }

        public double Comissao { get; set; }

        public Vendedor()
        {
        }

        public Vendedor(double preco)
        {
            Preco = preco;
        }

        public void SomaVendas()
        {
            TotalVendas++;
        }

        public void SomarValores(double venda)
        {
            double soma = SomaValores + venda;
            SomaValores = soma;
        }

        public double CalcularComissao()
        {
            double comissao;
            if (TotalVendas <= 5)
            {
                comissao = SomaValores * 0.004;
                Comissao = comissao;
            }
            if (TotalVendas >= 6 && TotalVendas <= 10)
            {
                comissao = SomaValores * 0.013;
                Comissao = comissao;
            }
            if (TotalVendas >= 11 && TotalVendas <= 15)
            {
                comissao = SomaValores * 0.03;
                Comissao = comissao;
            }
            if (TotalVendas >= 16)
            {
                comissao = SomaValores * 0.05;
                Comissao = comissao;
            }
            return Comissao;
        }

        public override string ToString()
        {
            return "----------------------------------\n\tComissão a receber\n----------------------------------" +
                   "\nId do vendedor: " + IdVendedor + "\nValor total das vendas: R$" +
                SomaValores + "\nTotal de vendas: " + TotalVendas + "\nComissão total: R$" + CalcularComissao() + "\n----------------------------------";
        }
    }
}
