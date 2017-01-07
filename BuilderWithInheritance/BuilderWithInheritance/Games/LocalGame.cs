using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderWithInheritance.Games
{
    class LocalGame : Game
    {
        public LocalGame( int aiStrength, int boardSize, int level ) 
            : base( boardSize, level )
        {
            AiStrength = aiStrength;
        }

        public int AiStrength { get; }
    }
}
