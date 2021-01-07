using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WolvenKit.Common.Model;

namespace WolvenKit.Common
{
    public interface IGameArchive
    {
        EArchiveType TypeName { get; }
        string ArchiveAbsolutePath { get; set; }
    }
}
