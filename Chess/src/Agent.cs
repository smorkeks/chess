using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Chess.src
{
    public class Agent
    {
        // Fields



        // Methods
        public abstract Tuple<uint, uint, uint, uint> getInput(Board B);
    }
}