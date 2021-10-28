using System;

namespace NetDiretoAoPonto.TrabalhandoComStrings
{
    class Program
    {
        static void Main(string[] args)
        {

            var paragrafo = "   C# é uma linguagem moderna e versátil. " +
                "Com C# consigo desenvolver para Web, Desktop, Jogos," +
                "Mobile, entre outros. ";


            // Length
            var tamanho = paragrafo.Length;

            // Empty
            var vazio = string.Empty;

            // ToLower, ToUpper
            var paragrafoMinusculo = paragrafo.ToLower();
            var paragrafoMaiusculo = paragrafo.ToUpper();

            // Split 
            var frases = paragrafo.Split('.');

            // Trim, TrimEnd, TrimStart
            var pargrafoTrim = paragrafo.Trim();
            var paragrafoTrimEnd = paragrafo.TrimEnd();
            var paragrafoTrimStart = paragrafo.TrimStart();

            // IsNullOrWhitespace
            var isNullOrWhitespace = string.IsNullOrWhiteSpace(paragrafo);

            // Replace
            var paragrafoReplace = paragrafo.Replace("C#", "C-Sharp"); 



        }
    }
}
