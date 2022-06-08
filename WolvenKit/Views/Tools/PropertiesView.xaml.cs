using System;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Threading;
using ReactiveUI;
using Splat;
using Syncfusion.Windows.PropertyGrid;
using WolvenKit.App.Services;
using WolvenKit.App.ViewModels.Tools;
using WolvenKit.Common.Extensions;
using WolvenKit.Views.Editor.AudioTool;
using WPFSoundVisualizationLib;

namespace WolvenKit.Views.Tools
{
    /// <summary>
    /// Interaction logic for PropertiesView.xaml
    /// </summary>
    public partial class PropertiesView : ReactiveUserControl<PropertiesViewModel>
    {
        public string _fileName;

        private readonly MediaPlayer mediaPlayer = new();

        public PropertiesView()
        {
            InitializeComponent();

            ViewModel = Locator.Current.GetService<PropertiesViewModel>();
            DataContext = ViewModel;

            //var themeResources = Application.LoadComponent(new Uri("Resources/Styles/ExpressionDark.xaml", UriKind.Relative)) as ResourceDictionary;
            //Resources.MergedDictionaries.Add(themeResources);

            spectrumAnalyzer.RegisterSoundPlayer(NAudioSimpleEngine.Instance);
            waveformTimeline.RegisterSoundPlayer(NAudioSimpleEngine.Instance);

            nAudioSimple = NAudioSimpleEngine.Instance;
            NAudioSimpleEngine.Instance.PropertyChanged += NAudioEngine_PropertyChanged;

            //appControl.ExeName = "binkpl64.exe";
            //appControl.Args = "test2.bk2 /J /I2 /P";
            //this.Unloaded += new RoutedEventHandler((s, e) => { appControl.Dispose(); });


            ViewModel.ModelGroup.CollectionChanged += (object sender, NotifyCollectionChangedEventArgs e) =>
            {
                if (e.Action != NotifyCollectionChangedAction.Reset)
                {
                    return;
                }

                if (ViewModel.ModelGroup.Count == 0)
                {
                    return;
                }

                if (!hxViewport.IsInitialized)
                {
                    return;
                }
            };

            this.WhenActivated(disposables =>
                //ViewModel.WhenAnyValue(x => x.LoadedBitmapFrame).Subscribe(source =>
                //{
                //    if (source is { } frame)
                //    {
                //        LoadImage(frame);
                //    }
                //});

                ViewModel.PreviewAudioCommand.Subscribe(path => TempConvertToWemWav(path)));
        }

        #region properties

        public NAudioSimpleEngine nAudioSimple { get; set; }

        //public TimeSpan ChannelPosition { get; set; }

        //public string AudioPositionText { get; set; }

        //public string CurrentTrackName { get; set; }

        //public string ChannelLength { get; set; }

        #endregion

        private void PropertyGrid_OnAutoGeneratingPropertyGridItem(object sender, AutoGeneratingPropertyGridItemEventArgs e)
        {
            switch (e.DisplayName)
            {
                case nameof(ReactiveObject.Changed):
                case nameof(ReactiveObject.Changing):
                case nameof(ReactiveObject.ThrownExceptions):
                    e.Cancel = true;
                    break;
            }
            e.ReadOnly = true;
        }

        private Stream StreamFromBitmapSource(BitmapSource writeBmp)
        {
            Stream bmp = new MemoryStream();

            BitmapEncoder enc = new BmpBitmapEncoder();
            enc.Frames.Add(BitmapFrame.Create(writeBmp));
            enc.Save(bmp);

            return bmp;
        }

        public void LoadButton_OnClick(object sender, RoutedEventArgs e)
        {
            var openFileDialog = new Microsoft.Win32.OpenFileDialog
            {
                InitialDirectory = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources"),

                Filter = "3D model file (*.*)|*.*",
                Title = "Open 3D model file file"
            };
        }

        #region AudioPreview

        private void BrowseButton_Click(object sender, RoutedEventArgs e) => OpenFile();

        private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            NAudioSimpleEngine.Instance.Dispose();
            if (NAudioSimpleEngine.Instance.CanStop)
            {
                NAudioSimpleEngine.Instance.Stop();
            }
        }

        private void Button_Click_1(object sender, System.Windows.RoutedEventArgs e)
        {
        }

        private void CloseMenuItem_Click(object sender, RoutedEventArgs e)
        {
        }

        private void DefaultThemeMenuItem_Checked(object sender, RoutedEventArgs e)
        {
            //LoadDefaultTheme();
        }

