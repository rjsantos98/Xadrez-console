using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabuleiroEntities
{
    class Tabuleiro
    {
        public int Linhas { get; set; }
        public int Colunas { get; set; }
        private readonly Peca[,] pecas;

        public Tabuleiro (int linhas, int colunas)
        {
            Linhas = linhas;
            Colunas = colunas;
            pecas = new Peca[linhas, colunas];
        }
        public Peca Peca(int linha, int coluna)
        {
            return pecas[linha, coluna];
        }
        public void ColocarPeca(Peca peca, Posicao pos)
        {
            pecas[pos.Linha, pos.Coluna] = peca;
            peca.Posicao = pos;
        }
    }
}
