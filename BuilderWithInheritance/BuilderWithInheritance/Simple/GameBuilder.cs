using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderWithInheritance
{
    abstract class GameBuilder
    {
        protected int _boardSize = 8;
        protected int _handicapValue = 1;

        public GameBuilder SetBoardSize( int boardSize)
        {            
            _boardSize = boardSize;
            return this;
        }

        public GameBuilder SetHandicap(int handicapValue)
        {            
            _handicapValue = handicapValue;
            return this;
        }

        public abstract Game Build();
    }
}