        private void DraggableTitleBar_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e) => base.OnMouseLeftButtonDown(e);

        private void ExpressionDarkMenuItem_Checked(object sender, RoutedEventArgs e)
        {
            //LoadExpressionDarkTheme();
        }

        private void ExpressionLightMenuItem_Checked(object sender, RoutedEventArgs e)
        {
            //  LoadExpressionLightTheme();
        }

        private void OpenFile()
        {
            var openDialog = new Microsoft.Win32.OpenFileDialog
            {
                Filter = "(*.mp3)|*.mp3"
            };
            if (openDialog.ShowDialog() == true)
            {
                NAudioSimpleEngine.Instance.OpenFile(openDialog.FileName);
                //FileText.SetCurrentValue(TextBox.TextProperty, openDialog.FileName);
                RunnerText.SetCurrentValue(ContentProperty, openDialog.FileName);
            }
        }

        private void OpenFileMenuItem_Click(object sender, RoutedEventArgs e) => OpenFile();

        private void PauseButton_Click(object sender, RoutedEventArgs e)
        {
            if (NAudioSimpleEngine.Instance.CanPause)
            {
                NAudioSimpleEngine.Instance.Pause();
            }
        }

        private void PlayButton_Click(object sender, RoutedEventArgs e)
        {
            if (NAudioSimpleEngine.Instance.CanPlay)
            {
                NAudioSimpleEngine.Instance.Play();
            }
        }

        // Begin dragging the window
        private void PlayListView_OnPreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            var item = (sender as ListBox).SelectedItem;
            if (item != null)
            {
                if (NAudioSimpleEngine.Instance.CanStop)
                {
                    NAudioSimpleEngine.Instance.Stop();
                }

                var path = (item as TextBlock).Text;
                NAudioSimpleEngine.Instance.OpenFile(path);
                //FileText.SetCurrentValue(TextBox.TextProperty, openDialog.FileName);
                NAudioSimpleEngine.Instance.Play();
            }
        }

        private void StopButton_Click(object sender, RoutedEventArgs e)
        {
            if (NAudioSimpleEngine.Instance.CanStop)
            {
                NAudioSimpleEngine.Instance.Stop();
            }
        }

        /// <summary>
        /// convert a file to wav to preview it.
        /// </summary>
        /// <param name="path"></param>
        public void TempConvertToWemWav(string path)
        {
            var ManagerCacheDir = Path.Combine(ISettingsManager.GetTemp_AudioPath());

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

            var timer = new DispatcherTimer
            {
                Interval = TimeSpan.FromSeconds(1)
            };
            timer.Tick += Timer_Tick;

            timer.Start();

            var ChannelPositionTimer = new DispatcherTimer
            {
                Interval = TimeSpan.FromMilliseconds(1)
            };
            ChannelPositionTimer.Tick += ChannelPositionTimer_Tick;
            ;

            ChannelPositionTimer.Start();

            //ChannelLength = $"{mediaPlayer.Position.TotalMinutes} : {mediaPlayer.Position.TotalSeconds} : {mediaPlayer.Position.TotalMilliseconds}";
            NAudioSimpleEngine.Instance.OpenFile(outf);
            RunnerText.SetCurrentValue(ContentProperty, Path.GetFileNameWithoutExtension(outf));


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
                    clockDisplay.SetCurrentValue(DigitalClock.TimeProperty, TimeSpan.FromSeconds(NAudioSimpleEngine.Instance.ChannelPosition));
                    break;

                default:
                    // Do Nothing
                    break;
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (mediaPlayer.Source != null)
            {
                clockDisplay.SetCurrentValue(DigitalClock.TimeProperty, mediaPlayer.Position);
            }
            else
            {
                //AudioPositionText = "No file selected...";
            }
        }

        private void ChannelPositionTimer_Tick(object sender, EventArgs e) => NAudioSimpleEngine.Instance.ChannelPosition = mediaPlayer.Position.TotalSeconds;

        private void PlayButton_Click_1(object sender, RoutedEventArgs e)
        {
            //Call Stop Playing if the media player is at the end of the track
            if (mediaPlayer.Position >= mediaPlayer.NaturalDuration.TimeSpan)
            {
                mediaPlayer.Stop();
                mediaPlayer.Position = new TimeSpan(0);
            }

            mediaPlayer.Play();
        }

        private void PauseButton_Click_1(object sender, RoutedEventArgs e) => mediaPlayer.Pause();

        private void StopButton_Click_1(object sender, RoutedEventArgs e)
        {
            mediaPlayer.Stop();
            mediaPlayer.Position = new TimeSpan(0);
        }

        #endregion AudioPreview

        private void CopyMenuItem_Click(object sender, RoutedEventArgs e) => Clipboard.SetText((DataContext as PropertiesViewModel).PE_SelectedItem.FullName);
    }
}
