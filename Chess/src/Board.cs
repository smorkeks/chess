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

        private List<Piece> whitePieces;
        private List<Piece> blackPieces;

        private int[,] whiteCover = new int[BOARD_SIZE_X, BOARD_SIZE_Y];
        private int[,] whiteCover = new int[BOARD_SIZE_X, BOARD_SIZE_Y];

        private int[,] reward = new int[BOARD_SIZE_X, BOARD_SIZE_Y];

        // Passed to piece to limit access to board.
        public static delegate Piece QueryFunc(uint x, uint y);

        // Constructor
        public Board()
        {
            // Initialize white pieces
            whitePieces = new List<Piece>();

            // Initialize black pieces
            blackPieces = new List<Piece>();

            // Get white cover
            QueryFunc qf = getPieceAt;
            foreach (Piece p in whitePieces)
            {
                List<Tuple<uint, uint>> cover = p.getPossibleMoves(qf);
            }

            // Get black cover
        }


        // Methods

        
        public Piece getPieceAt(uint x, uint y)
        {
            
            // No piece
            return null;
        }
    }
}