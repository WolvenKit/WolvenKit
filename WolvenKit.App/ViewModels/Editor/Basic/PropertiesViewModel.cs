using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Windows.Controls;
using Catel;
using Catel.Services;
using NAudio.Wave;
using WolvenKit.Common.Services;
using WolvenKit.Functionality.Services;
using WolvenKit.Models;
using WolvenKit.Views.Editor.AudioTool;

namespace WolvenKit.ViewModels.Editor
{
    public class PropertiesViewModel : ToolViewModel
    {

        /// <summary>
        /// Private Logger Service
        /// </summary>
        private readonly ILoggerService _loggerService;

        /// <summary>
        /// Private Message Service
        /// </summary>
        private readonly IMessageService _messageService;

        /// <summary>
        /// Private ProjectManager
        /// </summary>
        private readonly IProjectManager _projectManager;

        /// <summary>
        /// Constructor PropertiesViewModel
        /// </summary>
        /// <param name="projectManager"></param>
        /// <param name="loggerService"></param>
        /// <param name="messageService"></param>
        public PropertiesViewModel(
            IProjectManager projectManager,
            ILoggerService loggerService,
            IMessageService messageService
        ) : base(ToolTitle)
        {
            Argument.IsNotNull(() => projectManager);
            Argument.IsNotNull(() => messageService);
            Argument.IsNotNull(() => loggerService);

            _projectManager = projectManager;
            _loggerService = loggerService;
            _messageService = messageService;

            SetupCommands();
            SetupToolDefaults();

            SetToNullAndResetVisibility();


            nAudioSimple = NAudioSimpleEngine.Instance;
            NAudioSimpleEngine.Instance.PropertyChanged += NAudioEngine_PropertyChanged;
        }


        /// <summary>
        /// Initialize commands for this window.
        /// </summary>
        private void SetupCommands()
        {
            // Unused for Properties so far.
        }

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

        }

        /// <summary>
        /// Selected Item from Project Explorer If Available.
        /// </summary>
        public FileModel PE_SelectedItem { get; set; }

        /// <summary>
        /// Selected Item from Asset Browser If Available.
        /// </summary>
        public Common.Model.AssetBrowserData AB_SelectedItem { get; set; }

        /// <summary>
        /// Decides if Asset browser Selected File info should be visible.
        /// </summary>
        public bool AB_FileInfoVisible { get; set; }

        /// <summary>
        /// Decides if Project Explorer Selected file info should be Visible.
        /// </summary>
        public bool PE_FileInfoVisible { get; set; }

        /// <summary>
        /// Decides if Asset browser Mesh preview should be visible.
        /// </summary>
        public bool AB_MeshPreviewVisible { get; set; }

        /// <summary>
        /// Decides if Project Explorer Mesh preview should be visible.
        /// </summary>
        public bool PE_MeshPreviewVisible { get; set; }

        /// <summary>
        /// Decides if the mesh previewer Tab should be visible or not.
        /// </summary>
        public bool IsMeshPreviewVisible { get; set; }


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



        #region ToolViewModel
        /// <summary>
        /// Initialize Syncfusion specific defaults that are specific to this tool window.
        /// </summary>
        private void SetupToolDefaults() => ContentId = ToolContentId;

        /// <summary>
        /// Identifies the <see ref="ContentId"/> of this tool window.
        /// </summary>
        public const string ToolContentId = "Properties_Tool";

        /// <summary>
        /// Identifies the caption string used for this tool window.
        /// </summary>
        public const string ToolTitle = "Properties";
        #endregion


        #region AudioPreview

        /// <summary>
        /// Working directory for audio preview.
        /// </summary>
        private const string wdir = "vgmstream\\AudioWorkingDir\\";

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
        public string CurrentTrackName { get;set; }


        /// <summary>
        /// convert a file to wav to preview it.
        /// </summary>
        /// <param name="path"></param>
        public void TempConvertToWemWav(string path)
        {
            string WKitAppData = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "REDModding", "WolvenKit");

            string ManagerCacheDir = Path.Combine(WKitAppData, "Temp_Audio");

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

            var arg = path + " -o " + outf;
            var si = new ProcessStartInfo(
                    AppDomain.CurrentDomain.BaseDirectory + "\\vgmstream\\test.exe",
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


            var lvi = new TextBlock()
            {
                Text = Path.GetFullPath(outf),
                Tag = Path.GetFileName(outf)
            };

            NAudioSimpleEngine.Instance.OpenFile(outf);
          CurrentTrackName   =Path.GetFileNameWithoutExtension(outf);

            //AudioFileList.Add(lvi);
        }

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
        #endregion

    }
}
