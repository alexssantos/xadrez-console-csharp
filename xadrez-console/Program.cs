﻿using tabuleiro;
using xadrez;
using System;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {

            #region try
            //try { 
            //    Tabuleiro tab = new Tabuleiro(8, 8);

            //    //colocar peça no tabuleiro.
            //    tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
            //    tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));
            //    tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(0, 8));

            //    Tela.imprimirTabuleiro(tab);
            //}
            //catch(TabuleiroException e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            #endregion

            try
            {
                PartidaDeXadrez partida = new PartidaDeXadrez();

                Tela.imprimirTabuleiro(partida.tab);
            }
            catch(TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }
                      
            Console.ReadLine();


        }
    }
}
