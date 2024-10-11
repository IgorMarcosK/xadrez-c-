using System;
using tabuleiro;

namespace XadrezC
{
    class PartidaDeXadrez
    {
        public Tabuleiro tab {get; private set;}
        private int turno;
        private Cor jogadorAtual;
        public bool terminada {get; private set;}

        public PartidaDeXadrez()
        {
            tab = new Tabuleiro(8,8);
            turno = 1;
            jogadorAtual = Cor.Branco;
            terminada = false;
            colocarPecas();
        }
        private void colocarPecas()
        {
            tab.colocarPeca(new Torre(tab,Cor.Preto), new PosicaoXadrez('c',1).toPosicao());
        }
        public void executaMovimento(Posicao origem, Posicao destino)
        {
            Peca p = tab.retirarPeca(origem);
            p.incrimentarQtdMovimento();
            tab.retirarPeca(destino);
            Peca pecaCapturada = tab.retirarPeca(destino);
            tab.colocarPeca(p, destino);
        }
    }
}