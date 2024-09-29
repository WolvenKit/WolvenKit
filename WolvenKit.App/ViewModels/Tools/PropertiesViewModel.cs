using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Media.Imaging;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using HelixToolkit.SharpDX.Core;
using HelixToolkit.Wpf.SharpDX;
using WolvenKit.App.Extensions;
using WolvenKit.App.Models;
using WolvenKit.App.Models.Docking;
using WolvenKit.App.Services;
using WolvenKit.Common;
using WolvenKit.Common.Interfaces;
using WolvenKit.Core.Extensions;
using WolvenKit.Core.Interfaces;
using WolvenKit.Modkit.RED4.Tools;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.CR2W;
using WolvenKit.RED4.Types;
using static WolvenKit.App.ViewModels.Documents.RDTMeshViewModel;
using Path = System.IO.Path;

namespace WolvenKit.App.ViewModels.Tools;

public partial class PropertiesViewModel : ToolViewModel
{
    #region fields

    private readonly ILoggerService _loggerService;
    private readonly ISettingsManager _settingsManager;
    private readonly IProjectManager _projectManager;
    private readonly MeshTools _meshTools;
    private readonly IModTools _modTools;
    private readonly Red4ParserService _parser;

    public const string ToolContentId = "Properties_Tool";
    public const string ToolTitle = "File Information";

    public enum TexturePreviewExtensions { xbm, envprobe, mesh, cubemap, xcube, texarray };

    public enum MeshPreviewExtensions { mesh, ent, w2mesh, physicalscene, morphtarget };
    public enum AudioPreviewExtensions { wem };

    public EffectsManager EffectsManager { get; }

    public SharpDX.BoundingBox ModelGroupBounds { get; set; } = new();

    public Camera Camera { get; }

    public SmartElement3DCollection ModelGroup { get; set; } = new();

    public uint SelectedLOD { get; set; } = 1;

    #endregion

    /// <summary>
    /// Constructor PropertiesViewModel
    /// </summary>
    /// <param name="projectManager"></param>
    /// <param name="loggerService"></param>
    /// <param name="meshTools"></param>
    public PropertiesViewModel(
        IProjectManager projectManager,
        ILoggerService loggerService,
        ISettingsManager settingsManager,
        MeshTools meshTools,
        IModTools modTools,
        Red4ParserService parserService
    ) : base(ToolTitle)
    {
        _settingsManager = settingsManager;
        _projectManager = projectManager;
        _loggerService = loggerService;
        _meshTools = meshTools;
        _modTools = modTools;
        _parser = parserService;

        SetupToolDefaults();
        SideInDockedMode = DockSide.Left;

        SetToNullAndResetVisibility();


        EffectsManager = new DefaultEffectsManager();
        Camera = new PerspectiveCamera()
        {
            FarPlaneDistance = 1E+8,
            LookDirection = new System.Windows.Media.Media3D.Vector3D(1f, -1f, -1f),
        };
    }

    #region properties
    
    [ObservableProperty] private AudioObject? _audioObject;
    
    [ObservableProperty] private int _selectedIndex;

    [ObservableProperty] private FileSystemModel? _pE_SelectedItem;

    /// <summary>
    /// Selected Item from Asset Browser If Available.
    /// </summary>
    [ObservableProperty] private IFileSystemViewModel? _aB_SelectedItem;

    /// <summary>
    /// Decides if Asset browser Selected File info should be visible.
    /// </summary>
    [ObservableProperty] private bool _aB_FileInfoVisible;

    /// <summary>
    /// Decides if Project Explorer Selected file info should be Visible.
    /// </summary>
    [ObservableProperty] private bool _pE_FileInfoVisible;

    /// <summary>
    /// Decides if the mesh previewer Tab should be visible or not.
    /// </summary>
    [ObservableProperty] private bool _isMeshPreviewVisible;

    [ObservableProperty] private bool _isAudioPreviewVisible;
    [ObservableProperty] private bool _isImagePreviewVisible;
    [ObservableProperty] private bool _isVideoPreviewVisible;

    [ObservableProperty] private string? _exeCommand;

