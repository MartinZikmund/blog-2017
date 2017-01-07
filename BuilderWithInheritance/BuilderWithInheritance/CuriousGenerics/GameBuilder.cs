using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderWithInheritance.CuriousGenerics
{
    abstract class GameBuilder<TGame, TBuilder>
        where TGame : Game
        where TBuilder : GameBuilder<TGame, TBuilder>
    {
        protected int _boardSize = 8;
        protected int _level = 1;

        protected abstract TBuilder BuilderInstance { get; }

        public TBuilder BoardSize(int boardSize)
        {
            _boardSize = boardSize;
            return BuilderInstance;
        }

        public TBuilder Level(int level)
        {
            _level = level;
            return BuilderInstance;
        }

        public abstract TGame Build();
    }
}
