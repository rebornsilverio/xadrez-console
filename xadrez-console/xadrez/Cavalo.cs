using tabuleiro;

namespace xadrez
{
	class Cavalo : Peca
	{
		public Cavalo(Tabuleiro tab, Cor cor) : base(tab, cor)
		{
		}

		private bool podeMover(Posicao pos)
		{
			Peca p = tab.peca(pos);
			return p == null || p.cor != cor;
		}

		public override bool[,] movimentosPossiveis()
		{
			bool[,] mat = new bool[tab.linhas, tab.colunas];
			Posicao pos = new Posicao(0, 0);

			// nordeste alto
			pos.definirValores(posicao.linha - 2, posicao.coluna + 1);
			if (tab.posicaoValida(pos) && podeMover(pos))
			{
				mat[pos.linha, pos.coluna] = true;
			}

			// nordeste baixo
			pos.definirValores(posicao.linha - 1, posicao.coluna + 2);
			if (tab.posicaoValida(pos) && podeMover(pos))
			{
				mat[pos.linha, pos.coluna] = true;
			}

			// sudeste alto
			pos.definirValores(posicao.linha + 1, posicao.coluna + 2);
			if (tab.posicaoValida(pos) && podeMover(pos))
			{
				mat[pos.linha, pos.coluna] = true;
			}

			// sudeste baixo
			pos.definirValores(posicao.linha + 2, posicao.coluna + 1);
			if (tab.posicaoValida(pos) && podeMover(pos))
			{
				mat[pos.linha, pos.coluna] = true;
			}

			// sudoeste baixo
			pos.definirValores(posicao.linha + 2, posicao.coluna - 1);
			if (tab.posicaoValida(pos) && podeMover(pos))
			{
				mat[pos.linha, pos.coluna] = true;
			}

			// sudoeste alto
			pos.definirValores(posicao.linha + 1, posicao.coluna - 2);
			if (tab.posicaoValida(pos) && podeMover(pos))
			{
				mat[pos.linha, pos.coluna] = true;
			}

			// noroeste baixo
			pos.definirValores(posicao.linha - 1, posicao.coluna - 2);
			if (tab.posicaoValida(pos) && podeMover(pos))
			{
				mat[pos.linha, pos.coluna] = true;
			}

			// noroeste alto
			pos.definirValores(posicao.linha - 2, posicao.coluna - 1);
			if (tab.posicaoValida(pos) && podeMover(pos))
			{
				mat[pos.linha, pos.coluna] = true;
			}

			return mat;
		}

		public override string ToString()
		{
			return "N";
		}


	}
}
