using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WolvenKit.Common.DDS;
using WolvenKit.Common.Wcc;

namespace WolvenKit.Common.Model.Arguments
{
    public abstract class ImportExportArgs
    {



    }

    public class ImportArgs : ImportExportArgs
    {
        public ETextureGroup TextureGroup { get; internal set; }

        public override string ToString() => TextureGroup.ToString();
    }

    public class ExportArgs : ImportExportArgs
    {
        public EUncookExtension UncookExtension { get; set; }
        public bool Flip { get; set; }

        public override string ToString() => $"{UncookExtension.ToString()}, {Flip.ToString()}";
    }
}
