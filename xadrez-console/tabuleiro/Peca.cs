﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tabuleiro
{
    abstract class Peca
    {
        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; }
        public int qntMovimentos { get; protected set; }
        public Tabuleiro tab { get; protected set; }

        public Peca(Tabuleiro tab,Cor cor)
        {
            this.posicao = null;
            this.tab = tab;
            this.cor = cor;
            this.qntMovimentos = 0;
        }

        public void incrementarQtdMovimentos()
        {
            this.qntMovimentos++;
        }
        public abstract bool[,] movimentosPossiveis();
        

        
    }
}
