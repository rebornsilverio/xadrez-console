using System;
using tabuleiro;
using xadrez;

namespace xadrez_console
{
	class Program
	{
		static void Main(string[] args)
		{
			PartidaDeXadrez partida = new PartidaDeXadrez();

			try
			{
				while (!partida.terminada)
				{
					try
					{

						// Tabuleiro
						Console.Clear();
						Tela.imprimirPartida(partida);

						// Dados de origem
						Console.WriteLine();
						Console.Write("Origem: ");
						Posicao origem = Tela.lerPosicaoXadrez().toPosicao();
						partida.validarPosicaoDeOrigem(origem);

						// Exibe movimentos possíveis
						bool[,] posicoesPossiveis = partida.tab.peca(origem).movimentosPossiveis();
						Console.Clear();
						Tela.imprimirTabuleiro(partida.tab, posicoesPossiveis);
						Console.WriteLine("Turno: " + partida.turno);
						Console.WriteLine("Aguardando: " + partida.jogadorAtual);

						// Dados de destino
						Console.WriteLine();
						Console.WriteLine("Origem: " + origem);
						Console.Write("Destino: ");
						Posicao destino = Tela.lerPosicaoXadrez().toPosicao();
						partida.validarPosicaoDeDestino(origem, destino);

						// Atualiza jogo
						partida.realizarJogada(origem, destino);
					}
					catch (TabuleiroException e)
					{
						Console.WriteLine(e.Message);
						Console.ReadLine();
					}
				}


			}
			catch (TabuleiroException e)
			{
				Console.WriteLine(e.Message);
			}

			// Tabuleiro
			Console.Clear();
			Tela.imprimirPartida(partida);

			Console.ReadLine();
		}
	}
}
