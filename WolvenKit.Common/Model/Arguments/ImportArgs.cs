using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.IO;
using SharpGLTF.Validation;
using Splat;
using WolvenKit.Core.Interfaces;
using WolvenKit.RED4.Archive;
using WolvenKit.RED4.Types;

namespace WolvenKit.Common.Model.Arguments
{
    /// <summary>
    /// Import Arguments
    /// </summary>
    public abstract class ImportArgs : ImportExportArgs
    {
        [Category("General Import Settings")]
        [Display(Name = "Use existing file", Order = 0)]
        [Description("If checked the corresponding archive file will be used for importing.")]
        public bool Keep { get; set; } = true;
    }


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
        [Category("General Import Settings")]
        [Description("If true, the file will be handled as a SRGB file")]
        public bool IsGamma { get; set; } = false;

        [Category("Image Import Settings")]
        public Enums.ETextureRawFormat RawFormat { get; set; } = Enums.ETextureRawFormat.TRF_TrueColor;

        [Category("Image Import Settings")]
        public Enums.ETextureCompression Compression { get; set; }

        [Category("Image Import Settings")]
        [Description("If true, mipMaps will be generated")]
        public bool HasMipchain { get; set; } = true;


        [Category("XBM Import Settings")]
        [Description("Select the texture group of the imported item")]
        public Enums.GpuWrapApieTextureGroup TextureGroup { get; set; } =
            Enums.GpuWrapApieTextureGroup.TEXG_Generic_Color;

        [Category("XBM Import Settings")]
        public bool IsStreamable { get; set; } = true;

        [Category("XBM Import Settings")]
        public byte PlatformMipBiasPC { get; set; }

        [Category("XBM Import Settings")]
        public byte PlatformMipBiasConsole { get; set; }

        [Category("XBM Import Settings")]
        public bool AllowTextureDowngrade { get; set; } = true;

        [Category("XBM Import Settings")]
        public byte AlphaToCoverageThreshold { get; set; }

        public XbmImportArgs()
        {
            Keep = false;
            HasMipchain = true;
        }

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
        [Category("Default Import Settings")]
        [Display(Name = "Use selected base mesh")]
        [Description("If checked the specified mesh file will be used for importing.")]
        public bool SelectBase { get; set; } = false;

        [Category("Import Settings")]
        [Display(Name = "Import Material.Json Only")]
        [Description("If selected only materials will be updated from a Material.json file. Mesh geometry will remain unchanged.")] public bool importMaterialOnly { get; set; } = false;

        /// <summary>
        /// Validation type for the selected GLB/GLTF.
        /// </summary>
        [Category("Import Settings")]
        [Display(Name = "GLTF Validation Checks")]
        [Description("Optional validation check for glb/glTF files")]
        public ValidationMode validationMode { get; set; } = ValidationMode.Skip;

        /// <summary>
        /// RedEngine4 Cooked File type for the selected GLB/GLTF.
        /// </summary>
        [Category("Import Settings")]
        [Display(Name = "Target File Format")]
        public GltfImportAsFormat importFormat { get; set; } = GltfImportAsFormat.Mesh;

        /// <summary>
        /// Selected Rig for Mesh WithRig Export. ALWAYS USE THE FIRST ENTRY IN THE LIST.
        /// </summary>
        [Category("WithRig Settings")]
        [Display(Name = "Select Rig")]
        [Description("Select a rig to import within the mesh.")]
        public List<FileEntry> Rig { get; set; }

        /// <summary>
        /// Selected Rig for Mesh WithRig Export. ALWAYS USE THE FIRST ENTRY IN THE LIST.
        /// </summary>
        [Category("Import Settings")]
        [Display(Name = "Select Base Mesh")]
        [Description("Select a base mesh to import on.")]
        public List<FileEntry> BaseMesh { get; set; }

        /// <summary>
        /// Fills empty sub meshes with dummy data
        /// </summary>
        [Category("Import Settings")]
        [Display(Name = "Preserve Submesh Order")]
        [Description("If selected empty submesh slots will be filled with placeholder data. This preserves the original submesh-material index. (Recommended)")]
        public bool FillEmpty { get; set; } = true;
        /// <summary>
        /// List of Archives for Morphtarget Import.
        /// </summary>
        [Browsable(false)]
        public List<ICyberGameArchive> Archives { get; set; } = new();
        /// <summary>
        /// String Override to display info in datagrid.
        /// </summary>
        /// <returns>String</returns>
        public override string ToString() => $"Mesh/Morphtarget | Import Format :  {importFormat}";
    }

    public enum GltfImportAsFormat
    {
        Mesh,
        Morphtarget,
        Anims,
        MeshWithRig,
        Rig
    }

    public class MlmaskImportArgs : ImportArgs
    {
        /// <summary>
        /// String Override to display info in datagrid.
        /// </summary>
        /// <returns>String</returns>
        public override string ToString() => "MLMASK";
    }

    /// <summary>
    /// Re to Animset import arguments
    /// </summary>
    public class ReImportArgs : ImportArgs
    {
        [Browsable(false)]
        public string RedMod { get; set; } = "";
        [Browsable(false)]
        public string Depot { get; set; } = "";
        [Browsable(false)]
        public string Input { get; set; } = "";
        [Browsable(false)]
        public string Animset { get; set; } = "";
        [Browsable(false)]
        public string AnimationToRename { get; set; } = "";
        [Category("Import Settings")]
        [Display(Name = "Outfile")]
        [Description("resource .animset file name to write (resource path must start with base//)")]
        public string Output { get; set; } = "";
        /// <summary>
        /// String Override to display info in datagrid.
        /// </summary>
        /// <returns>String</returns>
        public override string ToString() => $"{Path.GetFileName(Animset)} - {AnimationToRename}";
    }
}
