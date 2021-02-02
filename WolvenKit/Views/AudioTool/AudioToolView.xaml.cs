
using Catel.Windows;
using FmodAudio;

namespace WolvenKit.Views.AudioTool
{
    public partial class AudioToolView
    {
        public AudioToolView() : base(DataWindowMode.Custom)
        {
            InitializeComponent();
            Systemz = Fmod.CreateSystem(); 
            Systemz.Init(2);

            var sound = Systemz.CreateSound("testmp3.mp3", FmodAudio.Mode.CreateStream);

          var  channel = Systemz.PlaySound(sound);
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
    }

}
