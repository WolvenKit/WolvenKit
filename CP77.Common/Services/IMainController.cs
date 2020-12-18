using System.Collections.Generic;

namespace CP77.Common.Services
{
    public interface IMainController
    {
        public Dictionary<ulong, string>  Hashdict { get; set; }
    }
}
