using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tabuleiro;

namespace XadrezC
{
    class Program 
    {
        static void Main(string[] args)
        {
            Tabuleiro tab = new Tabuleiro(8,8);
            Tela.imprimirTabuleiro(tab);
            ///System.Console.WriteLine("tabuleiro: "+ tab.linhas);
            Console.ReadLine();

        }
    }
}