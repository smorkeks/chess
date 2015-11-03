using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Chess.src
{
    public class Pawn : Piece
    {
        public override List<Tuple<uint, uint>> getPossibleMoves(Board.QueryFunc QF)
        {
            List<Tuple<uint, uint>> tmpList = new List<Tuple<uint,uint>>();
            short yMod;

            if (this.colour == "white")
                yMod = 1;
            else
                yMod = -1;

            if (withinBoard((int) getX() - 1, (int) getY() + yMod))
            {
                Square S = QF((uint) (getX() - 1), (uint) (getY() + yMod));
                Piece P = S.getPiece();
                if (P != null)
                {
                    if (!isSameColour(P))
                    {
                        tmpList.Add(new Tuple<uint, uint>((uint)(getX() - 1),(uint)(getY() + yMod)));
                    }
                }
            }

            

            return tmpList;
        }
    }
}