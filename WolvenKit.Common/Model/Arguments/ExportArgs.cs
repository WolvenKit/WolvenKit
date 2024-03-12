using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using WolvenKit.Core.Interfaces;
using WolvenKit.RED4.Archive;

namespace WolvenKit.Common.Model.Arguments
{
    /// <summary>
    /// Tags a property as accessible in a WolvenKit Script
    /// </summary>
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class WkitScriptAccess : Attribute
    {
        public string ScriptName { get; }

        // by default the script name is the name of the property or class
        public WkitScriptAccess([CallerMemberName] string scriptName = "") => ScriptName = scriptName;
    }

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

    public class GeneralExportArgs : ExportArgs
    {
        public string? MaterialRepositoryPath { get; set; }
    }

    public class OpusExportArgs : ExportArgs
    {
        private bool _useMod;
        private List<uint> _selectedForExport = new();

        [Category("Export Settings")]
        [Display(Name = "Use Modified OpusInfo")]
        [Description("If selected modified OpusInfo and paks within the Mod Project are used. If unchecked the original OpusInfo and paks will be exported.")]
        [WkitScriptAccess()]
        public bool UseMod { get => _useMod; set => SetProperty(ref _useMod, value); }

        [Category("Export Settings")]
        public List<uint> SelectedForExport { get => _selectedForExport; set => SetProperty(ref _selectedForExport, value); }

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
        private bool _isBinary = true;

        /// <summary>
        /// Binary Export Bool, Decides between GLB and GLTF
        /// </summary>
        [Category("Export Settings")]
        [Display(Name = "Is Binary")]
        [Description("If selected the mesh will be exported as GLB, if unchecked as GLTF")]
        [WkitScriptAccess("Binary")]
        public bool IsBinary { get => _isBinary; set => SetProperty(ref _isBinary, value); }

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
        private EUncookExtension _uncookExtension = EUncookExtension.png;

        /// <summary>
        /// MlMask Uncook Format
        /// </summary>
        [Category("Export Type")]
        [Display(Name = "MLmask Export Type")]
        [WkitScriptAccess("ImageFormat")]
        public EUncookExtension UncookExtension { get => _uncookExtension; set => SetProperty(ref _uncookExtension, value); }
        [Browsable(false)]
        [WkitScriptAccess()]
        public bool AsList { get; set; } = true;

        /// <summary>
        /// String Override to display info in datagrid.
        /// </summary>
        /// <returns>String</returns>
        public override string ToString() => $"{UncookExtension}";
    }

    public class InkAtlasExportArgs : ExportArgs
    {

    }

    /// <summary>
    /// XBM Export Arguments
    /// </summary>
    public class XbmExportArgs : ExportArgs
    {
        private EUncookExtension _uncookExtension = EUncookExtension.png;

        /// <summary>
        ///  Uncook Format for XBM.
        /// </summary>
        [Category("Export Type")]
        [Display(Name = "XBM Export Type")]
        [WkitScriptAccess("ImageType")]
        public EUncookExtension UncookExtension { get => _uncookExtension; set => SetProperty(ref _uncookExtension, value); }

        /// <summary>
        /// String Override to display info in datagrid.
        /// </summary>
        /// <returns>String</returns>
        public override string ToString() => $"{UncookExtension}";
    }
    /// <summary>
    /// ENT Export Arguments
    /// </summary>
    public class EntityExportArgs : ExportArgs
    {
        /// <summary>
        /// String Override to display info in datagrid.
        /// </summary>
        /// <returns>String</returns>
        public override string ToString() => "Entity";
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
        private MeshExportType _meshExportType = MeshExportType.MeshOnly;
        private bool _lodFilter = true;
        private bool _isGLBinary = true;

        /// <summary>
        /// Choose exporter
        /// </summary>
        [Category("Experimental")]
        [Display(Name = "Choose Exporter")]
        [Description("Choose the exporter type. Use default if you run into issues.")]
        [WkitScriptAccess("MeshExporter")]
        public MeshExporterType MeshExporter { get; set; }

        /// <summary>
        /// Export type for the selected Mesh.
        /// </summary>
        [Category("Export Type")]
        [Display(Name = "Mesh Export Type")]
        [Description("Select between mesh export options. By default materials but no rig are included.")]
        [WkitScriptAccess("ExportType")]
        public MeshExportType meshExportType { get => _meshExportType; set => SetProperty(ref _meshExportType, value); }

