using System.Collections.Generic;
using System.IO;
using WolvenKit.Common;
using WolvenKit.CR2W;

namespace WolvenKit
{
    public class UnbundleGameArgs
    {
        public bool Overwrite { get; }

        public UnbundleGameArgs(bool overwrite)
        {
            Overwrite = overwrite;
        }
    }
}