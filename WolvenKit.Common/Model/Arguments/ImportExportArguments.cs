using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using ReactiveUI;
using WolvenKit.Common.DDS;
using WolvenKit.RED4.CR2W.Archive;
using WolvenKit.RED4.CR2W.Types;
using SharpGLTF.Validation;

namespace WolvenKit.Common.Model.Arguments
{
    public class GlobalConvertArgs
    {
        private readonly Dictionary<Type, ConvertArgs> _argsList = new()
        {
            { typeof(CommonConvertArgs), new CommonConvertArgs() },
        };

        public GlobalConvertArgs Register(params ConvertArgs[] convertArgs)
        {
            foreach (var arg in convertArgs)
            {
                var type = arg.GetType();
                if (_argsList.ContainsKey(type))
                {
                    _argsList[type] = arg;
                }
                else
                {
                    _argsList.Add(type, arg);
                }
            }

            return this;
        }

        public T Get<T>() where T : ConvertArgs
        {
            var arg = _argsList[typeof(T)];
            if (arg is T t)
            {
                return t;
            }

            return null;
        }
    }

    /// <summary>
    /// Global Export Arguments
    /// </summary>
    public class GlobalExportArgs
    {
        /// <summary>
        /// Export Argument Dictionary.
        /// </summary>
        private readonly Dictionary<Type, ExportArgs> _argsList = new()
        {
            { typeof(CommonExportArgs), new CommonExportArgs() },
            { typeof(MorphTargetExportArgs), new MorphTargetExportArgs() },
            { typeof(MlmaskExportArgs), new MlmaskExportArgs() },
            { typeof(XbmExportArgs), new XbmExportArgs() },
            { typeof(MeshExportArgs), new MeshExportArgs() },
            { typeof(AnimationExportArgs), new AnimationExportArgs() },
            { typeof(WemExportArgs), new WemExportArgs() },
            { typeof(OpusExportArgs), new OpusExportArgs() },
            { typeof(EntityExportArgs), new EntityExportArgs() },
        };

        /// <summary>
        /// Register Export Arguments.
        /// </summary>
        /// <param name="exportArgs"></param>
        /// <returns></returns>
        public GlobalExportArgs Register(params ExportArgs[] exportArgs)
        {
            foreach (var arg in exportArgs)
            {
                var type = arg.GetType();
                if (_argsList.ContainsKey(type))
                {
                    _argsList[type] = arg;
                }
                else
                {
                    _argsList.Add(type, arg);
                }
            }

            return this;
        }

        /// <summary>
        /// Get Argument.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public T Get<T>() where T : ExportArgs
        {
            var arg = _argsList[typeof(T)];
            if (arg is T t)
            {
                return t;
            }

            return null;
        }
    }

    /// <summary>
    /// Global Export Arguments
    /// </summary>
    public class GlobalImportArgs
    {
        /// <summary>
        /// Export Argument Dictionary.
        /// </summary>
        private readonly Dictionary<Type, ImportArgs> _argsList = new()
        {
            { typeof(CommonImportArgs), new CommonImportArgs() },
            { typeof(XbmImportArgs), new XbmImportArgs() },
            { typeof(GltfImportArgs), new GltfImportArgs() },
            { typeof(OpusImportArgs), new OpusImportArgs() },
            { typeof(MlmaskImportArgs), new MlmaskImportArgs() },
        };

        /// <summary>
        /// Register Export Arguments.
        /// </summary>
        /// <param name="exportArgs"></param>
        /// <returns></returns>
        public GlobalImportArgs Register(params ImportArgs[] exportArgs)
        {
            foreach (var arg in exportArgs)
            {
                var type = arg.GetType();
                if (_argsList.ContainsKey(type))
                {
                    _argsList[type] = arg;
                }
                else
                {
                    _argsList.Add(type, arg);
                }
            }

            return this;
        }

        /// <summary>
        /// Get Argument.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public T Get<T>() where T : ImportArgs
        {
            var arg = _argsList[typeof(T)];
            if (arg is T t)
            {
                return t;
            }

            return null;
        }
    }

    /// <summary>
    /// Import Export Arguments
    /// </summary>
    public abstract class ImportExportArgs : ReactiveObject
    {


    }

    /// <summary>
    /// Import Arguments
    /// </summary>
    public abstract class ImportArgs : ImportExportArgs
    {
        [Category("Default Import Settings")]
        [Display(Name = "Replace original File?")]
        [Description("If checked the file will replace the original file in the archives.")]
        public bool Keep { get; set; } = true;
    }

    /// <summary>
    /// Export Arguments
    /// </summary>
    public abstract class ExportArgs : ImportExportArgs
    {
    }

    /// <summary>
    /// Convert Arguments
    /// </summary>
    public abstract class ConvertArgs : ImportExportArgs
    {
    }

    #region import args

    /// <summary>
    /// Common Import Arguments
    /// </summary>
    public class CommonImportArgs : ImportArgs
    {
    }

    /// <summary>
    /// Fnt Import Arguments
    /// </summary>
    public class OpusImportArgs : ImportArgs
    {
        public bool UseMod { get; set; }

        public override string ToString() => ".WAV";
    }

