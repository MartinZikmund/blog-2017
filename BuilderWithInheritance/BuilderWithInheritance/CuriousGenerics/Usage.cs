using BuilderWithInheritance.Games;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderWithInheritance.CuriousGenerics
{
    class Usage
    {
        public static void Example()
        {
            OnlineGame onlineGame = new OnlineGameBuilder().
                ServerUrl("http://new.com").
                Level(12).
                Build();

            //now it works butter smooth
            OnlineGame anotherOnlineGame = new OnlineGameBuilder().
                Level(2).
                ServerUrl("http://myserver.com").
                Build();
        }
    }
}
