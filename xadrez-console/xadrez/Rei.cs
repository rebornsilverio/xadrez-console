using tabuleiro;

namespace xadrez
{
	class Rei : Peca
	{
		public Rei(Tabuleiro tab, Cor cor) : base(tab, cor)
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

			// norte (n)
			pos.definirValores(posicao.linha - 1, posicao.coluna);
			if (tab.posicaoValida(pos) && podeMover(pos))
			{
				mat[pos.linha, pos.coluna] = true;
			}

			// nordeste (ne)
			pos.definirValores(posicao.linha - 1, posicao.coluna + 1);
			if (tab.posicaoValida(pos) && podeMover(pos))
			{
				mat[pos.linha, pos.coluna] = true;
			}

			// leste (l)
			pos.definirValores(posicao.linha, posicao.coluna + 1);
			if (tab.posicaoValida(pos) && podeMover(pos))
			{
				mat[pos.linha, pos.coluna] = true;
			}

			// sudeste (se)
			pos.definirValores(posicao.linha + 1, posicao.coluna + 1);
			if (tab.posicaoValida(pos) && podeMover(pos))
			{
				mat[pos.linha, pos.coluna] = true;
			}

			// sul (s)
			pos.definirValores(posicao.linha + 1, posicao.coluna);
			if (tab.posicaoValida(pos) && podeMover(pos))
			{
				mat[pos.linha, pos.coluna] = true;
			}

			// sudoeste (so)
			pos.definirValores(posicao.linha + 1, posicao.coluna - 1);
			if (tab.posicaoValida(pos) && podeMover(pos))
			{
				mat[pos.linha, pos.coluna] = true;
			}

			// oeste (o)
			pos.definirValores(posicao.linha, posicao.coluna - 1);
			if (tab.posicaoValida(pos) && podeMover(pos))
			{
				mat[pos.linha, pos.coluna] = true;
			}

			// noroeste (no)
			pos.definirValores(posicao.linha - 1, posicao.coluna - 1);
			if (tab.posicaoValida(pos) && podeMover(pos))
			{
				mat[pos.linha, pos.coluna] = true;
			}

			return mat;
		}

		public override string ToString()
		{
			return "R";
		}


	}
}
