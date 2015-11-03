using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Chess.src
{    
    public abstract class Piece
    {
        // fields
        private uint xCoord;
        private uint yCoord;
        private uint score;

        // methods
        void move(uint x, uint y)
        {
            if (movePossible(x,y))
            {
                this.xCoord = x;
                this.yCoord = y;
            }
        }

        bool movePossible(uint x, uint y)
        {

        }
    }
}