using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WolvenKit.Render
{
    using Common.Services;
    using WolvenKit.Common;

    public class RenderHelper
    {
        private ILoggerService _logger;
        private W3Mod _w3Mod;

        public RenderHelper(W3Mod w3Mod, ILoggerService logger)
        {
            _w3Mod = w3Mod;
            _logger = logger;
        }

        public W3Mod getW3Mod()
        {
            return _w3Mod;
        }

        public ILoggerService getLogger()
        {
            return _logger;
        }
    }
}
