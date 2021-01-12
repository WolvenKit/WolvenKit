using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WolvenKit.Common;

namespace WolvenKit.Controllers
{
    class MockGameController : GameControllerBase
    {
        public override List<IGameArchiveManager> GetArchiveManagersManagers()
        {
            return new List<IGameArchiveManager>();
        }

        public override void HandleStartup()
        {
            //Nothing to do here :)
        }
    }
}
