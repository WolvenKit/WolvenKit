using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
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
        public SupportedRawFormats RawFormat { get; set; } = SupportedRawFormats.TRF_TrueColor;

        [Category("Image Import Settings")]
        public SupportedCompressionFormats Compression { get; set; }

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

    // Formats used in the v1.52 game files
    public enum SupportedRawFormats
    {
        TRF_Invalid, // = 0,
        TRF_TrueColor, // = 1,
        TRF_DeepColor, // = 2,
        TRF_Grayscale, // = 3,
        TRF_HDRFloat, // = 4,
        TRF_HDRHalf, // = 5,
        TRF_HDRFloatGrayscale, // = 6,
        // TRF_Grayscale_Font, // = 7,
        TRF_R8G8, // = 8,
        // TRF_R32UI, // = 9,
        // TRF_AlphaGrayscale, // = 0
    }

    // Formats used in the v1.52 game files
    public enum SupportedCompressionFormats
    {
        TCM_None, // = 0,
        TCM_DXTNoAlpha, // = 1,
        TCM_DXTAlpha, // = 2,
        // TCM_RGBE, // = 3,
        TCM_Normalmap, // = 4,
        TCM_Normals_DEPRECATED, // = 5,
        TCM_NormalsHigh_DEPRECATED, // = 6,
        // TCM_NormalsGloss_DEPRECATED, // = 7,
        // TCM_TileMap, // = 8,
        TCM_DXTAlphaLinear, // = 9,
        TCM_QualityR, // = 10,
        TCM_QualityRG, // = 11,
        TCM_QualityColor, // = 12,
        TCM_HalfHDR_Unsigned, // = 13,
        // TCM_HalfHDR_Signed, // = 14,
        // TCM_Max, // = 15,
        // TCM_Normals, // = 5,
        // TCM_NormalsHigh, // = 6,
        // TCM_NormalsGloss, // = 7,
        // TCM_HalfHDR, // = 13
    }
}
