using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace ConsoleApp_LeituraDeListaConversaoJson
{
    class Program
    {
        public static string FormatoJson(List<string> json)
        {
            string jsonData = JsonConvert.SerializeObject(json);
            return jsonData;
        }

        public static bool IsEmpty<T>(List<T> list)
        {
            if (list == null)
            {
                return true;
            }

            return list.Count == 0;
        }

        static void Main(string[] args)
        {
            List<string> listaVideoGames = new List<string>
            {
                "Starcraft",
                "Halo",
                "Legend of Zelda"
            };

            if (IsEmpty(listaVideoGames))
            {
                Console.WriteLine("Lista vazia");
            }
            else
            {
                
                string serializarDadosJson = FormatoJson(listaVideoGames);
                Console.WriteLine(serializarDadosJson);            
            }
    
            Console.ReadKey();
        }
    }
}