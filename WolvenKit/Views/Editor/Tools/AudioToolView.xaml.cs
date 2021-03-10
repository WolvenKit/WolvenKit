using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using Catel.IoC;
using WolvenKit.Functionality.WKitGlobal.Helpers;
using WolvenKit.ViewModels.Editor;

namespace WolvenKit.MVVM.Views.Components.Tools.AudioTool
{
    public partial class AudioToolView
    {
        #region Fields

        private const string wdir = "vgmstream\\AudioWorkingDir\\";

        #endregion Fields

        #region Constructors

        public AudioToolView()
        {
            InitializeComponent();

            Reinit();
        }

        #endregion Constructors

        #region Methods

        public void AddAudioItem(string path) => TempConvertToWemWav(path);


        public void Reinit()
        {
            var themeResources = Application.LoadComponent(new Uri("Resources/Styles/ExpressionDark.xaml", UriKind.Relative)) as ResourceDictionary;
            Resources.MergedDictionaries.Add(themeResources);
            //clockDisplay.SetCurrentValue(WPFSoundVisualizationLib.DigitalClock.TimeProperty, TimeSpan.FromMilliseconds(channel.CurrentSound.GetLength(TimeUnit.MS)));
            // this.DataContext = new AudioToolViewModel();

            var soundEngine = NAudioEngine.Instance;
            soundEngine.PropertyChanged += NAudioEngine_PropertyChanged;

            // UIHelper.Bind(soundEngine, "CanStop", StopButton, Button.IsEnabledProperty);
            // UIHelper.Bind(soundEngine, "CanPlay", PlayButton, Button.IsEnabledProperty);
            // UIHelper.Bind(soundEngine, "CanPause", PauseButton, Button.IsEnabledProperty);

            spectrumAnalyzer.RegisterSoundPlayer(soundEngine);
            waveformTimeline.RegisterSoundPlayer(soundEngine);

            //LoadExpressionDarkTheme();
            ShowPage();
        }

        public void TempConvertToWemWav(string path)
        {
            //Clean directory
            foreach (var f in Directory.GetFiles(wdir))
            {
                File.Delete(f);
            }
            Directory.CreateDirectory(wdir);

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
            ServiceLocator.Default.ResolveType<AudioToolViewModel>().AudioFileList.Add(lvi);
        }

        private void BrowseButton_Click(object sender, RoutedEventArgs e) => OpenFile();

        private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            NAudioEngine.Instance.Dispose();
            if (NAudioEngine.Instance.CanStop)
            {
                NAudioEngine.Instance.Stop();
            }
        }

        private void Button_Click_1(object sender, System.Windows.RoutedEventArgs e)
        {
        }

        private void CloseMenuItem_Click(object sender, RoutedEventArgs e)
        {
        }

        private void DataWindow_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (IsVisible)
            {
                DiscordHelper.SetDiscordRPCStatus("Audio Tool");
            }
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

        private void LoadDarkBlueTheme()
        {
            Resources.MergedDictionaries.Clear();
            var themeResources = Application.LoadComponent(new Uri("DarkBlue.xaml", UriKind.Relative)) as ResourceDictionary;
            Resources.MergedDictionaries.Add(themeResources);
        }

        private void LoadDefaultTheme() => Resources.MergedDictionaries.Clear();

        private void LoadExpressionDarkTheme()
        {
            Resources.MergedDictionaries.Clear();
            var themeResources = Application.LoadComponent(new Uri("ExpressionDark.xaml", UriKind.Relative)) as ResourceDictionary;
            Resources.MergedDictionaries.Add(themeResources);
        }

        private void LoadExpressionLightTheme()
        {
            Resources.MergedDictionaries.Clear();
            var themeResources = Application.LoadComponent(new Uri("ExpressionLight.xaml", UriKind.Relative)) as ResourceDictionary;
            Resources.MergedDictionaries.Add(themeResources);
        }

        private void NextPage(object sender, System.Windows.RoutedEventArgs e)
        {
            StepMain.Next();
            ShowPage();
        }

        private void OpenFile()
        {
            var openDialog = new Microsoft.Win32.OpenFileDialog
            {
                Filter = "(*.mp3)|*.mp3"
            };
            if (openDialog.ShowDialog() == true)
            {
                NAudioEngine.Instance.OpenFile(openDialog.FileName);
                //FileText.SetCurrentValue(TextBox.TextProperty, openDialog.FileName);
                RunnerText.SetCurrentValue(ContentProperty, openDialog.FileName);
            }
        }

