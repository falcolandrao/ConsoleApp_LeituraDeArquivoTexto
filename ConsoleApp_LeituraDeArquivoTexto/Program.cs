using System;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

namespace ConsoleApp_LeituraDeArquivoTexto
{
    class Program
    {
        public static string FormatoJson(string json)
        {
            string jsonData = JsonConvert.SerializeObject(json);
            return jsonData;
        }

        static void Main(string[] args)
        {
            String lerArquivo = @"C:\Estudos\C#\ConsoleApp_LeituraDeArquivoTexto\ler_arquivo.txt";

            string[] linhasLidas = File.ReadAllLines(lerArquivo);

            if (linhasLidas.Length == 0)
            {
                Console.WriteLine("ARQUIVO EM BRANCO");
            }
            else
            {
                using (System.IO.StreamWriter escreverLinhaJson = new System.IO.StreamWriter(@"C:\Estudos\C#\ConsoleApp_LeituraDeArquivoTexto\Resultado.txt"))
                {
                    foreach (var linha in linhasLidas)
                    {
                        if (linha != "")
                        {
                            string serializarDadosJson = FormatoJson(linha);
                            escreverLinhaJson.WriteLine(serializarDadosJson);
                        }
                    }
                }
            }

            Console.ReadKey();
        }
    }
}