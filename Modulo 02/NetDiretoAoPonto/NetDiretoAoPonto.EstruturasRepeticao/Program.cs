using System;

namespace NetDiretoAoPonto.EstruturasRepeticao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma sequência de números separados por espaço. ");
            // 0 1 2 3 4 5 6 7 8 9 

            var numerosTexto = Console.ReadLine();

            var numeros = numerosTexto.Split(' ');

            Console.WriteLine("Números: ");

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine(numeros[i]);
                // 0 1 2 3 4
            }


            Console.WriteLine("Usando while: ");

            var contador = 0;

            while (contador < numeros.Length)
            {
                Console.WriteLine(numeros[contador]);

                contador++;
            }


            Console.WriteLine("Usando ForEach: ");

            foreach (var numero in numeros)
            {
                Console.WriteLine(numero);
            }

            Console.ReadKey();

        }
    }
}