        private void OpenFileMenuItem_Click(object sender, RoutedEventArgs e) => OpenFile();

        private void PauseButton_Click(object sender, RoutedEventArgs e)
        {
            if (NAudioEngine.Instance.CanPause)
            {
                NAudioEngine.Instance.Pause();
            }
        }

        private void PlayButton_Click(object sender, RoutedEventArgs e)
        {
            if (NAudioEngine.Instance.CanPlay)
            {
                NAudioEngine.Instance.Play();
            }
        }

        private void PreviousPage(object sender, System.Windows.RoutedEventArgs e)
        {
            StepMain.Prev();
            ShowPage();
        }

        private void ShowPage()
        {
            switch (StepMain.StepIndex)
            {
                case 0:
                    StepOne.SetCurrentValue(VisibilityProperty, Visibility.Visible);
                    StepTwo.SetCurrentValue(VisibilityProperty, Visibility.Hidden);
                    StepThree.SetCurrentValue(VisibilityProperty, Visibility.Hidden);
                    StepFour.SetCurrentValue(VisibilityProperty, Visibility.Hidden);

                    break;

                case 1:
                    StepOne.SetCurrentValue(VisibilityProperty, Visibility.Hidden);
                    StepTwo.SetCurrentValue(VisibilityProperty, Visibility.Visible);
                    StepThree.SetCurrentValue(VisibilityProperty, Visibility.Hidden);
                    StepFour.SetCurrentValue(VisibilityProperty, Visibility.Hidden);
                    break;

                case 2:
                    StepOne.SetCurrentValue(VisibilityProperty, Visibility.Hidden);
                    StepTwo.SetCurrentValue(VisibilityProperty, Visibility.Hidden);
                    StepThree.SetCurrentValue(VisibilityProperty, Visibility.Visible);
                    StepFour.SetCurrentValue(VisibilityProperty, Visibility.Hidden);
                    break;

                case 3:
                    StepOne.SetCurrentValue(VisibilityProperty, Visibility.Hidden);
                    StepTwo.SetCurrentValue(VisibilityProperty, Visibility.Hidden);
                    StepThree.SetCurrentValue(VisibilityProperty, Visibility.Hidden);
                    StepFour.SetCurrentValue(VisibilityProperty, Visibility.Visible);
                    break;
            }
        }

        #endregion Methods

        #region NAudio Engine Events

        private void NAudioEngine_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            var engine = NAudioEngine.Instance;
            switch (e.PropertyName)
            {
                case "FileTag":
                    if (engine.FileTag != null)
                    {
                        var tag = engine.FileTag.Tag;
                        if (tag.Pictures.Length > 0)
                        {
                            using var albumArtworkMemStream = new MemoryStream(tag.Pictures[0].Data.Data);
                            try
                            {
                                var albumImage = new BitmapImage();
                                albumImage.BeginInit();
                                albumImage.CacheOption = BitmapCacheOption.OnLoad;
                                albumImage.StreamSource = albumArtworkMemStream;
                                albumImage.EndInit();
                            }
                            catch (NotSupportedException)
                            {
                                // System.NotSupportedException:
                                // No imaging component suitable to complete this operation was found.
                            }
                            albumArtworkMemStream.Close();
                        }
                        else
                        {
                        }
                    }
                    else
                    {
                    }
                    break;

                case "ChannelPosition":
                    clockDisplay.SetCurrentValue(WPFSoundVisualizationLib.DigitalClock.TimeProperty, TimeSpan.FromSeconds(engine.ChannelPosition));
                    break;

                default:
                    // Do Nothing
                    break;
            }
        }

        #endregion NAudio Engine Events

        private void StopButton_Click(object sender, RoutedEventArgs e)
        {
            if (NAudioEngine.Instance.CanStop)
            {
                NAudioEngine.Instance.Stop();
            }
        }

        //  protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
        //    {
        //       NAudioEngine.Instance.Dispose();
        //   }

        // Begin dragging the window
        private void PlayListView_OnPreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            var item = (sender as ListView).SelectedItem;
            if (item != null)
            {
                if (NAudioEngine.Instance.CanStop)
                {
                    NAudioEngine.Instance.Stop();
                }

                var path = (item as TextBlock).Text;
                RunnerText.SetCurrentValue(ContentProperty, path);
                NAudioEngine.Instance.OpenFile(path);
                //FileText.SetCurrentValue(TextBox.TextProperty, openDialog.FileName);
                NAudioEngine.Instance.Play(); //TODO: Doesn't play it
            }
        }
    }
}
