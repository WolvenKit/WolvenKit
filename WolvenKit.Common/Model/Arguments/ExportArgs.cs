using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using WolvenKit.RED4.Archive;

namespace WolvenKit.Common.Model.Arguments
{
    /// <summary>
    /// Export Arguments
    /// </summary>
    public abstract class ExportArgs : ImportExportArgs
    {
    }

    /// <summary>
    /// Common Export Arguments
    /// </summary>
    public class CommonExportArgs : ExportArgs
    {
    }

    public class OpusExportArgs : ExportArgs
    {
        [Category("Export Settings")]
        [Display(Name = "Use Modified OpusInfo")]
        [Description("If selected modified OpusInfo and paks within the Mod Project are used. If unchecked the original OpusInfo and paks will be exported.")]
        public bool UseMod { get; set; }

        [Category("Export Settings")]
        public List<uint> SelectedForExport { get; set; } = new();

        [Browsable(false)]
        public Archive SoundbanksArchive { get; set; } = new();

        [Browsable(false)]
        public string ModFolderPath { get; set; }

        [Browsable(false)]
        public string RawFolderPath { get; set; }

        [Category("Export Settings")]
        [Display(Name = "Dump all information inside OpusInfo to Json.")]
        public bool DumpAllToJson { get; set; }

        public override string ToString() => $"Wem Files | Use Modified OpusInfo :  {UseMod} | Selected :  {SelectedForExport.Count}";
    }

    /// <summary>
    /// MorphTarget Export Arguments
    /// </summary>
    public class MorphTargetExportArgs : ExportArgs
    {
        /// <summary>
        /// Binary Export Bool, Decides between GLB and GLTF
        /// </summary>
        [Category("Export Settings")]
        [Display(Name = "Is Binary")]
        [Description("If selected the mesh will be exported as GLB, if unchecked as GLTF")]
        public bool IsBinary { get; set; } = true;

        /// <summary>
        /// List of Archives for Morphtarget Export.
        /// </summary>
        [Browsable(false)]
        public List<Archive> Archives { get; set; } = new();
        /// <summary>
        /// Archive path for Console Morphtarget Export.
        /// </summary>
        [Browsable(false)]
        public string ArchiveDepot { get; set; }

        [Browsable(false)]
        public string ModFolderPath { get; set; }
        /// <summary>
        /// String Override to display info in datagrid.
        /// </summary>
        /// <returns>String</returns>
        public override string ToString() => $"GLTF/GLB | Is Binary :  {IsBinary}";

    }

    /// <summary>
    /// Fnt Import Arguments
    /// </summary>
    public class FntExportArgs : ExportArgs
    {
        public override string ToString() => ".TTF";
    }

    /// <summary>
    /// MlMask Export Arguments
    /// </summary>
    public class MlmaskExportArgs : ExportArgs
    {
        /// <summary>
        /// MlMask Uncook Format
        /// </summary>
        [Category("Export Type")]
        [Display(Name = "MLmask Export Type")]
        public EMlmaskUncookExtension UncookExtension { get; set; } = EMlmaskUncookExtension.png;

        [Browsable(false)]
        public bool AsList { get; set; } = true;

        /// <summary>
        /// String Override to display info in datagrid.
        /// </summary>
        /// <returns>String</returns>
        public override string ToString() => $"{UncookExtension}";
    }

    /// <summary>
    /// XBM Export Arguments
    /// </summary>
    public class XbmExportArgs : ExportArgs
    {
        /// <summary>
        ///  Uncook Format for XBM.
        /// </summary>
        [Category("Export Type")]
        [Display(Name = "XBM Export Type")]
        public EUncookExtension UncookExtension { get; set; } = EUncookExtension.tga;

        /// <summary>
        /// Flip Image argument
        /// </summary>
        [Category("Export Settings")]
        [Display(Name = "Flip Image")]
        public bool Flip { get; set; }

        /// <summary>
        /// String Override to display info in datagrid.
        /// </summary>
        /// <returns>String</returns>
        public override string ToString() => $"{UncookExtension} | Flip : {Flip}";
    }
    /// <summary>
    /// ENT Export Arguments
    /// </summary>
    public class EntityExportArgs : ExportArgs
    {
        /// <summary>
        ///  Uncook Format for Entity.
        /// </summary>
        [Category("Export Type")]
        [Display(Name = "Export Type")]
        public EntityExportType ExportType { get; set; } = EntityExportType.Json;
        /// <summary>
        /// List of Archives for Gltf Mesh Export.
        /// </summary>
        [Browsable(false)]
        public List<Archive> Archives { get; set; } = new();
        /// <summary>
        /// String Override to display info in datagrid.
        /// </summary>
        /// <returns>String</returns>
        public override string ToString() => $"{ExportType}";
    }
    public enum EntityExportType
    {
        Json,
        Gltf
    }
    /// <summary>
    /// Mesh Export Arguments
    /// </summary>
    public class MeshExportArgs : ExportArgs
    {
        /// <summary>
        /// Export type for the selected Mesh.
        /// </summary>
        [Category("Export Type")]
        [Display(Name = "Mesh Export Type")]
        [Description("Select between mesh export options. By default no rig or materials are included.")]
        public MeshExportType meshExportType { get; set; } = MeshExportType.Default;

