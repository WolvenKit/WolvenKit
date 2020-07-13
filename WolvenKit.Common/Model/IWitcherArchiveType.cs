using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WolvenKit.Common.Model;

namespace WolvenKit.Common
{
    public interface IWitcherArchiveType
    {
        EBundleType TypeName { get; }
        string FileName { get; set; }
    }
}
