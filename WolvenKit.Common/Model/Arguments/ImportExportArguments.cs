using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WolvenKit.Common.DDS;
using WolvenKit.Common.Wcc;

namespace WolvenKit.Common.Model.Arguments
{
    public abstract class ImportExportArgs : Catel.Data.ObservableObject
    {
    }

    public abstract class ImportArgs : ImportExportArgs
    {

    }

    public abstract class ExportArgs : ImportExportArgs
    {

    }


    #region import args

    public class CommonImportArgs : ImportArgs
    {

    }

    public class XbmImportArgs : ImportArgs
    {
        public ETextureGroup TextureGroup { get; internal set; }

        public override string ToString() => TextureGroup.ToString();
    }

    #endregion


    #region export args

    public class CommonExportArgs : ExportArgs
    {

    }

    public class MlmaskExportArgs : ExportArgs
    {
        public EUncookExtension UncookExtension { get; set; }
    }

    public class XbmExportArgs : ExportArgs
    {
        private EUncookExtension _uncookExtension;
        public EUncookExtension UncookExtension
        {
            get => _uncookExtension;
            set
            {
                if (_uncookExtension != value)
                {
                    var oldValue = _uncookExtension;
                    _uncookExtension = value;
                    RaisePropertyChanged(() => UncookExtension, oldValue, value);
                }
            }
        }

        

        public bool Flip { get; set; }

        public override string ToString() => $"{UncookExtension.ToString()}, {Flip.ToString()}";
    }

    public class MeshExportArgs : ExportArgs
    {
        public Stream RigStream { get; set; }
        public bool LodFilter { get; set; } = true;
        public bool isGLBinary { get; set; } = true;
        public EUncookExtension MaterialUncookExtension { get; set; }


        public override string ToString() => "GLTF/GLB : " +  $"{LodFilter.ToString()}, {isGLBinary.ToString()}";

    }

    public class WemExportArgs : ExportArgs
    {
        public WemExportTypes wemExportType { get; set; }


        public override string ToString() => wemExportType.ToString();

    }

    public enum WemExportTypes { Wav, Mp3 }

    #endregion


}
