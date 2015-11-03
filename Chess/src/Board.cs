using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;

namespace Chess.src
{
    public class Board
    {
        // --- Fields ---

        // Board [0,0] is at down, left.
        private const uint BOARD_SIZE_X = 8;
        private const uint BOARD_SIZE_Y = 8;

        // List of squares
        private Square[,] squares = new Square[BOARD_SIZE_X, BOARD_SIZE_Y];

        // Reward function for board position.
        private int[,] reward = new int[,] { { 0, 0, 0, 0, 0, 0, 0, 0 },
                                             { 0, 1, 1, 1, 1, 1, 1, 0 },
                                             { 0, 1, 2, 2, 2, 2, 1, 0 },
                                             { 0, 1, 2, 3, 3, 2, 1, 0 },
                                             { 0, 1, 2, 3, 3, 2, 1, 0 },
                                             { 0, 1, 2, 2, 2, 2, 1, 0 },
                                             { 0, 1, 1, 1, 1, 1, 1, 0 },
                                             { 0, 0, 0, 0, 0, 0, 0, 0 } };

        // Passed to Pieces to limit access to board.
        public static delegate Square QueryFunc(uint x, uint y);

        // --- Constructor ---
        public Board()
        {
            // Create squares
            for (uint y = 0; y < BOARD_SIZE_Y; y++)
            {
                for (uint x = 0; x < BOARD_SIZE_X; x++)
                {
                    squares[x, y] = new Square(x, y, reward[x,y]);
                }
            }

            // Create white pieces


            // Create black pieces


            // Add cover
            QueryFunc qf = getPieceAt;
            foreach (Square s in squares)
            {
                Piece p = s.getPiece();

                if (p != null)
                {
                    List<Tuple<uint, uint>> cover = p.getPossibleMoves(qf);
                    foreach (Tuple<uint, uint> t in cover)
                    {
                        if (p.getColor() == "white")
                        {
                            squares[t.Item1, t.Item2].addWhiteCover();
                        }
                        else
                        {
                            squares[t.Item1, t.Item2].addBlackCover();
                        }
                        
                    }
                }
            }
        }


        // --- Methods ---
        public Square getPieceAt(uint x, uint y)
        {
            // Check if outside board
            if (x >= BOARD_SIZE_X || y >= BOARD_SIZE_Y){
                return null;
            }

            // Get piece or null
            return squares[x, y].getPiece();
        }
    }
}