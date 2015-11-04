﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Chess.src
{
    public abstract class Agent
    {
        // Fields
        protected string colour;

        // Methods
        public Agent(string col)
        {
            colour = col;
        }

        //Promts the agent to make a move
        public abstract Tuple<uint, uint, uint, uint> getInput(Board B);

        public string getColour()
        {
            return colour;
        }
    }
}