using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using HelixToolkit.SharpDX.Core;
using HelixToolkit.Wpf.SharpDX;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using WolvenKit.App.Commands.Base;
using WolvenKit.App.Functionality.Extensions;
using WolvenKit.App.Functionality.Other;
using WolvenKit.App.Models;
using WolvenKit.App.Models.Docking;
using WolvenKit.App.Services;
using WolvenKit.App.ViewModels.Documents;
using WolvenKit.Common;
using WolvenKit.Common.Interfaces;
using WolvenKit.Common.Services;
using WolvenKit.Modkit.RED4;
using WolvenKit.Modkit.RED4.Tools;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.CR2W;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.Tools
{
    public class PropertiesViewModel : ToolViewModel
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

        public enum TexturePreviewExtensions { xbm, envprobe, mesh };
        public enum MeshPreviewExtensions { mesh, ent, w2mesh, physicalscene };
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

            PreviewAudioCommand = ReactiveCommand.Create<string, string>(str => str);

            EffectsManager = new DefaultEffectsManager();
            Camera = new PerspectiveCamera()
            {
                FarPlaneDistance = 1E+8,
                LookDirection = new System.Windows.Media.Media3D.Vector3D(1f, -1f, -1f),
            };
        }

        #region properties
        [Reactive] public int SelectedIndex { get; set; }

        [Reactive] public FileModel PE_SelectedItem { get; set; }

        /// <summary>
        /// Selected Item from Asset Browser If Available.
        /// </summary>
        [Reactive] public IFileSystemViewModel AB_SelectedItem { get; set; }

        /// <summary>
        /// Decides if Asset browser Selected File info should be visible.
        /// </summary>
        [Reactive] public bool AB_FileInfoVisible { get; set; }

        /// <summary>
        /// Decides if Project Explorer Selected file info should be Visible.
        /// </summary>
        [Reactive] public bool PE_FileInfoVisible { get; set; }

        /// <summary>
        /// Decides if the mesh previewer Tab should be visible or not.
        /// </summary>
        [Reactive] public bool IsMeshPreviewVisible { get; set; }

        [Reactive] public bool IsAudioPreviewVisible { get; set; }
        [Reactive] public bool IsImagePreviewVisible { get; set; }
        [Reactive] public bool IsVideoPreviewVisible { get; set; }

        [Reactive] public string ExeCommand { get; set; }

        [Reactive] public string LoadedModelPath { get; set; }

        [Reactive] public BitmapSource LoadedBitmapFrame { get; set; }

        #endregion properties

        #region commands

        public ReactiveCommand<string, string> PreviewAudioCommand { get; set; }

        public ICommand FileSelectedCommand { get; private set; }

        private bool CanOpenFile(FileModel model) => model != null;

        public async Task ExecuteSelectFile(IFileSystemViewModel model)
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
                CR2WFile cr2w = null;
                using (var stream = new MemoryStream())
                {
                    var selectedGameFile = selectedItem.GetGameFile();
                    selectedGameFile.Extract(stream);
                    _ = _parser.TryReadRed4File(stream, out cr2w);
                }
                if (cr2w != null)
                {
                    await ExecuteSelectFile(cr2w, model.FullName);
                }
            }
        }

        public async Task ExecuteSelectFile(FileModel model)
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
                Enum.TryParse<AudioPreviewExtensions>(extension, true, out _))
            {
                CR2WFile cr2w = null;
                using (var stream = new FileStream(model.FullName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite, 4096, FileOptions.SequentialScan))
                {
                    if (!_parser.TryReadRed4File(stream, out cr2w))
                    {
                        await ExecuteSelectFile(stream, model.FullName);
                    }
                }
                if (cr2w != null)
                {
                    await ExecuteSelectFile(cr2w, model.FullName);
                }
            }
        }

        public async Task ExecuteSelectFile(Stream stream, string filename)
        {
            var extension = Path.GetExtension(filename).TrimStart('.');

            if (Enum.IsDefined(typeof(EConvertableOutput), extension))
            {

            }

            if (Enum.TryParse<AudioPreviewExtensions>(extension, true, out _))
            {
                IsAudioPreviewVisible = true;
                SelectedIndex = 2;

                PreviewAudioCommand.SafeExecute(filename);
            }

            // textures
            if (Enum.TryParse<EUncookExtension>(extension, true, out _))
            {
                var q = await ImageDecoder.RenderToBitmapSource(filename);
                if (q != null)
                {
                    var g = BitmapFrame.Create(q);
                    LoadImage(g);
                    IsImagePreviewVisible = true;
                    SelectedIndex = 3;
                }
            }
        }

        public Task ExecuteSelectFile(CR2WFile cr2w, string filename)
        {
            //if (string.Equals(extension, ERedExtension.bk2.ToString(),
            //   System.StringComparison.OrdinalIgnoreCase))
            //{
            //    IsVideoPreviewVisible = true;
            //    SetExeCommand?.Invoke("test.exe | test2.bk2 /J /I2 /P");
            //}

            if (cr2w.RootChunk is CMesh cmesh)
            {
                LoadModel(cmesh);
            }

            if (cr2w.RootChunk is CBitmapTexture cbt &&
                cbt.RenderTextureResource.RenderResourceBlobPC != null &&
                cbt.RenderTextureResource.RenderResourceBlobPC.GetValue() is rendRenderTextureBlobPC)
            {
                SetupImage(cbt);
            }

            if (cr2w.RootChunk is CMesh cm && cm.RenderResourceBlob != null &&
                cm.RenderResourceBlob.GetValue() is rendRenderTextureBlobPC)
            {
                SetupImage(cm);
            }

            if (cr2w.RootChunk is CReflectionProbeDataResource crpdr &&
                crpdr.TextureData.RenderResourceBlobPC.GetValue() is rendRenderTextureBlobPC)
            {
                SetupImage(crpdr);
            }

            return Task.CompletedTask;
        }

        public void SetupImage(RedBaseClass cls)
        {
            using var ddsstream = new MemoryStream();
            try
            {
                if (ModTools.ConvertRedClassToDdsStream(cls, ddsstream, out _))
                {
                    _ = LoadImageFromStream(ddsstream);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                //throw;
            }
        }

        public async Task LoadImageFromStream(Stream stream)
        {
            var qa = await ImageDecoder.RenderToBitmapSourceDds(stream);
            if (qa != null)
            {
                //Image = qa;
                LoadedBitmapFrame = new TransformedBitmap(qa, new ScaleTransform(1, -1));

                IsImagePreviewVisible = true;
                SelectedIndex = 3;
            }
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

        public List<SubmeshComponent> MakePreviewMesh(RedBaseClass cls, ulong chunkMask = ulong.MaxValue)
        {
            rendRenderMeshBlob rendblob = null;

            if (cls is CMesh cMesh && cMesh.RenderResourceBlob != null && cMesh.RenderResourceBlob.Chunk is rendRenderMeshBlob blob)
            {
                rendblob = blob;
            }

            if (rendblob == null)
            {
                return new List<SubmeshComponent>();
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
                    RDTMeshViewModel.ComputeNormals(positions, indices, out normals);
                }

                var sm = new SubmeshComponent()
                {
                    Name = $"submesh_{index:D2}_LOD_{meshesinfo.LODLvl[index]:D2}",
                    LOD = meshesinfo.LODLvl[index],
                    IsRendering = (chunkMask & (1UL << index)) > 0 && meshesinfo.LODLvl[index] == SelectedLOD,
                    EnabledWithMask = (chunkMask & (1UL << index)) > 0,
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


        #region AudioPreview

        /// <summary>
        /// Working directory for audio preview.
        /// </summary>
        //private const string wdir = "lib\\vgmstream\\AudioWorkingDir\\";

        /// <summary>
        /// audio file list for opuspak type files with multiple wems inside. (not visually implemented)
        /// </summary>
        public List<TextBlock> AudioFileList { get; set; } = new List<TextBlock>();


        #endregion AudioPreview
    }
}
