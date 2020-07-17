using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WolvenKit.Common.Model;

namespace WolvenKit.Common
{
    public interface IWitcherFile
    {
        IWitcherArchiveType Bundle { get; set; }
        string Name { get; set; }
        long Size { get; set; }
        uint ZSize { get; set; }
        long PageOFfset { get; set; }
        string CompressionType { get; }

        void Extract(Stream output);
        string Extract(BundleFileExtractArgs e);
    }



}