    /// <summary>
    /// Fnt Import Arguments
    /// </summary>
    public class FntImportArgs : ImportArgs
    {
        public override string ToString() => ".FNT";
    }

    /// <summary>
    /// XBM Import Arguments
    /// </summary>
    public class XbmImportArgs : ImportArgs
    {
        public Enums.GpuWrapApieTextureGroup TextureGroup { get; internal set; } =
            Enums.GpuWrapApieTextureGroup.TEXG_Generic_Color;

        /// <summary>
        /// String Override to display info in datagrid.
        /// </summary>
        /// <returns>String</returns>
        public override string ToString() => TextureGroup.ToString();
    }

    /// <summary>
    /// Mesh Import Arguments
    /// </summary>
    public class GltfImportArgs : ImportArgs
    {
        [Category("Import Settings")]
        [Display(Name = "Import Material.Json Only")]
        [Description("If checked only the Materials from Material.Json will be imported to the mesh, geometry from GLTF/GLB will not be imported!, uncheck imports Both!")]
        public bool importMaterialOnly { get; set; } = false;

        /// <summary>
        /// Validation type for the selected GLB/GLTF.
        /// </summary>
        [Category("Import Settings")]
        [Display(Name = "GLTF Validation Checks")]
        [Description("The type of validation check for your glb/gltf file")]
        public ValidationMode validationMode { get; set; } = ValidationMode.Strict;
        /// <summary>
        /// RedEngine4 Cooked File type for the selected GLB/GLTF.
        /// </summary>
        [Category("Import Settings")]
        [Display(Name = "Import As RedEngine File Format")]
        [Description("The RedEngine file format to import as for your glb/gltf file")]
        public GltfImportAsFormat importFormat { get; set; } = GltfImportAsFormat.Mesh;
        /// <summary>
        /// List of Archives for Morphtarget Import.
        /// </summary>
        [Browsable(false)]
        public List<Archive> Archives { get; set; } = new();
        /// <summary>
        /// String Override to display info in datagrid.
        /// </summary>
        /// <returns>String</returns>
        public override string ToString() => "Mesh/Morphtarget | " + $"Import Format :  {importFormat.ToString()}";
    }
    public enum GltfImportAsFormat
    {
        Mesh,
        Morphtarget
    }
    public class MlmaskImportArgs : ImportArgs
    {
        /// <summary>
        /// String Override to display info in datagrid.
        /// </summary>
        /// <returns>String</returns>
        public override string ToString() => "Masklist(txt file containing mask image paths) TO--> Mlmask";
    }

    #endregion import args

    #region export args

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
        [Description("FALSE is when u want to grab the sounds from the original opusinfo and paks that are present in the archives. TRUE when u already have a modded opusinfo and paks in the mod folder")]
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

        public override string ToString() => "Wem Files | " + $"Use Modified OpusInfo :  {UseMod.ToString()} | Selected :  {SelectedForExport.Count.ToString()}";
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
        [Description("If checked the mesh will be exported as GLB, if unchecked as GLTF")]
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
        public override string ToString() => "GLTF/GLB | " + $"Is Binary :  {IsBinary.ToString()}";
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
        public EUncookExtension UncookExtension { get; set; }

        /// <summary>
        /// String Override to display info in datagrid.
        /// </summary>
        /// <returns>String</returns>
        public override string ToString() => $"{UncookExtension.ToString()}";
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
        public EUncookExtension UncookExtension { get; set; }

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
        public override string ToString() => $"{UncookExtension.ToString()} | Flip : {Flip.ToString()}";
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
        public override string ToString() => $"{ExportType.ToString()}";
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
        [Description("When used LOD meshes will not be included. Not recommended for most cases due to complications with clipping decals.")]
        public bool LodFilter { get; set; } = true;

        /// <summary>
        /// Binary Export Bool, Decides between GLB and GLTF
        /// </summary>
        [Category("Default Export Settings")]
        [Display(Name = "Is Binary")]
        [Description("When used mesh exports will be in binary form as GLB rather than glTF format. (Recommended)")]
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
        [Description("Select the preferred texture format to be exported within the Material Repository.")]
        public EUncookExtension MaterialUncookExtension { get; set; } = EUncookExtension.dds;

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
        public override string ToString() => "GLTF/GLB | " + $"Export Type : {meshExportType.ToString()} | Lod filter : {LodFilter.ToString()} | Is Binary : {isGLBinary.ToString()}";
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
        [Description("Set the audioformat you want your wem file to be converted to.")]
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
        [Description("If checked the mesh will be exported as GLB, if unchecked as GLTF")]
        public bool IsBinary { get; set; } = true;

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
        public override string ToString() => "GLTF/GLB | " + $"Is Binary :  {IsBinary.ToString()}";
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

    #endregion export args

    #region convert args

    public class CommonConvertArgs : ConvertArgs
    {
        [Category("Convert Settings")]
        [Display(Name = "Output format")]
        [Description("Use this to select to what format you want to export your file.")]
        public EConvertableOutput EConvertableOutput { get; set; }
        public override string ToString() => EConvertableOutput.ToString();

    }





    #endregion convert args
}
