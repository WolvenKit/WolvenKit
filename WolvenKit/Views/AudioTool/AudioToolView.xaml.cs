
using Catel.Windows;
using FmodAudio;
using System;
using System.Windows;
using WolvenKit.ViewModels.AudioTool;

namespace WolvenKit.Views.AudioTool
{
    public partial class AudioToolView
    {

        public Channel channel;
        public AudioToolView() : base(DataWindowMode.Custom)
        {
            InitializeComponent();
            Systemz = Fmod.CreateSystem(); 
            Systemz.Init(2);


            Sound sound = Systemz.CreateSound("C:\\Users\\hamba\\Music\\dancetillyourdead.mp3", FmodAudio.Mode.CreateStream);


            channel = Systemz.PlaySound(sound);


            TimeSpan.FromSeconds(sound.GetLength(TimeUnit.MS) * 1000);


            ResourceDictionary themeResources = Application.LoadComponent(new Uri("Resources/Styles/ExpressionDark.xaml", UriKind.Relative)) as ResourceDictionary;
            Resources.MergedDictionaries.Add(themeResources);
            //clockDisplay.SetCurrentValue(WPFSoundVisualizationLib.DigitalClock.TimeProperty, TimeSpan.FromMilliseconds(channel.CurrentSound.GetLength(TimeUnit.MS)));
            this.DataContext = new AudioToolViewModel(channel);

        }


        public delegate void MyPersonalizedUCEventHandler(bool sampleParam);

        public event MyPersonalizedUCEventHandler MyEvent;

        public void RaiseMyEvent()
        {
            // Your logic
            if (MyEvent != null)
            {
                MyEvent(false);
            }
        }

        protected FmodSystem Systemz;


        private void DraggableTitleBar_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown(e);

            // Begin dragging the window
            this.DragMove();
        }

        private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_1(object sender, System.Windows.RoutedEventArgs e)
        {
            SetCurrentValue(WindowStateProperty, System.Windows.WindowState.Minimized);
        }






        private void SetPlayerTimeToDigitalClock()
        {
            clockDisplay.SetCurrentValue(WPFSoundVisualizationLib.DigitalClock.TimeProperty, TimeSpan.FromMilliseconds(channel.GetPosition(TimeUnit.MS)));

        }
        private void SetTrackLengthToDigitalClock()
        {

        }


        private void PauseButton_Click(object sender, RoutedEventArgs e)
        {
            channel.Paused = true;
        }

        private void PlayButton_Click(object sender, RoutedEventArgs e)
        {
            channel.Paused = false;
        }

        private void StopButton_Click(object sender, RoutedEventArgs e)
        {
            channel.Paused = true;
            channel.SetPosition(TimeUnit.MS, 0);
        }
    }

}