        /// <summary>
        /// If lodfilter = true, only exports the highest quality geometry, if false export all the geometry.
        /// </summary>
        [Category("Default Export Settings")]
        [Display(Name = "LOD Filter")]
        [Description("If selected LOD meshes will not be included. May cause complications with clipping decals.")]
        [WkitScriptAccess()]
        public bool LodFilter { get => _lodFilter; set => SetProperty(ref _lodFilter, value); }

        /// <summary>
        /// Binary Export Bool, Decides between GLB and GLTF
        /// </summary>
        [Category("Default Export Settings")]
        [Display(Name = "Is Binary")]
        [Description("If selected mesh exports will be in binary form as GLB rather than glTF format. (Recommended)")]
        [WkitScriptAccess("Binary")]
        public bool isGLBinary { get => _isGLBinary; set => SetProperty(ref _isGLBinary, value); }

        /// <summary>
        /// Binary Export Bool, Decides if we should export materials
        /// </summary>
        [Category("Default Export Settings")]
        [Display(Name = "Export Materials")]
        [Description("If selected mesh exports will include materials.")]
        [WkitScriptAccess("WithMaterials")]
        public bool withMaterials { get; set; } = true;

        /// <summary>
        /// Garment Export Bool, Decides if we should export garment support data
        /// </summary>
        [Category("Default Export Settings")]
        [Display(Name = "Export Garment Support (Experimental)")]
        [Description("If selected mesh exports will include garment support data.")]
        public bool ExportGarmentSupport { get; set; } = true;


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
        public List<FileEntry> Rig { get; set; } = new();

        /// <summary>
        /// Uncook Format for material files. (DDS,TGA,PNG Etc)
        /// </summary>
        [Category("WithMaterials Settings")]
        [Display(Name = "Select Texture Format")]
        [Description("Select the preferred texture format to be exported within the Depot.")]
        [WkitScriptAccess("ImageType")]
        public EUncookExtension MaterialUncookExtension { get; set; } = EUncookExtension.png;

        /// <summary>
        /// Material Repository path for WithMaterials Mesh Export.
        /// </summary>
        [Browsable(false)]
        public string? MaterialRepo { get; set; }

        /// <summary>
        /// Experimental merged export
        /// </summary>
        [Browsable(false)]
        public bool ExperimentalMergedExport { get; set; } = false;

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
        private WemExportTypes _wemExportType = WemExportTypes.Ogg;

        /// <summary>
        /// Wem Export type
        /// </summary>
        [Category("Export Type")]
        [Display(Name = "Wem Export Type")]
        [Description("Select audio output format")]
        [WkitScriptAccess("ExportType")]
        public WemExportTypes wemExportType { get => _wemExportType; set => SetProperty(ref _wemExportType, value); }
        [Browsable(false)]
        public string? FileName { get; set; }

        /// <summary>
        /// String Override to display info in datagrid.
        /// </summary>
        /// <returns>String</returns>
        public override string ToString() => wemExportType.ToString();
    }

    public class AnimationExportArgs : ExportArgs
    {
        private bool _isBinary = true;

        /// <summary>
        /// Binary Export Bool, Decides between GLB and GLTF
        /// </summary>
        [Category("Export Settings")]
        [Display(Name = "Is Binary")]
        [Description("If selected the anims will be exported as GLB, if unchecked as GLTF")]
        [WkitScriptAccess("Binary")]
        public bool IsBinary { get => _isBinary; set => SetProperty(ref _isBinary, value); }

        /// <summary>
        /// Root Motion Export Bool
        /// </summary>
        [Category("Export Settings")]
        [Display(Name = "Include Root Motion")]
        [Description("If selected the anims will have the root translations")]
        [WkitScriptAccess()]
        public bool incRootMotion { get; set; } = false;

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
        Mp3,
        Ogg
    }

    /// <summary>
    /// Mesh Export Types
    /// </summary>
    public enum MeshExportType
    {
        MeshOnly,
        WithRig,
        Multimesh
    }


    /// <summary>
    /// Mesh Exporters
    /// </summary>
    public enum MeshExporterType
    {
        Default,
        Experimental,
        REDmod
    }
}
