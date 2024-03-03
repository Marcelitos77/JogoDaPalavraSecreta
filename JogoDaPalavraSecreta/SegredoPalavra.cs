using System;

namespace SegredoPalavra
{
    class JogoSegredo
    {
        string palavraSecreta;
        string descricao;
        int tentativasRestantes;

        public JogoSegredo(string palavra, string desc)
        {
            palavraSecreta = palavra.ToLower();
            descricao = desc;
            tentativasRestantes = 5;
        }

        public void Jogar()
        {
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