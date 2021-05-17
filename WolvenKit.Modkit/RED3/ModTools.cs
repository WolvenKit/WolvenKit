using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WolvenKit.Common.Services;

namespace WolvenKit.Modkit.RED3
{
    public partial class Red3ModTools
    {
        private readonly ILoggerService _logger;

        public Red3ModTools(
            ILoggerService loggerService
        )
        {
            _logger = loggerService;
        }





    }
}
