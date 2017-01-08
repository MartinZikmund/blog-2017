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
    private readonly TBuilder _builderInstance = null;
    protected int _boardSize = 8;
    protected int _level = 1;

    //protected abstract TBuilder BuilderInstance { get; }

    public GameBuilder()
    {
        //store the concrete builder instance
        _builderInstance = (TBuilder)this;
    }

    public TBuilder BoardSize(int boardSize)
    {
        _boardSize = boardSize;
        return _builderInstance;
    }

    public TBuilder Level(int level)
    {
        _level = level;
        return _builderInstance;
    }

    public abstract TGame Build();
}
}
