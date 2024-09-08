using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using DynamicData;
using Microsoft.Extensions.Logging;
using SharpGLTF.Validation;
using WolvenKit.RED4.Archive;
using WolvenKit.RED4.CR2W;
using WolvenKit.RED4.Types;
using static WolvenKit.RED4.Types.Enums;

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
    public partial class XbmImportArgs : ImportArgs
    {
        private GpuWrapApieTextureGroup _textureGroup = GpuWrapApieTextureGroup.TEXG_Generic_Color;

        [Category("General Import Settings")]
        [Display(Name = "Texture Group")]
        [Description("Select the texture group of the imported item, e.g. TEXG_Generic_Color or TEXG_Generic_Normal")]
        public GpuWrapApieTextureGroup TextureGroup
        {
            get => _textureGroup;
            set => SetProperty(ref _textureGroup, value);
        }
   
        [Category("Image Import Settings")]
        [Display(Name = "Raw Format")]
        public ETextureRawFormat RawFormat { get; set; } = ETextureRawFormat.TRF_TrueColor;

        [Category("Image Import Settings")]
        [Display(Name = "Compression (TCM_None to disable)")]
        [Description("Compression algorithm to use on texture. TCM_None will import without compression")]
        public ETextureCompression Compression { get; set; }

        [Category("Image Import Settings")]
        [Display(Name = "Generate mipMaps")]
        [Description("mipMaps are a sequence of images in various levels of resolution")]
        public bool GenerateMipMaps { get; set; } = true;

        [Category("Image Import Settings")]
        [Display(Name = "Is Streamable")]
        [Description("Set this to true for in-game assets, and to false for fonts, UI elements, LUTs etc")]
        public bool IsStreamable { get; set; } = true;

        [Category("Image Color Settings")]
        [Display(Name = "Transparency from alpha channel")]
        [Description("Create transparency from alpha channel? (Will be ignored unless you set IsMasked property of MaterialInstance)")]
        public bool PremultiplyAlpha { get; set; } = false;

        [Category("Image Color Settings")]
        [Display(Name = "SRGB (IsGamma)")]
        [Description("Should the file be handled as a SRGB file, or is this a data texture (e.g. a normal map)?")]
        public bool IsGamma { get; set; } = false;

        public XbmImportArgs()
        {
            Keep = false;
            GenerateMipMaps = true;
        }

        public XbmImportArgs(GpuWrapApieTextureGroup texGroup)
        {
            Keep = false;
            GenerateMipMaps = true;
            _textureGroup = texGroup;
            IsGamma = _textureGroup is GpuWrapApieTextureGroup.TEXG_Generic_Color
                or GpuWrapApieTextureGroup.TEXG_Multilayer_Color
                or GpuWrapApieTextureGroup.TEXG_Generic_UI;
        }

        public XbmImportArgs(STextureGroupSetup xbmSetup) : this(xbmSetup, xbmSetup.HasMipchain)
        {
        }

        public XbmImportArgs(STextureGroupSetup xbmSetup, bool generateMipMaps)
        {
            Compression = Enum.Parse<ETextureCompression>(xbmSetup.Compression.ToString());
            GenerateMipMaps = generateMipMaps;
            IsGamma = xbmSetup.IsGamma;
            RawFormat = Enum.Parse<ETextureRawFormat>(xbmSetup.RawFormat.ToString());
            _textureGroup = xbmSetup.Group;
        }

        /// <summary>
        /// String Override to display info in datagrid.
        /// </summary>
        /// <returns>String</returns>
        public override string ToString()
        {
            List<string> stringArgs = [];
            stringArgs.Add(TextureGroup.ToString().Replace("TEXG_", ""));

            if (PremultiplyAlpha)
            {
                stringArgs.Add("transparency \u2713");
            }

            if (IsGamma)
            {
                stringArgs.Add("SRGB \u2713");
            }

            if (GenerateMipMaps)
            {
                stringArgs.Add("mipMaps \u2713");
            }

            stringArgs.Add($"Compression: {Compression.ToString()}");
            stringArgs.Add($"raw format: {RawFormat.ToString()}");

            return string.Join(" | ", stringArgs);
        }
    }

    /// <summary>
    /// Mesh Import Arguments
    /// </summary>
    public class GltfImportArgs : ImportArgs
    {
        private GltfImportAsFormat _importFormat = GltfImportAsFormat.Mesh;

        /// <summary>
        /// Imports garment support data from GLB.
        /// </summary>
        [Category("Import Settings")]
        [Display(Name = "Import Garment Support")]
        [Description("Import Garment Support data from mesh?")]
        public bool ImportGarmentSupport { get; set; } = true;

        /// <summary>
        /// Imports Inverse Binding data from GLB.
        /// </summary>
        [Category("Import Settings")]
        [Display(Name = "Import Inverse Binding")]
        [Description("Imports Inverse Binding data from mesh only")]
        public bool ImportInverseBindingOnly { get; set; } = true;
        /// <summary>
        /// Use object or node name as mesh name
        /// </summary>
        [Category("Compatibility Settings")]
        [Display(Name = "Use Object Name as Submesh Name")]
        [Description("If checked, each submesh name will be overridden by the node name (e.g. Blender object) to match previous behavior.")]
        public bool OverrideMeshNameWithNodeName { get; set; } = true;

        /// <summary>
        /// Log level output
        /// </summary>
        [property: Browsable(false)]
        public bool ShowVerboseLogOutput { get; set; } = false;

        /// <summary>
        /// Strip Bind Pose transform from additive animations
        /// </summary>
        [Category("Animation Settings")]
        [Display(Name = "Strip Local Transform from Additives")]
        [Description("Only uncheck if your additive animations don't include joint's Local Transform (export selection) or you're certain you know what you're doing.")]
        public bool AdditiveStripLocalTransform { get; set; } = true;

        /// <summary>
        /// Should a Material.Json be imported?
        /// </summary>
        [Category("Import Settings")]
        [Display(Name = "Import Material.Json")]
        [Description("Mesh materials will be overwritten from the Material.json file.")]
        public bool ImportMaterials { get; set; } = false;

        /// <summary>
        /// Should only materials be imported and no mesh data be changed?
        /// </summary>
        [Category("Import Settings")]
        [Display(Name = "Only Material.Json Only")]
        [Description("Will not import mesh geometry, but only read the Material.json file.")]
        public bool ImportMaterialOnly { get; set; } = false;

        /// <summary>
        /// Validation type for the selected GLB/GLTF.
        /// </summary>
        [Category("Import Settings")]
        [Display(Name = "GLTF Validation")]
        [Description("Optional validation check for glb/glTF files")]
        public ValidationMode ValidationMode { get; set; } = ValidationMode.Skip;

        /// <summary>
        /// RedEngine4 Cooked File type for the selected GLB/GLTF.
        /// </summary>
        [Category("Import Settings")]
        [Display(Name = "Target File Format")]
        public GltfImportAsFormat ImportFormat { get => _importFormat; set => SetProperty(ref _importFormat, value); }

        /// <summary>
        /// Fills empty sub meshes with dummy data
        /// </summary>
        [Category("Import Settings")]
        [Display(Name = "Preserve Submesh Order")]
        [Description("Empty submesh slots will be filled with placeholder data, preserving the original submesh-material order.")]
        public bool FillEmpty { get; set; } = false;

        /// <summary>
        /// Selected Rig for Mesh WithRig Export. ALWAYS USE THE FIRST ENTRY IN THE LIST.
        /// </summary>
        [Category("Import Settings")]
        [Display(Name = "Import into base mesh (experimental)")]
        [Description("Select a base mesh to import into (e.g. Netrunner suit)")]
        public List<FileEntry> BaseMesh { get; set; } = [];

        /// <summary>
        /// Selected Rig for Mesh WithRig Export. ALWAYS USE THE FIRST ENTRY IN THE LIST.
        /// </summary>
        [Category("WithRig Settings")]
        [Display(Name = "Select rig (experimental)")]
        [Description("Select a rig to import within the mesh. Will always use the first entry in the list")]
        public List<FileEntry> Rig { get; set; } = new();

        /// <summary>
        /// UNKNOWN
        /// </summary>
        [Category("WithRig Settings")]
        [Display(Name = "Use selected rig (experimental)")]
        [Description("If selected the corresponding archive file will be used for importing.")]
        public bool KeepRig { get; set; } = false;

        /// <summary>
        /// String Override to display info in data grid.
        /// </summary>
        /// <returns>String</returns>
        public override string ToString()
        {
            var stringParts = new List<string>();
            switch (ImportFormat)
            {
                case GltfImportAsFormat.Anims:
                    stringParts.Add("Animation");
                    break;
                case GltfImportAsFormat.Morphtarget:
                    stringParts.Add("Morphtarget");
                    break;
                case GltfImportAsFormat.Rig:
                    stringParts.Add("Armature");
                    break;
                case GltfImportAsFormat.PhysicalScene:
                default:
                case GltfImportAsFormat.MeshWithRig:
                case GltfImportAsFormat.Mesh:
                    stringParts.Add("Mesh");
                    break;
            }

            if (ImportMaterials)
            {
                stringParts.Add("material \u2713");
            }
            else if (ImportMaterialOnly)
            {
                stringParts.Add("only material");
            }

            if (ImportGarmentSupport)
            {
                stringParts.Add("garmentSupport \u2713");
            }

            return string.Join(" | ", stringParts);
        } 
    }

    public enum GltfImportAsFormat
    {
        Mesh,
        Morphtarget,
        Anims,
        MeshWithRig,
        Rig,
        PhysicalScene
    }

    public class MlmaskImportArgs : ImportArgs
    {
        /// <summary>
        /// String Override to display info in datagrid.
        /// </summary>
        /// <returns>String</returns>
        public override string ToString() => "mlmask";
    }

    /// <summary>
    /// Re to Animset import arguments
    /// </summary>
    public class ReImportArgs : ImportArgs
    {
        private string _animset = "";
        private string _animationToRename = "";

        [Browsable(false)]
        public string RedMod { get; set; } = "";

        [Browsable(false)]
        public string Depot { get; set; } = "";

        [Browsable(false)]
        public string Input { get; set; } = "";

        [Browsable(false)]
        public string Animset { get => _animset; set => SetProperty(ref _animset, value); }
        [Browsable(false)]
        public string AnimationToRename { get => _animationToRename; set => SetProperty(ref _animationToRename, value); }
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
