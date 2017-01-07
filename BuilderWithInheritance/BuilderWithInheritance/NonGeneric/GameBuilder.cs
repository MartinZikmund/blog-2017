using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderWithInheritance.NonGeneric
{
    abstract class GameBuilder
    {
        protected int _boardSize = 8;
        protected int _level = 1;

        public GameBuilder BoardSize( int boardSize)
        {            
            _boardSize = boardSize;
            return this;
        }

        public GameBuilder Level(int level)
        {            
            _level = level;
            return this;
        }

        public abstract Game Build();
    }
}