        /// <summary>
        /// If lodfilter = true, only exports the highest quality geometry, if false export all the geometry.
        /// </summary>
        [Category("Default Export Settings")]
        [Display(Name = "LOD Filter")]
        [Description("If selected LOD meshes will not be included. Not recommended for most cases due to complications with clipping decals.")]
        public bool LodFilter { get; set; } = false;

        /// <summary>
        /// Binary Export Bool, Decides between GLB and GLTF
        /// </summary>
        [Category("Default Export Settings")]
        [Display(Name = "Is Binary")]
        [Description("If selected mesh exports will be in binary form as GLB rather than glTF format. (Recommended)")]
        public bool isGLBinary { get; set; } = true;

        /// <summary>
        /// MultiMesh Mesh List.
        /// </summary>
        [Category("MultiMesh Settings")]
        [Display(Name = "Select Additional Meshes")]
        [Description("Select additional meshes to be included within a single export.")]
        public List<FileEntry> MultiMeshMeshes { get; set; } = new();      // meshes?

        /// <summary>
        /// MultiMesh Rig List.
        /// </summary>
        [Category("MultiMesh Settings")]
        [Display(Name = "Select Rig(s)")]
        [Description("Select one or multiple rigs to be used within a single export. Recommended for meshes which use more than one rig.")]
        public List<FileEntry> MultiMeshRigs { get; set; } = new();        // rigs

        /// <summary>
        /// Selected Rig for Mesh WithRig Export. ALWAYS USE THE FIRST ENTRY IN THE LIST.
        /// </summary>
        [Category("WithRig Settings")]
        [Display(Name = "Select Rig")]
        [Description("Select a rig to export within the mesh.")]
        public List<FileEntry> Rig { get; set; }

        /// <summary>
        /// Uncook Format for material files. (DDS,TGA,PNG Etc)
        /// </summary>
        [Category("WithMaterials Settings")]
        [Display(Name = "Select Texture Format")]
        [Description("Select the preferred texture format to be exported within the Depot.")]
        public EUncookExtension MaterialUncookExtension { get; set; } = EUncookExtension.png;

        /// <summary>
        /// List of Archives for WithMaterials Mesh Export.
        /// </summary>
        [Browsable(false)]
        public List<Archive> Archives { get; set; } = new();

        /// <summary>
        /// Optional archive path for WithMaterials Mesh Export.
        /// </summary>
        [Browsable(false)]
        public string ArchiveDepot { get; set; }

        /// <summary>
        /// Material Repository path for WithMaterials Mesh Export.
        /// </summary>
        [Browsable(false)]
        public string MaterialRepo { get; set; }

        /// <summary>
        /// String Override to display info in datagrid.
        /// </summary>
        /// <returns>String</returns>
        public override string ToString() => $"GLTF/GLB | Export Type : {meshExportType} | Lod filter : {LodFilter} | Is Binary : {isGLBinary}";
    }

    /// <summary>
    /// Wem Export Arguments.
    /// </summary>
    public class WemExportArgs : ExportArgs
    {
        /// <summary>
        /// Wem Export type
        /// </summary>
        [Category("Export Type")]
        [Display(Name = "Wem Export Type")]
        [Description("Select audio output format")]
        public WemExportTypes wemExportType { get; set; } = WemExportTypes.Mp3;

        [Browsable(false)]
        public string FileName { get; set; }

        /// <summary>
        /// String Override to display info in datagrid.
        /// </summary>
        /// <returns>String</returns>
        public override string ToString() => wemExportType.ToString();
    }

    public class AnimationExportArgs : ExportArgs
    {
        /// <summary>
        /// Binary Export Bool, Decides between GLB and GLTF
        /// </summary>
        [Category("Export Settings")]
        [Display(Name = "Is Binary")]
        [Description("If selected the anims will be exported as GLB, if unchecked as GLTF")]
        public bool IsBinary { get; set; } = true;

        /// <summary>
        /// Root Motion Export Bool
        /// </summary>
        [Category("Export Settings")]
        [Display(Name = "Include Root Motion")]
        [Description("If selected the anims will have the root translations")]
        public bool incRootMotion { get; set; } = false;

        /// <summary>
        /// List of Archives for Animations Export.
        /// </summary>
        [Browsable(false)]
        public List<Archive> Archives { get; set; } = new();
        /// <summary>
        /// Archive path for Console Anims Export.
        /// </summary>
        [Browsable(false)]
        public string ArchiveDepot { get; set; }
        /// <summary>
        /// String Override to display info in datagrid.
        /// </summary>
        /// <returns>String</returns>
        public override string ToString() => "GLTF/GLB | " + $"Is Binary :  {IsBinary}";
    }

    /// <summary>
    /// Wem Export Types
    /// </summary>
    public enum WemExportTypes
    {
        Wav,
        Mp3
    }

    /// <summary>
    /// Mesh Export Types
    /// </summary>
    public enum MeshExportType
    {
        Default,
        WithRig,
        WithMaterials,
        Multimesh
    }

}
