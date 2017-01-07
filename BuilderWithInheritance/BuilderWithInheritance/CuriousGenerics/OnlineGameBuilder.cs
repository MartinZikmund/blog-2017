using BuilderWithInheritance.Games;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderWithInheritance.CuriousGenerics
{
    class OnlineGameBuilder : GameBuilder<OnlineGame, OnlineGameBuilder>
    {
        private string _serverUrl = "http://example.com/";

        protected override OnlineGameBuilder BuilderInstance => this;

        public OnlineGameBuilder ServerUrl(string serverUrl)
        {
            _serverUrl = serverUrl;
            return this;
        }

        public override OnlineGame Build() =>
            new OnlineGame(_serverUrl, _boardSize, _level);
    }
}
