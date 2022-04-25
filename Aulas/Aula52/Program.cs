using System;

namespace Aula52
{
    internal class Program
    {
        public class Pedido
        {

            public int PedidoId { get; set; }
            public DateTime DtPedido { get; set; }

            public DateTime DtVencimento => DtPedido.AddDays(30);

            public DateTime DtPagamento { get; set; }

            public TimeSpan DiasAtraso() => DtPagamento.Subtract(DtVencimento);

            public decimal Valor { get; set; }

            public decimal Multa => Valor * 0.10M;

        }


        static void Main(string[] args)
        {
            var pedido = new Pedido
            {
                PedidoId = 1,
                DtPedido = DateTime.Today,
                DtPagamento = DateTime.Today.AddDays(45),
                Valor = 1500
            };
            Console.WriteLine($"Pedido: {pedido.PedidoId}\nData: {pedido.DtPedido:dd/MM/yyyy}\nVencimento: {pedido.DtVencimento:dd/MM/yyyy}");
            Console.WriteLine($"Dias em atraso: {pedido.DiasAtraso().TotalDays}");
            Console.WriteLine($"Valor do produto: {pedido.Valor}");
            Console.WriteLine($"Multa: {pedido.Multa}");
            Console.WriteLine($"Total com multa por atraso: {pedido.Valor + pedido.Multa}");


        }
    }
}
