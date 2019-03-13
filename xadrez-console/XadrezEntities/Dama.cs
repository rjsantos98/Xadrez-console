using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TabuleiroEntities;

namespace XadrezEntities
{
    class Dama : Peca
    {
        public Dama(Tabuleiro tab, Cor cor) : base(tab, cor)
        {
        }

        public override bool[,] MovimentosPossiveis()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return "D";
        }

    }
}
