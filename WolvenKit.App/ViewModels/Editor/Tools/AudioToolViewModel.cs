using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Controls;
using Catel;
using Catel.Services;
using NAudio.Wave;
using WolvenKit.Functionality.Services;
using WolvenKit.Common.Services;
using WolvenKit.MVVM.Model.ProjectManagement.Project;
using WolvenKit.Views.Editor.AudioTool;

namespace WolvenKit.ViewModels.Editor
{
    public class AudioToolViewModel : ToolViewModel
    {
        #region Fields

        /// <summary>
        /// Identifies the <see ref="ContentId"/> of this tool window.
        /// </summary>
        public const string ToolContentId = "AudioTool_Tool";

        /// <summary>
        /// Identifies the caption string used for this tool window.
        /// </summary>
        public const string ToolTitle = "Audio Tool";

        private const string wdir = "vgmstream\\AudioWorkingDir\\";

        private readonly ILoggerService _loggerService;
        private readonly IMessageService _messageService;
        private readonly IProjectManager _projectManager;

        public List<TextBlock> AudioFileList { get; set; } = new List<TextBlock>();





        private void NAudioEngine_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            var engine = NAudioSimpleEngine.Instance;
            switch (e.PropertyName)
            {


                case "ChannelPosition":
                    ChannelPosition = TimeSpan.FromSeconds(engine.ChannelPosition);
                    break;

                default:
                    // Do Nothing
                    break;
            }
        }




        public TimeSpan ChannelPosition { get; set; }







        public void AddAudioItem(string path) => TempConvertToWemWav(path);
        public void TempConvertToWemWav(string path)
        {
            //Clean directory
            Directory.CreateDirectory(wdir);

            foreach (var f in Directory.GetFiles(wdir))
            {
                try
                {
                    File.Delete(f);

                }
                catch
                {

                }
            }

            var outf = Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, wdir, Path.GetFileNameWithoutExtension(path) + ".wav");
            var arg = path + " -o " + outf;
            var si = new ProcessStartInfo(
                    "vgmstream\\test.exe",
                    arg
                )
            {
                CreateNoWindow = true,
                WindowStyle = ProcessWindowStyle.Hidden,
                UseShellExecute = false
            };
            var proc = Process.Start(si);
            proc.WaitForExit();

            var lvi = new TextBlock()
            {
                Text = Path.GetFullPath(outf),
                Tag = Path.GetFileName(outf)
            };
            AudioFileList.Add(lvi);
        }
        #endregion Fields

        #region Constructors
        public NAudioSimpleEngine nAudioSimple { get; set; }
        public WaveOut CurrentPlayer { get; set; }
        public AudioToolViewModel(
           IProjectManager projectManager,
           ILoggerService loggerService,
           IMessageService messageService) : base(ToolTitle)
        {
            Argument.IsNotNull(() => projectManager);
            Argument.IsNotNull(() => messageService);
            Argument.IsNotNull(() => loggerService);
            _projectManager = projectManager;
            _loggerService = loggerService;
            _messageService = messageService;
            SetupToolDefaults();






            nAudioSimple = NAudioSimpleEngine.Instance;
            nAudioSimple.PropertyChanged += NAudioEngine_PropertyChanged;

            CurrentPlayer = nAudioSimple.WaveOutDevice;













        }

        #endregion Constructors

        #region Properties

        private EditorProject ActiveMod => _projectManager.ActiveProject as EditorProject;

        #endregion Properties

        #region Methods

        protected override Task CloseAsync() =>
            // TODO: Unsubscribe from events

            base.CloseAsync();

        protected override async Task InitializeAsync() => await base.InitializeAsync();// TODO: Write initialization code here and subscribe to events

        private void SetupToolDefaults() => ContentId = ToolContentId;           // Define a unique contentid for this toolwindow//BitmapImage bi = new BitmapImage();  // Define an icon for this toolwindow//bi.BeginInit();//bi.UriSource = new Uri("pack://application:,,/Resources/Media/Images/property-blue.png");//bi.EndInit();//IconSource = bi;

        #endregion Methods
    }
}
