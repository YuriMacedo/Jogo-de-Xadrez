using System;
using tabuleiro;
using xadrez;
using Xadrez_Console.xadrez;

namespace Xadrez_Console
{
    class Program
    {
        static void Main(string[] args)
        {
             try
             {
                PartidaDeXadrez partida = new PartidaDeXadrez();

                while (!partida.terminada)
                {
                    Console.Clear();
                    Tela.imprimirTabuleiro(partida.tab);

                    Console.WriteLine();
                    Console.WriteLine("Origem: ");
                    Posicao origem = Tela.lerPosicaoXadrez().toPosicao();
                    Console.WriteLine("Destino: ");
                    Posicao destino = Tela.lerPosicaoXadrez().toPosicao();

                    partida.executaMovimento(origem, destino);
                }

                Tela.imprimirTabuleiro(partida.tab);




             }
             catch (TabuleiroException e)
             {

                 Console.WriteLine(e.Message);
             }

            
            
        }
    }
}