    [ObservableProperty] private string? _loadedModelPath;

    [ObservableProperty] private BitmapSource? _loadedBitmapFrame;

    #endregion properties

    #region commands

    [RelayCommand]
    private void PreviewAudio(AudioObject obj)
    {
        AudioObject = obj;
    }


    private bool CanOpenFile(FileSystemModel model) => model != null;

    /// <summary>
    /// Called from Assetbrowser
    /// </summary>
    /// <param name="model"></param>
    /// <returns></returns>
    public void ExecuteSelectFile(IFileSystemViewModel model)
    {
        if (model == null)
        {
            return;
        }

        if (State is DockState.AutoHidden or DockState.Hidden)
        {
            return;
        }

        AB_SelectedItem = model;
        AB_FileInfoVisible = true;
        PE_FileInfoVisible = false;

        SelectedIndex = 0;
        IsMeshPreviewVisible = false;
        IsAudioPreviewVisible = false;
        IsImagePreviewVisible = false;
        IsVideoPreviewVisible = false;

        if (!_settingsManager.ShowFilePreview)
        {
            return;
        }

        if (model is not RedFileViewModel selectedItem)
        {
            return;
        }

        var extension = model.DisplayExtension;

        if (Enum.TryParse<TexturePreviewExtensions>(extension, true, out _) ||
            Enum.TryParse<MeshPreviewExtensions>(extension, true, out _) ||
            Enum.TryParse<AudioPreviewExtensions>(extension, true, out _))
        {
            CR2WFile? cr2w = null;
            using (var stream = new MemoryStream())
            {
                var selectedGameFile = selectedItem.GetGameFile();
                selectedGameFile.Extract(stream);
                if (!_parser.TryReadRed4File(stream, out cr2w))
                {
                    PreviewStream(stream, model.FullName);
                }
                else if (cr2w.RootChunk is MorphTargetMesh mt && mt.BaseMesh.DepotPath.GetResolvedText() is string meshPath)
                {
                } 
            }
            if (cr2w != null)
            {
                PreviewCr2wFile(cr2w);
            }
        }
    }

    /// <summary>
    /// Called from PropertyExplorer
    /// </summary>
    /// <param name="model"></param>
    /// <returns></returns>
    public void ExecuteSelectFile(FileSystemModel model)
    {
        if (model == null)
        {
            return;
        }

        if (State is DockState.AutoHidden or DockState.Hidden)
        {
            return;
        }

        PE_SelectedItem = model;
        PE_FileInfoVisible = true;
        AB_FileInfoVisible = false;

        SelectedIndex = 0;
        IsMeshPreviewVisible = false;
        IsAudioPreviewVisible = false;
        IsImagePreviewVisible = false;
        IsVideoPreviewVisible = false;

        if (!_settingsManager.ShowFilePreview)
        {
            return;
        }

        if (model.IsDirectory)
        {
            return;
        }

        var extension = Path.GetExtension(model.FullName).TrimStart('.');

        if (Enum.TryParse<TexturePreviewExtensions>(extension, true, out _) ||
            Enum.TryParse<MeshPreviewExtensions>(extension, true, out _) ||
            Enum.TryParse<AudioPreviewExtensions>(extension, true, out _) ||
            Enum.TryParse<EUncookExtension>(extension, true, out _))
        {
            CR2WFile? cr2w = null;
            using (var stream = new FileStream(model.FullName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite, 4096, FileOptions.SequentialScan))
            {
                if (!_parser.TryReadRed4File(stream, out cr2w))
                {
                    PreviewPhysicalFile(model.FullName);
                }
            }
            if (cr2w != null)
            {
                PreviewCr2wFile(cr2w);
            }
        }
    }

    /// <summary>
    /// Internal
    /// </summary>
    /// <param name="stream"></param>
    /// <param name="filename"></param>
    /// <returns></returns>
    private void PreviewStream(Stream stream, string filename)
    {
        var extension = Path.GetExtension(filename).TrimStart('.');
        stream.Seek(0, SeekOrigin.Begin);

        if (Enum.TryParse<AudioPreviewExtensions>(extension, true, out _))
        {
            IsAudioPreviewVisible = true;
            SelectedIndex = 2;

            AudioObject = new AudioObject(Path.GetFileNameWithoutExtension(filename), stream.ToByteArray());
        }
    }

