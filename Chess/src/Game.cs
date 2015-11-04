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
            Console.WriteLine("White players turn!");
            Tuple<uint, uint, uint, uint> tmp = white.getInput(board);
        }

        static void Main(string[] args)
        {
            new Game();
        }
    }
}