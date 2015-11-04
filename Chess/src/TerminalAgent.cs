using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Chess.src
{
    public class TerminalAgent : Agent
    {
        //Methods
        TerminalAgent(string col) : base(col) {}

        public override Tuple<uint, uint, uint, uint> getInput(Board B)
        {
            Console.WriteLine(getColour() + " players turn. Please input the four values xfrom, yfrom, xto and yto as 4 numbers between 0 and 7 with no spaces, for example 0103:");
            string inp = Console.ReadLine();
            uint xFrom = (uint)inp[0];
            uint yFrom = (uint)inp[1];
            uint xTo = (uint)inp[2];
            uint yTo = (uint)inp[3];
            return new Tuple<uint, uint, uint, uint>(xFrom, yFrom, xTo, yTo);
        }

    }
}