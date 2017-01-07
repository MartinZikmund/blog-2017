using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderWithInheritance.Games
{
    class LocalGame : Game
    {
        public LocalGame( int aiStrength, int boardSize, int handicapValue ) 
            : base( boardSize, handicapValue )
        {
            AiStrength = aiStrength;
        }

        public int AiStrength { get; }
    }
}
