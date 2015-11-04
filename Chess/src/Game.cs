using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Chess.src
{
    public class Game
    {
        // Fields
        Board board;
        Agent white;
        Agent black;

        // Terminal deligates
        public delegate void putString(string s);
        public delegate string readString();

        //Methods
        public Game(putString put, readString read)
        {
            board = new Board();
            bool doneWhite = false;
            while (!doneWhite)
            {
                put("Enter type for white player (Only TA so far):");
                string tmp = "TB";//read(); // Console.ReadLine();
                if (tmp == "TA")
                {
                    white = new TerminalAgent("white");
                    doneWhite = true;
                }
                else
                {
                    put("Please enter a correct value");
                }
            }

            bool doneBlack = false;
            while (!doneBlack)
            {
                put("Enter type for black player (Only TA so far):");
                string tmp = "TA";//read(); //Console.ReadLine();
                if (tmp == "TA")
                {
                    black = new TerminalAgent("black");
                    doneBlack = true;
                }
                else
                {
                    put("Please enter a correct value");
                }
            }

            //run();

        }

        void printBoard()
        {
            Piece P;
            for (uint i = 7; i >= 0; i++)
            {
                string tmp = "";
                for (uint j = 0; j < 8; j++)
                {
                    P = board.getPieceAt(j, i);
                    if (P == null)
                        tmp = tmp + "0   ";
                    else
                    {
                        if (P.getColour() == "white")
                            tmp = tmp + "W";
                        else
                            tmp = tmp + "B";

                        if (P is Pawn)
                            tmp = tmp + "p  ";
                        else if(P is Rook)
                            tmp = tmp + "r  ";
                        else if(P is Knight)
                            tmp = tmp + "kn ";
                        else if(P is Bishop)
                            tmp = tmp + "b  ";
                        else if(P is Queen)
                            tmp = tmp + "q  ";
                        else if(P is King)
                            tmp = tmp + "k  ";
                        else
                            tmp = tmp + "ERORR ERROR ERROR";

                    }
                    Console.WriteLine(tmp);
                }
            }
        }

        void run()
        {
            Tuple<uint, uint, uint, uint> tmp;
            while (true)
            {

                Console.WriteLine("White players turn!");
                tmp = white.getInput(board);
                board.makeMove("white", tmp.Item1, tmp.Item2, tmp.Item3, tmp.Item4);
                if (board.blackLost())
                {
                    Console.WriteLine("White player won!");
                    return;
                }
                printBoard();

                Console.WriteLine("Black players turn!");
                tmp = white.getInput(board);
                board.makeMove("black", tmp.Item1, tmp.Item2, tmp.Item3, tmp.Item4);
                if (board.whiteLost())
                {
                    Console.WriteLine("Black player won!");
                    return;
                }
                printBoard();
            }
        }

    }
}