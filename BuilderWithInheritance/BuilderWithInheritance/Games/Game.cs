using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderWithInheritance
{
    abstract class Game
    {
        public Game( int boardSize, int level )
        {
            BoardSize = boardSize;
            Level = level;
        }

        public int BoardSize { get; }

        public int Level { get; }
    }
}
