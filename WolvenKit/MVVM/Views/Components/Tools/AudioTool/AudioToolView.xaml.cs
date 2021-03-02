
using Catel.Windows;
using Sample_NAudio;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media.Imaging;
using WolvenKit.ViewModels.AudioTool;
using WPFSoundVisualizationLib;

namespace WolvenKit.Views.AudioTool
{
    public partial class AudioToolView
    {

        public AudioToolView()
        {
            InitializeComponent();

            Reinit();

      
        }

        public void Reinit()
        {



            ResourceDictionary themeResources = Application.LoadComponent(new Uri("Resources/Styles/ExpressionDark.xaml", UriKind.Relative)) as ResourceDictionary;
            Resources.MergedDictionaries.Add(themeResources);
            //clockDisplay.SetCurrentValue(WPFSoundVisualizationLib.DigitalClock.TimeProperty, TimeSpan.FromMilliseconds(channel.CurrentSound.GetLength(TimeUnit.MS)));
            // this.DataContext = new AudioToolViewModel();


            NAudioEngine soundEngine = NAudioEngine.Instance;
            soundEngine.PropertyChanged += NAudioEngine_PropertyChanged;

            // UIHelper.Bind(soundEngine, "CanStop", StopButton, Button.IsEnabledProperty);
            // UIHelper.Bind(soundEngine, "CanPlay", PlayButton, Button.IsEnabledProperty);
            // UIHelper.Bind(soundEngine, "CanPause", PauseButton, Button.IsEnabledProperty);


            spectrumAnalyzer.RegisterSoundPlayer(soundEngine);
            waveformTimeline.RegisterSoundPlayer(soundEngine);

            //LoadExpressionDarkTheme();  
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

        private void NextPage(object sender, System.Windows.RoutedEventArgs e)
        {
            StepMain.Next();
            ShowPage();
        }

        public void AddAudioItem(string path)
        {
            TempConvertToWemWav( path);
        }

        const string wdir = "vgmstream\\AudioWorkingDir\\";

        public void TempConvertToWemWav(string path)
        {
            Directory.CreateDirectory(wdir);

        
                string outf = Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, Path.GetFileNameWithoutExtension(path) + ".wav");
                string arg = path + " -o " + outf;
                var si = new ProcessStartInfo(
                        "vgmstream\\test.exe",
                        arg
                    );
                si.CreateNoWindow = true;
                si.WindowStyle = ProcessWindowStyle.Hidden;
                si.UseShellExecute = false;
                var proc = Process.Start(si);
                proc.WaitForExit();
          

            foreach (var f in Directory.GetFiles(wdir))
            {
                var lvi = new TextBlock()
                {
                    Text = Path.GetFullPath(f),
                    Tag = Path.GetFileName(f)
                };
                PlayListView.Items.Add(lvi);
                PlayListView.Items.Add(lvi);
                PlayListView.Items.Add(lvi);
                PlayListView.Items.Add(lvi);
                PlayListView.Items.Add(lvi);

            }

            Trace.WriteLine("WeDiDThis");

        }














        private void PreviousPage(object sender, System.Windows.RoutedEventArgs e)
        {
            StepMain.Prev();
            ShowPage();
        }

        #region NAudio Engine Events
        private void NAudioEngine_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            NAudioEngine engine = NAudioEngine.Instance;
            switch (e.PropertyName)
            {
                case "FileTag":
                    if (engine.FileTag != null)
                    {
                        TagLib.Tag tag = engine.FileTag.Tag;
                        if (tag.Pictures.Length > 0)
                        {
                            using (MemoryStream albumArtworkMemStream = new MemoryStream(tag.Pictures[0].Data.Data))
                            {
                                try
                                {
                                    BitmapImage albumImage = new BitmapImage();
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
        #endregion

        private void PlayButton_Click(object sender, RoutedEventArgs e)
        {
            if (NAudioEngine.Instance.CanPlay)
                NAudioEngine.Instance.Play();
        }

        private void PauseButton_Click(object sender, RoutedEventArgs e)
        {
            if (NAudioEngine.Instance.CanPause)
                NAudioEngine.Instance.Pause();
        }

        private void StopButton_Click(object sender, RoutedEventArgs e)
        {
            if (NAudioEngine.Instance.CanStop)
                NAudioEngine.Instance.Stop();
        }

        private void BrowseButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFile();
        }

        private void LoadDefaultTheme()
        {


            Resources.MergedDictionaries.Clear();
        }

        private void LoadDarkBlueTheme()
        {
      

            Resources.MergedDictionaries.Clear();
            ResourceDictionary themeResources = Application.LoadComponent(new Uri("DarkBlue.xaml", UriKind.Relative)) as ResourceDictionary;
            Resources.MergedDictionaries.Add(themeResources);
        }

        private void LoadExpressionDarkTheme()
        {
     

            Resources.MergedDictionaries.Clear();
            ResourceDictionary themeResources = Application.LoadComponent(new Uri("ExpressionDark.xaml", UriKind.Relative)) as ResourceDictionary;
            Resources.MergedDictionaries.Add(themeResources);
        }

        private void LoadExpressionLightTheme()
        {
          

            Resources.MergedDictionaries.Clear();
            ResourceDictionary themeResources = Application.LoadComponent(new Uri("ExpressionLight.xaml", UriKind.Relative)) as ResourceDictionary;
            Resources.MergedDictionaries.Add(themeResources);
        }

        private void DefaultThemeMenuItem_Checked(object sender, RoutedEventArgs e)
        {
            //LoadDefaultTheme();
        }

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
            Microsoft.Win32.OpenFileDialog openDialog = new Microsoft.Win32.OpenFileDialog();
            openDialog.Filter = "(*.mp3)|*.mp3";
            if (openDialog.ShowDialog() == true)
            {
                NAudioEngine.Instance.OpenFile(openDialog.FileName);
                //FileText.SetCurrentValue(TextBox.TextProperty, openDialog.FileName);
                RunnerText.SetCurrentValue(ContentProperty, openDialog.FileName);
            }
        }

        private void OpenFileMenuItem_Click(object sender, RoutedEventArgs e)
        {
            OpenFile();
        }

        private void CloseMenuItem_Click(object sender, RoutedEventArgs e)
        {
        }

      //  protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
    //    {
     //       NAudioEngine.Instance.Dispose();
     //   }




        private void DraggableTitleBar_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown(e);

            // Begin dragging the window
        }

        private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            NAudioEngine.Instance.Dispose();
            if (NAudioEngine.Instance.CanStop)
                NAudioEngine.Instance.Stop();
        }

        private void Button_Click_1(object sender, System.Windows.RoutedEventArgs e)
        {
        }



        private void DataWindow_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (this.IsVisible )
            {
                WKitGlobal.DiscordHelper.SetDiscordRPCStatus("Audio Tool");
            }
        }
    }

}
