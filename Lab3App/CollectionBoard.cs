﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    class CollectionBoard
    {
        public int TotalScore, TotalValue;

        public CollectionBoard() { 
            TotalScore = 0; 
            TotalValue = 0;
        }
        public CollectionBoard(int sc, int vl) {
            this.TotalScore = sc;
            this.TotalValue = vl;
        }
    }
}
