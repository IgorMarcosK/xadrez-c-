namespace tabuleiro
{
    abstract class Peca
    {
        public Posicao posicao {get; set;}
        public Cor cor {get; protected set;}
        public int movimentos {get; protected set;}
        public Tabuleiro tab { get; protected set;}

        public Peca(Tabuleiro tab, Cor cor)
        {
            this.posicao = null;
            this.tab = tab;
            this.cor = cor;
            this.movimentos = 0;
        }
        public void incrimentarQtdMovimento()
        {
            movimentos++;
        }
        public abstract bool[,] movimentosPossiveis();
    }
}