    /// <summary>
    /// Internal
    /// </summary>
    /// <param name="stream"></param>
    /// <param name="filename"></param>
    /// <returns></returns>
    private void PreviewPhysicalFile(string filename)
    {
        var extension = Path.GetExtension(filename).TrimStart('.');

        if (Enum.TryParse<AudioPreviewExtensions>(extension, true, out _))
        {
            IsAudioPreviewVisible = true;
            SelectedIndex = 2;

            AudioObject = new AudioObject(Path.GetFileNameWithoutExtension(filename), File.ReadAllBytes(filename));
        }
        else if (Enum.TryParse<EUncookExtension>(extension, true, out var ext))
        {
            SetupRawImage(filename, ext);
        }
    }

    private void PreviewCr2wFile(CR2WFile cr2w)
    {
        if (cr2w.RootChunk is CMesh or MorphTargetMesh)
        {
            LoadModel(cr2w.RootChunk);
        }

        if (cr2w.RootChunk is CBitmapTexture cbt &&
            cbt.RenderTextureResource.RenderResourceBlobPC?.GetValue() is rendRenderTextureBlobPC)
        {
            SetupImage(cbt);
        }

        if (cr2w.RootChunk is CCubeTexture cct &&
            cct.RenderTextureResource.RenderResourceBlobPC?.GetValue() is rendRenderTextureBlobPC)
        {
            SetupImage(cct);
        }

        if (cr2w.RootChunk is CTextureArray cta &&
            cta.RenderTextureResource.RenderResourceBlobPC?.GetValue() is rendRenderTextureBlobPC)
        {
            SetupImage(cta);
        }

        if (cr2w.RootChunk is CMesh cm && cm.RenderResourceBlob?.GetValue() is rendRenderTextureBlobPC)
        {
            SetupImage(cm);
        }

        if (cr2w.RootChunk is CReflectionProbeDataResource crpdr &&
            crpdr.TextureData.RenderResourceBlobPC.GetValue() is rendRenderTextureBlobPC)
        {
            SetupImage(crpdr);
        }
    }

    public void SetupImage(RedBaseClass cls)
    {
        var image = RedImage.FromRedClass(cls);

        var bitmapImage = new BitmapImage();
        bitmapImage.BeginInit();
        bitmapImage.StreamSource = new MemoryStream(image.GetPreview(true));
        bitmapImage.EndInit();

        LoadedBitmapFrame = bitmapImage;

        IsImagePreviewVisible = true;
        SelectedIndex = 3;
    }

    public void SetupRawImage(string fileName, EUncookExtension ext)
    {
        var image = RedImage.LoadFromFile(fileName);
        if (image == null)
        {
            _loggerService.Error($"\"{fileName}\" could not be loaded!");
            return;
        }

        var bitmapImage = new BitmapImage();
        bitmapImage.BeginInit();
        bitmapImage.StreamSource = new MemoryStream(image.GetPreview(false));
        bitmapImage.EndInit();

        LoadedBitmapFrame = bitmapImage;
        IsImagePreviewVisible = true;
        SelectedIndex = 3;
    }

    public void LoadModel(RedBaseClass cls)
    {
        try
        {
            var meshes = MakePreviewMesh(cls);

            IsMeshPreviewVisible = true;
            SelectedIndex = 1;

            var bounds = new SharpDX.BoundingBox();
            foreach (var mesh in meshes)
            {
                bounds = SharpDX.BoundingBox.Merge(bounds, mesh.BoundsWithTransform);
            }

            ModelGroupBounds = bounds;
            ModelGroup.Reset(meshes);
        }
        catch
        {

        }

    }

    public void LoadImage(BitmapSource p0) => LoadedBitmapFrame = p0;

    #endregion commands

    #region methods

    private bool _showWireFrame;

