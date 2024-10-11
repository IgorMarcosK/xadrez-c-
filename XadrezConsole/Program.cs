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
                Console.Clear();
                Tela.imprimirTabuleiro(partida.tab);

                Console.WriteLine();
                Console.Write("Posição de origem: ");
                Posicao origem = Tela.lerPosicaoXadrez().toPosicao();
                Console.Write("Posição de destino: ");
                Posicao destino = Tela.lerPosicaoXadrez().toPosicao();

                partida.executaMovimento(origem,destino);
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