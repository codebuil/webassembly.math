using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cripts
{

    internal class Program
    {
        public static string Criptografar(string entrada)
        {
            string saida = "";

            foreach (char c in entrada)
            {
                // Adiciona 32 ao valor ASCII do caractere e converte de volta para char
                char novoCaractere = (char)(c + 32);

                // Adiciona o novo caractere à string de saída
                saida += novoCaractere;
            }

            return saida;
        }
        static void Main(string[] args)

        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            if (args.Count() > 0)
            {
                // Caminho para o arquivo a ser lido
                string filePath = args[0];

                try
                {
                    // Lê o arquivo para uma string
                    string fileContent = File.ReadAllText(filePath);

                    // Exibe o conteúdo do arquivo
                    Console.WriteLine(Criptografar(fileContent));
                }
                catch (IOException e)
                {
                    Console.WriteLine("Ocorreu um erro ao ler o arquivo: " + e.Message);
                }
            }
        }


    }
}
