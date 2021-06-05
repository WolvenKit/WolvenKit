using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
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

    public class MorphTargetExportArgs : ExportArgs
    {
        [Category("Export Settings")]
        [Display(Name = "Is Binary")]
        [ReadOnly(true)]
        public bool IsBinary { get; set; } = true;

        public override string ToString() => "GLTF/GLB | " + $"Is Binary :  {IsBinary.ToString()}";

    }

    public class MlmaskExportArgs : ExportArgs
    {
        [Category("Export Type")]
        [Display(Name = "MLmask Export Type")]
        public EUncookExtension UncookExtension { get; set; }
        public override string ToString() => $"{UncookExtension.ToString()}";

    }

    public class XbmExportArgs : ExportArgs
    {

        private EUncookExtension _uncookExtension;

        [Category("Export Type")]
        [Display(Name = "XBM Export Type")]
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


        [Category("Export Settings")]
        [Display(Name = "Flip Image")]
        public bool Flip { get; set; }

        public override string ToString() => $"{UncookExtension.ToString()} | Flip : {Flip.ToString()}";
    }

    public class MeshExportArgs : ExportArgs
    {

        [Category("Export Type")]
        [Display(Name ="Mesh Export Type")]
        public MeshExportType meshExportType { get; set; }


        [Category("Export Settings")]
        [Display(Name = "Lod Filter")]
        [ReadOnly(true)]
        public bool LodFilter { get; set; } = true;
        [Category("Export Settings")]
        [Display(Name = "Is Binary")]
        [ReadOnly(true)]
        public bool isGLBinary { get; set; } = true;

        [Category("WithRig Settings")]
        [Display(Name = "Select a rig")]
        public Stream RigStream { get; set; }

        [Category("WithMaterials Settings")]
        [Display(Name = "Select Export Type")]
        public EUncookExtension MaterialUncookExtension { get; set; }


        public override string ToString() => "GLTF/GLB | " +  $"Lod filter : {LodFilter.ToString()} | Is Binary : {isGLBinary.ToString()}";

    }

    public class WemExportArgs : ExportArgs
    {
        [Category("Export Type")]
        [Display(Name = "Wem Export Type")]
        public WemExportTypes wemExportType { get; set; }


        public override string ToString() => wemExportType.ToString();

    }

    public enum WemExportTypes { Wav, Mp3 }

    public enum MeshExportType { Default, WithRig,WithMaterials}

    #endregion


}
