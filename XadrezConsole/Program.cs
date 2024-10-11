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
            Tabuleiro tab = new Tabuleiro(8,8);

            tab.colocarPeca(new Torre(tab, Cor.Preto),new Posicao(0,0));
            tab.colocarPeca(new Torre(tab, Cor.Preto),new Posicao(1,3));
            tab.colocarPeca(new Rei(tab, Cor.Preto),new Posicao(2,4));

            Tela.imprimirTabuleiro(tab);
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