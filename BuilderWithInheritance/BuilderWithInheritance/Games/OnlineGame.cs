using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderWithInheritance.Games
{
    class OnlineGame : Game
    {
        public OnlineGame( string serverUrl, int boardSize, int handicapValue) 
            : base(boardSize, handicapValue)
        {
            ServerUrl = serverUrl;
        }

        public string ServerUrl { get; set; }
    }
}
