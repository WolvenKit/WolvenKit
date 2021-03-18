using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Catel.IoC;
using WolvenKit.Functionality.WKitGlobal.Helpers;
using WolvenKit.ViewModels.Editor;

namespace WolvenKit.Views.Editor.AudioTool
{
    public partial class AudioToolView
    {

        public AudioToolView()
        {
            InitializeComponent();
            var themeResources = Application.LoadComponent(new Uri("Resources/Styles/ExpressionDark.xaml", UriKind.Relative)) as ResourceDictionary;
            Resources.MergedDictionaries.Add(themeResources);
            var x = ServiceLocator.Default.ResolveType<AudioToolViewModel>();

            spectrumAnalyzer.RegisterSoundPlayer(x.nAudioSimple);
            waveformTimeline.RegisterSoundPlayer(x.nAudioSimple);
        }

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

        private void NAudioEngine_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            var engine = NAudioSimpleEngine.Instance;
            switch (e.PropertyName)
            {


                case "ChannelPosition":
                    clockDisplay.SetCurrentValue(WPFSoundVisualizationLib.DigitalClock.TimeProperty, TimeSpan.FromSeconds(engine.ChannelPosition));
                    break;

                default:
                    // Do Nothing
                    break;
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

    }
}
