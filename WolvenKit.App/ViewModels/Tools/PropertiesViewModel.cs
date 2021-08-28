using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Threading;
using CP77.CR2W;
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
using WolvenKit.Views.Editor.AudioTool;

namespace WolvenKit.ViewModels.Tools
{
    public class PropertiesViewModel : ToolViewModel
    {
        #region fields

        private readonly ILoggerService _loggerService;
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
            MeshTools meshTools,
            IModTools modTools
        ) : base(ToolTitle)
        {
            _projectManager = projectManager;
            _loggerService = loggerService;
            _meshTools = meshTools;
            _modTools = modTools;

            SetupToolDefaults();

            SetToNullAndResetVisibility();

            nAudioSimple = NAudioSimpleEngine.Instance;
            NAudioSimpleEngine.Instance.PropertyChanged += NAudioEngine_PropertyChanged;

            StopAudioCommand = new RelayCommand(ExecuteStopPlaying, CanStopPlaying);
            PlayAudioCommand = new RelayCommand(ExecuteStartPlaying, CanStartPlaying);
            PauseAudioCommand = new RelayCommand(ExecutePausePlaying, CanPausePlaying);
        }

        

        #region properties


        /// <summary>
        /// Selected Item from Project Explorer If Available.
        /// </summary>
        ///
        [Reactive] public bool canShowPrev { get; set; } = true;

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

        public ICommand PlayAudioCommand { get; private set; }

        public ICommand PauseAudioCommand { get; private set; }

        public ICommand StopAudioCommand { get; private set; }

        public ICommand FileSelectedCommand { get; private set; }

        private bool CanOpenFile(FileModel model) => model != null;

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

            if (canShowPrev)
            {
                PE_SelectedItem = model;
            }
            else
            { return; }
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
            if (!(string.Equals(model.GetExtension(), ERedExtension.mesh.ToString(), StringComparison.OrdinalIgnoreCase) ||
              string.Equals(model.GetExtension(), ERedExtension.wem.ToString(), StringComparison.OrdinalIgnoreCase) ||
              string.Equals(model.GetExtension(), ERedExtension.xbm.ToString(), StringComparison.OrdinalIgnoreCase)
              || Enum.TryParse<EConvertableOutput>(PE_SelectedItem.GetExtension(), out _)
              || Enum.TryParse<EUncookExtension>(PE_SelectedItem.GetExtension(), out _)
            )
        )
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

                        LoadModel(PE_SelectedItem.FullName);
                    }



                    if (string.Equals(PE_SelectedItem.GetExtension(), ERedExtension.mesh.ToString(),
                        System.StringComparison.OrdinalIgnoreCase))
                    {
                        PE_MeshPreviewVisible = true;

                        var q = _meshTools.ExportMeshWithoutRigPreviewer(PE_SelectedItem.FullName, Path.Combine(ISettingsManager.GetManagerCacheDir(), "Temp_OBJ"));
                        if (q.Length > 0)
                        {
                            LoadModel(q);
                        }
                    }

                    if (string.Equals(PE_SelectedItem.GetExtension(), ERedExtension.wem.ToString(),
                        System.StringComparison.OrdinalIgnoreCase))
                    {
                        IsAudioPreviewVisible = true;

                        AddAudioItem(PE_SelectedItem.FullName);
                    }

                    // textures
                    if (Enum.TryParse<EUncookExtension>(PE_SelectedItem.GetExtension(),
                            out _))
                    {
                        IsImagePreviewVisible = true;

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

        private bool CanStopPlaying() => true;

        private void ExecuteStopPlaying()
        {
            mediaPlayer.Stop();
            mediaPlayer.Position = new TimeSpan(0);
        }

        private bool CanStartPlaying() => true;

        private void ExecuteStartPlaying()
        {
            mediaPlayer.Play();
        }

        private bool CanPausePlaying() => true;

        private void ExecutePausePlaying()
        {
            mediaPlayer.Pause();
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

        /// <summary>
        /// add an audio item. currently instantly loads this.
        /// </summary>
        /// <param name="path"></param>
        public void AddAudioItem(string path) => TempConvertToWemWav(path);

        /// <summary>
        /// current track channel position
        /// </summary>
        public TimeSpan ChannelPosition { get; set; }

        /// <summary>
        /// Naudio engine
        /// </summary>
        public NAudioSimpleEngine nAudioSimple { get; set; }

        /// <summary>
        /// current track name.
        /// </summary>
        public string CurrentTrackName { get; set; }

        /// <summary>
        /// convert a file to wav to preview it.
        /// </summary>
        /// <param name="path"></param>
        public void TempConvertToWemWav(string path)
        {
            string ManagerCacheDir = Path.Combine(ISettingsManager.GetTemp_AudioPath());

            //Clean directory
            Directory.CreateDirectory(ManagerCacheDir);

            foreach (var f in Directory.GetFiles(ManagerCacheDir))
            {
                try
                {
                    File.Delete(f);
                }
                catch
                {
                }
            }

            var outf = Path.Combine(ManagerCacheDir, Path.GetFileNameWithoutExtension(path) + ".wav");
            Trace.WriteLine(outf);
            Trace.WriteLine(path);

            var arg = path.ToEscapedPath() + " -o " + outf.ToEscapedPath();
            var p = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "lib", "vgmstream", "test.exe");
            var si = new ProcessStartInfo(
                    p,
                    arg
                )
            {
                CreateNoWindow = true,
                WindowStyle = ProcessWindowStyle.Hidden,
                UseShellExecute = false,
                RedirectStandardError = true,
                RedirectStandardOutput = true,
                Verb = "runas"
            };
            var proc = Process.Start(si);
            proc.WaitForExit();
            Trace.WriteLine(proc.StandardOutput.ReadToEnd());

            mediaPlayer.Open(new Uri(outf));

            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += Timer_Tick;

            timer.Start();

            DispatcherTimer ChannelPositionTimer = new DispatcherTimer
            {
                Interval = TimeSpan.FromMilliseconds(1)
            };
            ChannelPositionTimer.Tick += ChannelPositionTimer_Tick;
            ;

            ChannelPositionTimer.Start();

            ChannelLength =
                mediaPlayer.Position.TotalMinutes.ToString() + " : " +
                mediaPlayer.Position.TotalSeconds.ToString() + " : " +
                mediaPlayer.Position.TotalMilliseconds.ToString();
            NAudioSimpleEngine.Instance.OpenFile(outf);
            CurrentTrackName = Path.GetFileNameWithoutExtension(outf);

            //AudioFileList.Add(lvi);
        }

        private void ChannelPositionTimer_Tick(object sender, EventArgs e)
        {
            NAudioSimpleEngine.Instance.ChannelPosition = mediaPlayer.Position.TotalSeconds;
        }

        public string AudioPositionText { get; set; }
        public string ChannelLength { get; set; }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (mediaPlayer.Source != null)
            {
                ChannelPosition = mediaPlayer.Position;
            }
            else
            {
                AudioPositionText = "No file selected...";
            }
        }

        private MediaPlayer mediaPlayer = new MediaPlayer();

        /// <summary>
        /// property changed for naudio
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NAudioEngine_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            switch (e.PropertyName)
            {
                case "ChannelPosition":
                    ChannelPosition = TimeSpan.FromSeconds(NAudioSimpleEngine.Instance.ChannelPosition);
                    break;

                default:
                    // Do Nothing
                    break;
            }
        }

        #endregion AudioPreview
    }
}
