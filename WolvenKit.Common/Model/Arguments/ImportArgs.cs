using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using SharpGLTF.Validation;
using WolvenKit.RED4.Archive;
using WolvenKit.RED4.Types;

namespace WolvenKit.Common.Model.Arguments
{
    /// <summary>
    /// Import Arguments
    /// </summary>
    public abstract class ImportArgs : ImportExportArgs
    {
        [Category("Default Import Settings")]
        [Display(Name = "Use existing file")]
        [Description("If checked the corresponding archive file will be used for importing.")]
        public bool Keep { get; set; } = true;
        [Category("Default Import Settings")]
        [Display(Name = "Use selected base mesh")]
        [Description("If checked the specified mesh file will be used for importing.")]
        public bool SelectBase { get; set; } = false;
        [Category("Default Import Settings")]
        [Display(Name = "Use selected rig")]
        [Description("If selected the corresponding archive file will be used for importing.")]
        public bool KeepRig { get; set; } = false;
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
        public Enums.GpuWrapApieTextureGroup TextureGroup { get; internal set; } =
            Enums.GpuWrapApieTextureGroup.TEXG_Generic_Color;

        public bool IsGamma { get; set; }

        public XbmImportArgs()
        {
            Keep = false;
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
        public List<Archive> Archives { get; set; } = new();
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


}
