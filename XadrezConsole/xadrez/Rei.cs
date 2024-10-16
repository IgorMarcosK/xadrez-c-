using tabuleiro;

namespace XadrezC{
    class Rei : Peca
    {
        public Rei(Tabuleiro tab, Cor cor) : base(tab, cor)
        {

        }
        public override string ToString()
        {
            return "R";
        }
        private bool podeMover(Posicao pos)
        {
            Peca p = tab.peca(pos);
            return p == null || p.cor != cor;
        }
        public override bool[,] movimentosPossiveis()
        {
            bool[,] mat = new bool[tab.linhas,tab.colunas];
            Posicao pos = new Posicao(0,0);

            //Direção cima
            pos.definirValores(posicao.linha -1, posicao.coluna);
            if(tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }
            //Direção diagonal superior direita
            pos.definirValores(posicao.linha -1, posicao.coluna +1);
            if(tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }
            //Direção direita
            pos.definirValores(posicao.linha , posicao.coluna +1);
            if(tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }
            //Direção diagonal inferior direita
            pos.definirValores(posicao.linha +1, posicao.coluna +1);
            if(tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }
            //Direção baixo
            pos.definirValores(posicao.linha +1, posicao.coluna);
            if(tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }
            //Direção diagonal inferior esquerda
            pos.definirValores(posicao.linha +1, posicao.coluna -1);
            if(tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }
            //Direção esquerda
            pos.definirValores(posicao.linha , posicao.coluna -1);
            if(tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }
            //Direção diagonal superior esquerda
            pos.definirValores(posicao.linha -1, posicao.coluna -1);
            if(tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }
            return mat;
            
        }
    }
}