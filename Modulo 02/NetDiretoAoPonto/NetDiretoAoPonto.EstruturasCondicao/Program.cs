using System;

namespace NetDiretoAoPonto.EstruturasCondicao
{
    class Program
    {
        static void Main(string[] args)
        {
            var notaDigitada = Console.ReadLine();
            var nota = int.Parse(notaDigitada);

            // if / Else
            if(nota >= 70)
            {
                Console.WriteLine("Aprovado");
            } else if ( nota >= 40 ){
                Console.WriteLine("Em Recuperação");
            } else
            {
                Console.WriteLine("Reprovado");
            }

            // Switch / Case
            Console.WriteLine("seja Bem vindo  a Empresa X.");

            Console.WriteLine("Digite 1 - Contrataçao de um plano.");
            Console.WriteLine("Digite 2 - Reclamação de serviço prestado.");
            Console.WriteLine("Digite 3 - Segunda via de boleto.");
            Console.WriteLine("Digite 4 - Sair");

            var opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Console.WriteLine("Informações de plano novo.");
                    break;
                case "2":
                    Console.WriteLine("Fale sobre sua Reclamação");
                    break;
                case "3":
                    Console.WriteLine("Segunda Via de boleto enviada por e-mail");
                    break;
                case "4":
                    Console.WriteLine("Tenha um Bom dia");
                    break;
                default:
                    Console.WriteLine("Opçõ não Encontrada");
                    break;
            }
        }
    }
}
