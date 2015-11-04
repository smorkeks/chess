using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Chess.src
{
    public class Game
    {
        // Fields
        Board board;
        Agent white;
        Agent black;

        //Methods
        public Game()
        {
            board = new Board();
            bool doneWhite = false;
            while (!doneWhite)
            {
                Console.WriteLine("Enter type for white player (Only TA so far):");
                string tmp = Console.ReadLine();
                if (tmp == "TA")
                {
                    white = new TerminalAgent("white");
                    doneWhite = true;
                }
                else
                {
                    Console.WriteLine("Please enter a correct value");
                }
            }

            bool doneBlack = false;
            while (!doneBlack)
            {
                Console.WriteLine("Enter type for black player (Only TA so far):");
                string tmp = Console.ReadLine();
                if (tmp == "TA")
                {
                    white = new TerminalAgent("black");
                    doneBlack = true;
                }
                else
                {
                    Console.WriteLine("Please enter a correct value");
                }
            }

            run();

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

                Console.WriteLine("Black players turn!");
                tmp = white.getInput(board);
                board.makeMove("black", tmp.Item1, tmp.Item2, tmp.Item3, tmp.Item4);
                if (board.whiteLost())
                {
                    Console.WriteLine("Black player won!");
                    return;
                }
            }
        }

        static void Main(string[] args)
        {
            new Game();
        }
    }
}