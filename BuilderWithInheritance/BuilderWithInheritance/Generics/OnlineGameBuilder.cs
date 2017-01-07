using BuilderWithInheritance.Games;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderWithInheritance.Generics
{
    class OnlineGameBuilder : GameBuilder<OnlineGame>
    {
        private string _serverUrl = "http://example.com/";

        public OnlineGameBuilder ServerUrl(string serverUrl)
        {
            _serverUrl = serverUrl;
            return this;
        }

        public override OnlineGame Build() =>
            new OnlineGame(_serverUrl, _boardSize, _level);
    }
}
