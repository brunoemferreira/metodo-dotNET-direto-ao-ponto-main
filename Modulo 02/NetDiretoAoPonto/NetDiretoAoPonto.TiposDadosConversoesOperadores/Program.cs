using System;

namespace NetDiretoAoPonto.TiposDadosConversoesOperadores
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Tipos de Dados

            int numeroInt = 10;

            int maiorNumeroInt = int.MaxValue;
            int menorNumeroInt = int.MinValue;

            long numeroLong = 1231231231231232;

            long maiorNumeroLong = long.MaxValue;
            long menorNumeroLong = long.MinValue;

            decimal numeroDecimal = 10.52m;

            double numeroDouble = 12.3;
            double menorNumeroDouble = double.MinValue;

            bool verdadeiro = true;
            bool falso = false;

            var numero = 10;

            string nome = "Bruno Eduardo";
            char letra = 'M';

            DateTime entradaEmpresa = new DateTime(2021, 1, 1);
            TimeSpan quantoTempoDeEmpresa = DateTime.Now - entradaEmpresa;

            #endregion

            #region Conversões

            int notaAluno = 10;

            // Conversão implícita
            double notaAlunoDouble = notaAluno;

            // Conversão Explícita
            int numeroDoubleComoInt = (int)notaAlunoDouble;

            // Converão utilizando Convert

            string notaString = "10";

            int notaConvert = Convert.ToInt32(notaString);

            // Conversão utilizando Parse

            int notaParse = int.Parse(notaString);

            if (int.TryParse(notaString, out int notaTryParse))
            {

            }
            else
            {
                Console.WriteLine("Número em formato inválido.");
            }

            #endregion

            #region Operadores

            // Unários ++, --. + e -

            int numeroOperador = 4;

            Console.WriteLine(numeroOperador++); // 4
            Console.WriteLine(numeroOperador--); // 5

            Console.WriteLine(++numeroOperador); // 5
            Console.WriteLine(--numeroOperador); // 4

            Console.WriteLine(numeroOperador); // 4
            Console.WriteLine(-numeroOperador); // -4
            Console.WriteLine(-(numeroOperador)); // 4


            // Binários * 
            var soma = 4 + 5;
            var subtracao = 4 - 5;
            var multiplicacao = 4 * 5;
            var divisao = 20 / 3;
            var divisaoDouble = (double)20 / 3;

            var multiplos = (4 * 5) + 10;

            #endregion

            #region Operadores de Comparação > >= < <=

            Console.WriteLine(4 > 5);
            Console.WriteLine(5 > 5);
            Console.WriteLine(5 >= 5);

            Console.WriteLine(5 < 4);
            Console.WriteLine(5 <= 5);
            Console.WriteLine(5 < 6);

            #endregion

            #region Operadores de Igualdade

            Console.WriteLine(5 == 5);
            Console.WriteLine(5 == 4);

            Console.WriteLine(5 != 5);
            Console.WriteLine(4 != 5);

            #endregion

            #region Operadores Lógicos AND && e OR ||

            var minhaNota = 4;
            var ultimoAno = true;

            if (minhaNota >= 7 && ultimoAno)
            {
                Console.WriteLine("Aprovado e terminou o curso, parabéns !!!");
            }

            if (minhaNota >= 7 || ultimoAno)
            {
                Console.WriteLine("Aprovado!!!");
            }


            Console.WriteLine(true || false); // true
            Console.WriteLine(false || true);  // true 
            Console.WriteLine(true || true);  // true
            Console.WriteLine(false || false); // false

            Console.WriteLine(true && false);  // false
            Console.WriteLine(false && true);  // false 
            Console.WriteLine(true && true);   // true
            Console.WriteLine(false && false); // false

            #endregion


            Console.Read();
        }
    }
}
