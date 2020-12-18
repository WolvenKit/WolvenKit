using System.Collections.Generic;

namespace CP77.Common.Services
{
    public class MainController : IMainController
    {
        public Dictionary<ulong, string> Hashdict { get; set; }

        public MainController()
        {
            Hashdict = new Dictionary<ulong, string>();
        }
    }
}
