using BuilderWithInheritance.Games;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderWithInheritance.NonGeneric
{
    class LocalGameBuilder : GameBuilder
    {
        private int _aiStrength = 3;

        public LocalGameBuilder AiStrength(int aiStrength)
        {
            _aiStrength = aiStrength;
            return this;
        }

        //this should not be allowed!
        public override Game Build() =>
            new OnlineGame("INVALID", _boardSize, _level); 
    }
}
