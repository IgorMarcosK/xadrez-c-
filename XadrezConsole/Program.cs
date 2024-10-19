using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using tabuleiro;
using XadrezC;

namespace XadrezC
{
    class Program 
    {
        static void Main(string[] args)
        {
            try 
            {
            PartidaDeXadrez partida = new PartidaDeXadrez();
            
            while(!partida.terminada)
            {
                try{
                Console.Clear();

                Tela.imprimirTabuleiro(partida.tab);
                Console.WriteLine();
                Console.WriteLine("Turno: "+ partida.turno);
                Console.WriteLine("Aguardando jogada: " + partida.jogadorAtual);

                Console.WriteLine();
                Console.Write("Posição de origem: ");
                Posicao origem = Tela.lerPosicaoXadrez().toPosicao();
                partida.validarPosicaoDeOrigem(origem);

                bool[,] posicoesPossiveis = partida.tab.peca(origem).movimentosPossiveis();

                Console.Clear();
                Tela.imprimirTabuleiro(partida.tab, posicoesPossiveis);

                Console.WriteLine();
                Console.Write("Posição de destino: ");
                Posicao destino = Tela.lerPosicaoXadrez().toPosicao();
                partida.validarPosicaoDeDestino(origem,destino);

                partida.realizaJogada(origem,destino);
                }
                catch(TabuleiroException e)
                {
                    Console.WriteLine(e.Message);
                    Console.ReadLine();
                }
            }
            ///System.Console.WriteLine("tabuleiro: "+ tab.linhas);
            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}