using System;

namespace Aula51
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dia = 19;
            int mes = 04;
            int ano = 2022;

            DateTime dtAniversario = new DateTime(ano, mes, dia);
            DateTime dtFesta = new DateTime(2022, 10, 22);

            Console.WriteLine("Funções de Data");
            Console.WriteLine($"Aniversário: {dtAniversario}");
            Console.WriteLine($"Aniversário: {dtAniversario:ddd dd/MM/yyyy}");
            Console.WriteLine($"Aniversário: {dtAniversario:dddd dd/MM/yyyy}");
            Console.WriteLine($"Aniversário: {dtAniversario:MMM dd/MM/yyyy}");

            Console.WriteLine("----------------------------");
            Console.WriteLine("Funções de data - TODAY");

            DateTime hoje = DateTime.Today;
            DateTime hora = DateTime.Now;

            Console.WriteLine($"Today: {hoje:dd/MM/yyyy}");
            Console.WriteLine($"Now: {hora:HH:mm:ss}");

            Console.WriteLine("----------------------------");
            Console.WriteLine("Conversão data string para DateTime");

            string dataTexto = "19/04/2022";
            DateTime dataTextoConvertido;

            //TryParse para efetuar conversão da string para datetime

            if (DateTime.TryParse(dataTexto, out dataTextoConvertido))
            {
                Console.WriteLine("\nData convertida com sucesso!");
            }
            else
            {
                Console.WriteLine("\nErro na conversão!");
            }

            Console.WriteLine("----------------------------");
            Console.WriteLine("Funções de data - Day, Month and Year");


            Console.WriteLine($"Data de agora: {hoje:dd/MM/yyyy} {hora:HH:mm:ss}");
            Console.WriteLine($"Dia: {hoje:dd}");
            Console.WriteLine($"Mês: {hoje:MM}");
            Console.WriteLine($"Ano: {hoje:yyyy}");

            Console.WriteLine("----------------------------");
            Console.WriteLine("Funções de data - Manipulação");

            int dtDia = 24;
            int dtMes = 05;
            int dtAno = 2022;

            DateTime dataFutura = new DateTime(dtAno, dtMes, dtDia);

            Console.WriteLine($"{dataFutura}");



        }
    }
}