    public bool ShowWireFrame
    {
        get => _showWireFrame;
        set
        {
            _showWireFrame = value;
            foreach (var model in ModelGroup)
            {
                if (model is SubmeshComponent mesh)
                {
                    mesh.FillMode = _showWireFrame ? SharpDX.Direct3D11.FillMode.Wireframe : SharpDX.Direct3D11.FillMode.Solid;
                }
            }
        }
    }

    private List<SubmeshComponent> MakePreviewMesh(RedBaseClass cls, ulong chunkMask = ulong.MaxValue)
    {
        var rendblob = cls switch
        {
            CMesh { RenderResourceBlob.Chunk: rendRenderMeshBlob blob } => blob,
            MorphTargetMesh mt when mt.Blob.Chunk is rendRenderMorphTargetMeshBlob mtBlob &&
                                    mtBlob.BaseBlob.Chunk is rendRenderMeshBlob blob2 => blob2,
            _ => null
        };

        if (rendblob == null)
        {
            return [];
        }

        using var ms = new MemoryStream(rendblob.RenderBuffer.Buffer.GetBytes());

        var meshesinfo = MeshTools.GetMeshesinfo(rendblob);

        var expMeshes = MeshTools.ContainRawMesh(ms, meshesinfo, false, ulong.MaxValue);

        var list = new List<SubmeshComponent>();

        var index = 0;
        var material = new PBRMaterial()
        {
            EnableAutoTangent = true,
            RenderShadowMap = true,
            AlbedoColor = new SharpDX.Color4(0.5f, 0.5f, 0.5f, 1f),
            //EnableTessellation = true
        };
        foreach (var mesh in expMeshes)
        {
            ArgumentNullException.ThrowIfNull(mesh.positions);
            ArgumentNullException.ThrowIfNull(mesh.indices);
            ArgumentNullException.ThrowIfNull(mesh.normals);

            var positions = new Vector3Collection(mesh.positions.Length);
            for (var i = 0; i < mesh.positions.Length; i++)
            {
                positions.Add(mesh.positions[i].ToVector3());
            }

            var indices = new IntCollection(mesh.indices.Length);
            for (var i = 0; i < mesh.indices.Length; i++)
            {
                indices.Add((int)mesh.indices[i]);
            }

            Vector3Collection normals;
            if (mesh.normals.Length > 0)
            {
                normals = new Vector3Collection(mesh.normals.Length);
                for (var i = 0; i < mesh.normals.Length; i++)
                {
                    normals.Add(mesh.normals[i].ToVector3());
                }
            }
            else
            {
                ComputeNormals(positions, indices, out normals);
            }

            var sm = new SubmeshComponent()
            {
                Name = $"submesh_{index:D2}_LOD_{meshesinfo.LODLvl[index]:D2}",
                LOD = meshesinfo.LODLvl[index],
                IsRendering = (chunkMask & 1UL << index) > 0 && meshesinfo.LODLvl[index] == SelectedLOD,
                EnabledWithMask = (chunkMask & 1UL << index) > 0,
                Geometry = new MeshGeometry3D()
                {
                    Positions = positions,
                    Indices = indices,
                    Normals = normals
                },
                DepthBias = -index * 2,
                Material = material,
                FillMode = ShowWireFrame ? SharpDX.Direct3D11.FillMode.Wireframe : SharpDX.Direct3D11.FillMode.Solid
            };

            list.Add(sm);
            index++;
        }

        return list;
    }


    /// <summary>
    /// Resets stuff each time a new item is selected.
    /// </summary>
    public void SetToNullAndResetVisibility()
    {
        // Asset Browser
        AB_SelectedItem = null;
        AB_FileInfoVisible = false;

        // Project Explorer
        PE_SelectedItem = null;
        PE_FileInfoVisible = false;

        IsAudioPreviewVisible = false;
        IsMeshPreviewVisible = false;
        IsImagePreviewVisible = false;
    }

    /// <summary>
    /// Initialize Syncfusion specific defaults that are specific to this tool window.
    /// </summary>
    private void SetupToolDefaults() => ContentId = ToolContentId;

    #endregion

}
