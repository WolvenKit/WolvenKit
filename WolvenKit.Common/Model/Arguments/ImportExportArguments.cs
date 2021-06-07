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
using WolvenKit.RED4.CR2W.Archive;

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

        [Browsable(false)]
        public string FileName { get; set; }
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

    public class MeshImportArgs : ImportArgs
    {
        public Stream MeshToReplaceStream { get; set; }

        public override string ToString() => ".Mesh";

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
        /// Export Type Category
        [Category("Export Type")]
        [Display(Name = "Mesh Export Type")]
        [Description("The type of export for your mesh, by default no Materials or Rig is used.")]
        public MeshExportType meshExportType { get; set; } = MeshExportType.Default;


        ///  Default Export Settings Category
        [Category("Default Export Settings")]
        [Display(Name = "Lod Filter")]
        [Description("If lodfilter = true, only exports the highest quality geometry, if false export all the geometry.")]
        public bool LodFilter { get; set; } = true;

        [Category("Default Export Settings")]
        [Display(Name = "Is Binary")]
        [Description("If checked the mesh will be exported as GLB, if unchecked as GLTF")]
        public bool isGLBinary { get; set; } = true;



        /// Export Arguments Settings
        [Category("Export Arguments Settings")]
        [Display(Name = "MultiMesh Export Arguments")]
        public MultiMeshArgs MultiMeshargs { get; set; } = new();

        [Category("Export Arguments Settings")]
        [Display(Name = "Mesh with Rig Export Arguments")]
        public WithRigMeshArgs WithRigMeshargs { get; set; } = new();
        [Category("Export Arguments Settings")]
        [Display(Name = "Mesh with Material Export Arguments")]
        public WithMaterialMeshArgs WithMaterialMeshargs { get; set; } = new();



        [Browsable(false)]
        public List<Archive> Archives { get; set; } = new();

        public override string ToString() => "GLTF/GLB | " +  $"Lod filter : {LodFilter.ToString()} | Is Binary : {isGLBinary.ToString()}";

    }

    public class WithMaterialMeshArgs
    {
        [Category("WithMaterials Settings")]
        [Display(Name = "Select Export Format")]
        [Description("Exports textures(dds,png,tga etc) and material helper data with the mesh.")]
        public EUncookExtension MaterialUncookExtension { get; set; } = EUncookExtension.dds;


        public override string ToString() => "Adjust these settings if WithMaterial selected.";


    }

    public class WithRigMeshArgs
    {
        [Category("WithRig Settings")]
        [Display(Name = "Select rig(s)")]
        [Description("Select rig(s) to export within your mesh.")]
        public Stream RigStream { get; set; }
        public override string ToString() => "Adjust these settings if WithRigh selected.";

    }

    public class MultiMeshArgs
    {
        [Category("MultiMesh Settings")]
        [Display(Name = "Select additional meshes")]
        public List<Stream> MultiMeshMeshes { get; set; } = new();
        [Category("MultiMesh Settings")]
        [Display(Name = "Select rig(s)")]
        public List<Stream> MultiMeshRigs { get; set; } = new();
        public override string ToString() => "Adjust these settings if MultiMesh selected.";

    }

    public class WemExportArgs : ExportArgs
    {
        [Category("Export Type")]
        [Display(Name = "Wem Export Type")]
        [Description("Set the audioformat you want your wem file to be converted to.")]

        public WemExportTypes wemExportType { get; set; } = WemExportTypes.Mp3;


        public override string ToString() => wemExportType.ToString();

    }

    public enum WemExportTypes { Wav, Mp3 }

    public enum MeshExportType { Default, WithRig,WithMaterials}

    #endregion


}
