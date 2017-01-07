using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderWithInheritance.Games
{
    class OnlineGame : Game
    {
        public OnlineGame(string serverUrl, int boardSize, int level)
            : base(boardSize, level)
        {
            ServerUrl = serverUrl;
        }

        public string ServerUrl { get; set; }
    }
}
