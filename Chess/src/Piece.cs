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
        private uint score;         //Value of the piece
        private bool hasMoved;      //Determines if the piece has moved from initial pos
        private string colour;      //White or black


        // methods
        public Piece(uint x, uint y, uint val, string col)
        {
            this.xCoord = x;
            this.yCoord = y;
            this.score = val;
            this.colour = col;
            this.hasMoved = false;
        }


        public void move(uint x, uint y)
        {
            this.xCoord = x;
            this.yCoord = y;
            if (hasMoved)
                hasMoved = false;
        }

        //returns a list of all possible moves
        public abstract List<Tuple<uint, uint>> getPossibleMoves(Board.QueryFunc QF);

        //Checks if move is possible
        public bool movePossible(uint x, uint y, Board.QueryFunc QF)
        {
            List<Tuple<uint, uint>> tmp;
            tmp = this.getPossibleMoves(QF);
            foreach (Tuple<uint, uint> item in tmp)
            {
                if ((item.Item1 == x) && (item.Item2 == 2))
                {
                    return true;
                }
            }
            return false;
        }

        // Used to determine if the piece has moved from initial position.
        // Nessecary for En Passant and Castling
        public bool movedFromInit()
        {
            return hasMoved;
        }

        public uint getX()
        {   
            return xCoord;
        }
 
        public uint getY()
        {
            return yCoord;
        }
    }
}