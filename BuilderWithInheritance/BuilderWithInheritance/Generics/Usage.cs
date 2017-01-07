using BuilderWithInheritance.Games;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderWithInheritance.Generics
{
    public static class Usage
    {
        public static void Example()
        {             
            OnlineGame onlineGame = new OnlineGameBuilder().
                ServerUrl("http://new.com").
                Level(12).
                Build();

            //BUT this does not work!
            //OnlineGame anotherOnlineGame = new OnlineGameBuilder().
            //    Handicap(2).
            //    ServerUrl("http://myserver.com"). 
            //    Build();
            //
            // 'GameBuilder<OnlineGame>' does not contain a definition for 'ServerUrl'
        }
    }
}
