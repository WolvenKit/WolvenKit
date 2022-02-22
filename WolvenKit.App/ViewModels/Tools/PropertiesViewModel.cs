using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using CP77.CR2W;
using HelixToolkit.SharpDX.Core;
using HelixToolkit.Wpf.SharpDX;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using WolvenKit.Common;
using WolvenKit.Common.Interfaces;
using WolvenKit.Common.Services;
using WolvenKit.Functionality.Ab4d;
using WolvenKit.Functionality.Commands;
using WolvenKit.Functionality.Extensions;
using WolvenKit.Functionality.Services;
using WolvenKit.Models;
using WolvenKit.Models.Docking;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.CR2W;
using WolvenKit.RED4.Types;
using WolvenKit.ViewModels.Documents;
using static WolvenKit.ViewModels.Documents.RDTMeshViewModel;

namespace WolvenKit.ViewModels.Tools
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
        public const string ToolTitle = "Properties";

        public EffectsManager EffectsManager { get; }

        public SharpDX.BoundingBox ModelGroupBounds { get; set; } = new();

        public HelixToolkit.Wpf.SharpDX.Camera Camera { get; }

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
            //_parser = Locator.Current.GetService<Red4ParserService>();

            SetupToolDefaults();
            SideInDockedMode = DockSide.Left;

            SetToNullAndResetVisibility();

            PreviewAudioCommand = ReactiveCommand.Create<string, string>(str => str);

            EffectsManager = new DefaultEffectsManager();
            Camera = new HelixToolkit.Wpf.SharpDX.PerspectiveCamera()
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

            if (model is not RedFileViewModel selectedItem)
            {
                return;
            }

            using (var stream = new MemoryStream())
            {
                var selectedGameFile = selectedItem.GetGameFile();
                selectedGameFile.Extract(stream);
                await ExecuteSelectFile(stream, model.FullName);
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
            if (!_settingsManager.ShowFilePreview)
            {
                return;
            }

            var filename = model.FullName;

            // check additional changes
            if (model.IsDirectory)
            {
                return;
            }

            using (var stream = new FileStream(filename, FileMode.Open, FileAccess.Read, FileShare.ReadWrite, 4096, FileOptions.SequentialScan))
            {
                await ExecuteSelectFile(stream, filename);
            }
        }

        public async Task ExecuteSelectFile(Stream stream, string filename)
        {
            var extension = Path.GetExtension(filename).TrimStart('.');

            SelectedIndex = 0;
            IsMeshPreviewVisible = false;
            IsAudioPreviewVisible = false;
            IsImagePreviewVisible = false;
            IsVideoPreviewVisible = false;

            if (extension.Length > 0)
            {
                //if (string.Equals(extension, ERedExtension.bk2.ToString(),
                //   System.StringComparison.OrdinalIgnoreCase))
                //{
                //    IsVideoPreviewVisible = true;
                //    SetExeCommand?.Invoke("test.exe | test2.bk2 /J /I2 /P");
                //}

                if (Enum.IsDefined(typeof(EConvertableOutput), extension) ||
                    string.Equals(extension, ERedExtension.mesh.ToString(), StringComparison.OrdinalIgnoreCase) ||
                    string.Equals(extension, ERedExtension.w2mesh.ToString(), StringComparison.OrdinalIgnoreCase) ||
                    string.Equals(extension, ERedExtension.ent.ToString(), StringComparison.OrdinalIgnoreCase) ||
                    string.Equals(extension, ERedExtension.physicalscene.ToString(), StringComparison.OrdinalIgnoreCase))
                {
                    IsMeshPreviewVisible = true;
                    SelectedIndex = 1;

                    LoadModel(stream);

                    //var outPath = Path.Combine(ISettingsManager.GetTemp_OBJPath(), Path.GetFileName(filename));
                    //outPath = Path.ChangeExtension(outPath, ".glb");
                    //if (File.Exists(outPath))
                    //{
                    //    LoadModel(outPath);
                    //    PE_MeshPreviewVisible = true;
                    //    SelectedIndex = 1;
                    //}
                    //else
                    //{
                    //    using (var meshStream = new FileStream(filename, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                    //    {
                    //        meshStream.Seek(0, SeekOrigin.Begin);
                    //        if (_meshTools.ExportMeshPreviewer(meshStream, new FileInfo(outPath)))
                    //        {
                    //            LoadModel(outPath);
                    //            PE_MeshPreviewVisible = true;
                    //            SelectedIndex = 1;
                    //        }
                    //        meshStream.Dispose();
                    //        meshStream.Close();
                    //    }
                    //}
                }

                if (string.Equals(extension, ERedExtension.wem.ToString(),
                    System.StringComparison.OrdinalIgnoreCase))
                {
                    IsAudioPreviewVisible = true;
                    SelectedIndex = 2;

                    PreviewAudioCommand.SafeExecute(filename);
                }

                // textures
                if (Enum.TryParse<EUncookExtension>(extension,
                        out _))
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

                // xbm
                if (string.Equals(extension, ERedExtension.xbm.ToString(), StringComparison.OrdinalIgnoreCase) ||
                    //string.Equals(extension, ERedExtension.mesh.ToString(), StringComparison.OrdinalIgnoreCase) ||
                    string.Equals(extension, ERedExtension.envprobe.ToString(), StringComparison.OrdinalIgnoreCase))
                {

                    // convert xbm to dds stream
                    await using var ddsstream = new MemoryStream();
                    //await using var filestream = new FileStream(filename,
                    //    FileMode.Open, FileAccess.Read, FileShare.ReadWrite, 4096, FileOptions.SequentialScan);
                    if (_modTools.ConvertXbmToDdsStream(stream, ddsstream, out _))
                    {
                        // try loading it in pfim
                        try
                        {
                            var qa = await ImageDecoder.RenderToBitmapSourceDds(ddsstream);
                            if (qa != null)
                            {
                                LoadImage(qa);
                                IsImagePreviewVisible = true;
                                SelectedIndex = 3;
                            }
                        }
                        catch (Exception)
                        {
                            throw;
                        }
                    }
                }
            }
        }

        public void LoadModel(string s)
        {
            using (var stream = new FileStream(s, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                LoadModel(stream);
            }
        }

        public void LoadModel(Stream stream)
        {
            using var reader = new BinaryReader(stream);
            var cr2wFile = _parser.ReadRed4File(reader);
            var meshes = MakePreviewMesh(cr2wFile.RootChunk);

            ModelGroupBounds = new SharpDX.BoundingBox();
            foreach (var mesh in meshes)
            {
                ModelGroupBounds = SharpDX.BoundingBox.Merge(ModelGroupBounds, mesh.BoundsWithTransform);
            }

            ModelGroup.Reset(meshes);

            //Camera.view(ModelGroupBounds, 0);
            ////Camera.Position = ModelGroupBounds.Center.ToPoint3D();
            //Camera.LookAt(ModelGroupBounds.Center.ToPoint3D(), 0);
        }

        public void LoadImage(BitmapSource p0) => LoadedBitmapFrame = p0;

        #endregion commands

        #region methods

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
                RenderEnvironmentMap = true,
                AlbedoColor = new SharpDX.Color4(0.5f, 0.5f, 0.5f, 1f)
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
                    ComputeNormals(positions, indices, out normals);
                }

                var sm = new SubmeshComponent()
                {
                    Name = $"submesh_{index:D2}_LOD_{meshesinfo.LODLvl[index]:D2}",
                    LOD = meshesinfo.LODLvl[index],
                    IsRendering = (chunkMask & 1UL << index) > 0 && meshesinfo.LODLvl[index] == SelectedLOD,
                    EnabledWithMask = (chunkMask & 1UL << index) > 0,
                    Geometry = new HelixToolkit.SharpDX.Core.MeshGeometry3D()
                    {
                        Positions = positions,
                        Indices = indices,
                        Normals = normals
                    },
                    DepthBias = -index * 2,
                    Material = material
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
