using Catel.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WolvenKit.Common.Services;

namespace CP77Tools.Services
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
