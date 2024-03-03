using System;

namespace JogoPalavraSecreta
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a palavra secreta:");
            string palavraSecreta = Console.ReadLine().ToLower();

            Console.Clear();

            Console.WriteLine("Digite a descricao:");
            string descricao = Console.ReadLine();

            int tentativasRestantes = 5;

            Console.Clear();
            Console.WriteLine($"A descrição é: {descricao}");
            Console.WriteLine("Você tem 5 tentativas");

            while (tentativasRestantes > 0)
            {
                Console.Write("Digite sua resposta: ");
                string tentativa = Console.ReadLine().ToLower();

                if (tentativa == palavraSecreta)
                {
                    Console.Clear();
                    Console.WriteLine("Parabéns! Você descobriu a palavra!");
                    Console.WriteLine($"{palavraSecreta}");
                    return;
                }
                else
                {
                    tentativasRestantes--;
                    Console.Clear();
                    Console.WriteLine($"Resposta incorreta. Tentativas restantes: {tentativasRestantes}");
                }
            }

            Console.Clear();
            Console.WriteLine("Fim do Jogo! Você perdeu!");
        }
    }
}