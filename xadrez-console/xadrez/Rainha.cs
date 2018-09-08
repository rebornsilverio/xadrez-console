using tabuleiro;

namespace xadrez
{
	class Rainha : Peca
	{
		public Rainha(Tabuleiro tab, Cor cor) : base(tab, cor)
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
			while (tab.posicaoValida(pos) && podeMover(pos))
			{
				mat[pos.linha, pos.coluna] = true;
				if (tab.peca(pos) != null && tab.peca(pos).cor != cor)
				{
					break;
				}
				pos.linha--;
			}

			// sul (s)
			pos.definirValores(posicao.linha + 1, posicao.coluna);
			while (tab.posicaoValida(pos) && podeMover(pos))
			{
				mat[pos.linha, pos.coluna] = true;
				if (tab.peca(pos) != null && tab.peca(pos).cor != cor)
				{
					break;
				}
				pos.linha++;
			}

			// leste (l)
			pos.definirValores(posicao.linha, posicao.coluna + 1);
			while (tab.posicaoValida(pos) && podeMover(pos))
			{
				mat[pos.linha, pos.coluna] = true;
				if (tab.peca(pos) != null && tab.peca(pos).cor != cor)
				{
					break;
				}
				pos.coluna++;
			}

			// oeste (o)
			pos.definirValores(posicao.linha, posicao.coluna - 1);
			while (tab.posicaoValida(pos) && podeMover(pos))
			{
				mat[pos.linha, pos.coluna] = true;
				if (tab.peca(pos) != null && tab.peca(pos).cor != cor)
				{
					break;
				}
				pos.coluna--;
			}

			// nordeste (ne)
			pos.definirValores(posicao.linha - 1, posicao.coluna + 1);
			while (tab.posicaoValida(pos) && podeMover(pos))
			{
				mat[pos.linha, pos.coluna] = true;
				if (tab.peca(pos) != null && tab.peca(pos).cor != cor)
				{
					break;
				}
				pos.linha--;
				pos.coluna++;
			}

			// sudeste (se)
			pos.definirValores(posicao.linha + 1, posicao.coluna + 1);
			while (tab.posicaoValida(pos) && podeMover(pos))
			{
				mat[pos.linha, pos.coluna] = true;
				if (tab.peca(pos) != null && tab.peca(pos).cor != cor)
				{
					break;
				}
				pos.linha++;
				pos.coluna++;
			}

			// sudoeste (so)
			pos.definirValores(posicao.linha + 1, posicao.coluna - 1);
			while (tab.posicaoValida(pos) && podeMover(pos))
			{
				mat[pos.linha, pos.coluna] = true;
				if (tab.peca(pos) != null && tab.peca(pos).cor != cor)
				{
					break;
				}
				pos.linha++;
				pos.coluna--;
			}

			// noroeste (no)
			pos.definirValores(posicao.linha - 1, posicao.coluna - 1);
			while (tab.posicaoValida(pos) && podeMover(pos))
			{
				mat[pos.linha, pos.coluna] = true;
				if (tab.peca(pos) != null && tab.peca(pos).cor != cor)
				{
					break;
				}
				pos.linha--;
				pos.coluna--;
			}

			return mat;
		}

		public override string ToString()
		{
			return "Q";
		}


	}
}
