using System;

namespace SegredoPalavra
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a palavra secreta:");
            string palavra = Console.ReadLine();

            Console.Clear();

            Console.WriteLine("Digite a descricao:");
            string descricao = Console.ReadLine();

            JogoSegredo jogo = new JogoSegredo(palavra, descricao);
            jogo.Jogar();
        }

    }

}