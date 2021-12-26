using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Reactive;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Threading;
using CP77.CR2W;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using WolvenKit.Common;
using WolvenKit.Common.Extensions;
using WolvenKit.Common.Interfaces;
using WolvenKit.Common.Model;
using WolvenKit.Common.Services;
using WolvenKit.Functionality.Ab4d;
using WolvenKit.Functionality.Commands;
using WolvenKit.Functionality.Services;
using WolvenKit.Models;
using WolvenKit.Models.Docking;

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

        public const string ToolContentId = "Properties_Tool";
        public const string ToolTitle = "Properties";

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
            IModTools modTools
        ) : base(ToolTitle)
        {
            _settingsManager = settingsManager;
            _projectManager = projectManager;
            _loggerService = loggerService;
            _meshTools = meshTools;
            _modTools = modTools;

            SetupToolDefaults();
            SideInDockedMode = DockSide.Left;

            SetToNullAndResetVisibility();

            PreviewAudioCommand = ReactiveCommand.Create<string,string>(str => str);
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
        /// Decides if Asset browser Mesh preview should be visible.
        /// </summary>
        [Reactive] public bool AB_MeshPreviewVisible { get; set; }

        /// <summary>
        /// Decides if Project Explorer Mesh preview should be visible.
        /// </summary>
        [Reactive] public bool PE_MeshPreviewVisible { get; set; }

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

        public async Task ExecuteSelectFile(FileModel model)
        {
            SelectedIndex = 0;
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

            PE_MeshPreviewVisible = false;
            IsAudioPreviewVisible = false;
            IsImagePreviewVisible = false;
            IsVideoPreviewVisible = false;

            // check additional changes
            if (model.IsDirectory)
            {
                return;
            }

            if (PE_SelectedItem == null)
            {
                return;
            }
            // string.Equals(model.GetExtension(), ERedExtension.bk2.ToString(), StringComparison.OrdinalIgnoreCase) ||
            if (!(
              string.Equals(model.GetExtension(), ERedExtension.physicalscene.ToString(), StringComparison.OrdinalIgnoreCase) ||
              string.Equals(model.GetExtension(), ERedExtension.mesh.ToString(), StringComparison.OrdinalIgnoreCase) ||
              string.Equals(model.GetExtension(), ERedExtension.wem.ToString(), StringComparison.OrdinalIgnoreCase) ||
              string.Equals(model.GetExtension(), ERedExtension.xbm.ToString(), StringComparison.OrdinalIgnoreCase)
              || Enum.TryParse<EConvertableOutput>(PE_SelectedItem.GetExtension(), out _)
              || Enum.TryParse<EUncookExtension>(PE_SelectedItem.GetExtension(), out _)
            ))
            {
                return;
            }

            if (PE_SelectedItem != null)
            {
                if (PE_SelectedItem.GetExtension().Length > 0)
                {
                    //if (string.Equals(PE_SelectedItem.GetExtension(), ERedExtension.bk2.ToString(),
                    //   System.StringComparison.OrdinalIgnoreCase))
                    //{
                    //    IsVideoPreviewVisible = true;
                    //    SetExeCommand?.Invoke("test.exe | test2.bk2 /J /I2 /P");
                    //}


                    if (Enum.IsDefined(typeof(EConvertableOutput), PE_SelectedItem.GetExtension()))
                    {
                        PE_MeshPreviewVisible = true;
                        SelectedIndex = 1;

                        LoadModel(PE_SelectedItem.FullName);
                    }

                    if (string.Equals(PE_SelectedItem.GetExtension(), ERedExtension.mesh.ToString(), StringComparison.OrdinalIgnoreCase) ||
                        string.Equals(PE_SelectedItem.GetExtension(), ERedExtension.physicalscene.ToString(), StringComparison.OrdinalIgnoreCase))
                    {
                        PE_MeshPreviewVisible = true;
                        SelectedIndex = 1;
                        using (var meshStream = new FileStream(PE_SelectedItem.FullName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                        {
                            meshStream.Seek(0, SeekOrigin.Begin);
                            string outPath = Path.Combine(ISettingsManager.GetManagerCacheDir(), "Temp_OBJ",Path.GetFileName(PE_SelectedItem.FullName));
                            outPath = Path.ChangeExtension(outPath, ".glb");
                            if (_meshTools.ExportMeshPreviewer(meshStream, new FileInfo(outPath)))
                            {
                                LoadModel(outPath);
                            }
                            meshStream.Dispose();
                            meshStream.Close();
                        }
                    }

                    if (string.Equals(PE_SelectedItem.GetExtension(), ERedExtension.wem.ToString(),
                        System.StringComparison.OrdinalIgnoreCase))
                    {
                        IsAudioPreviewVisible = true;
                        SelectedIndex = 2;

                        PreviewAudioCommand.SafeExecute(PE_SelectedItem.FullName);
                    }

                    // textures
                    if (Enum.TryParse<EUncookExtension>(PE_SelectedItem.GetExtension(),
                            out _))
                    {
                        IsImagePreviewVisible = true;
                        SelectedIndex = 3;

                        var q = await ImageDecoder.RenderToBitmapSource(PE_SelectedItem.FullName);
                        if (q != null)
                        {
                            var g = BitmapFrame.Create(q);
                            LoadImage(g);
                        }
                    }

                    // xbm
                    if (string.Equals(PE_SelectedItem.GetExtension(), ERedExtension.xbm.ToString(),
                            System.StringComparison.OrdinalIgnoreCase))
                    {
                        IsImagePreviewVisible = true;
                        SelectedIndex = 3;

                        // convert xbm to dds stream
                        await using var ddsstream = new MemoryStream();
                        await using var filestream = new FileStream(PE_SelectedItem.FullName,
                            FileMode.Open, FileAccess.Read, FileShare.ReadWrite, 4096, FileOptions.SequentialScan);
                        _modTools.ConvertXbmToDdsStream(filestream, ddsstream, out _);

                        // try loading it in pfim
                        try
                        {
                            var qa = await ImageDecoder.RenderToBitmapSourceDds(ddsstream);
                            if (qa != null)
                            {
                                LoadImage(qa);
                            }
                        }
                        catch (Exception)
                        {
                            throw;
                        }
                    }
                }
            }
            DecideForMeshPreview();
        }

        public void LoadModel(string s) => LoadedModelPath = s;

        public void LoadImage(BitmapSource p0) => LoadedBitmapFrame = p0;

        #endregion commands

        #region methods

        /// <summary>
        /// Resets stuff each time a new item is selected.
        /// </summary>
        public void SetToNullAndResetVisibility()
        {
            // Asset Browser
            AB_SelectedItem = null;
            AB_FileInfoVisible = false;
            AB_MeshPreviewVisible = false;

            // Project Explorer
            PE_SelectedItem = null;
            PE_FileInfoVisible = false;
            PE_MeshPreviewVisible = false;

            IsAudioPreviewVisible = false;

            IsImagePreviewVisible = false;
        }

        /// <summary>
        /// Decides if the Mesh Previewer should be visible or not.
        /// </summary>
        public void DecideForMeshPreview()
        {
            if (AB_MeshPreviewVisible || PE_MeshPreviewVisible)
            { IsMeshPreviewVisible = true; }
            else
            { IsMeshPreviewVisible = false; }
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
