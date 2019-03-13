using System;
using TabuleiroEntities;
using XadrezEntities;

namespace xadrez_console
{
    class Tela
    {
        public static void ImprimirTabuleiro(Tabuleiro tab)
        {
            for (int i = 0; i < tab.Linhas; i++)
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.Write(8 - i + " ");
                Console.ForegroundColor = ConsoleColor.White;

                for (int j = 0; j < tab.Colunas; j++)
                {
                    if (tab.Peca(i, j) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        ImprimirPeca(tab.Peca(i, j));
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("  A B C D E F G H");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static PosicaoXadrez LerPosicaoXadrez()
        {
            string s = Console.ReadLine();
            char coluna = s[0];
            int linha = int.Parse(s[1] + "");
            return new PosicaoXadrez(coluna, linha);
        }
        public static void ImprimirPeca(Peca peca)
        {
            if (peca.Cor == Cor.Branca)
            {
                Console.Write(peca);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write(peca);
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }
}
