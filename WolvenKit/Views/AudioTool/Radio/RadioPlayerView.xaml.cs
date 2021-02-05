
using FmodAudio;
using WolvenKit.ViewModels.AudioTool.Radio;

namespace WolvenKit.Views.AudioTool.Radio
{
    public partial class RadioPlayerView
    {
        public static Channel RadioChannel;
        protected FmodSystem Systemz;

        public RadioPlayerView()
        {
            InitializeComponent(); 
            Systemz = Fmod.CreateSystem();
            Systemz.Init(1);
            


        }

        private void PauseButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            RadioChannel.Paused = true;

        }

        private void PlayButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {

            RadioChannel.Paused = false;

        }

        private void StopButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            RadioChannel.Paused = true;
            RadioChannel.SetPosition(TimeUnit.MS, 0);
        }

        public void LoadRadio(string path)
        {
          
                Sound sound = Systemz.CreateSound("http://hestia2.cdnstream.com/1258_128", FmodAudio.Mode.CreateStream);
                RadioChannel = Systemz.PlaySound(sound);

         
    
        }

     

        private void OpenFile()
        {
            Microsoft.Win32.OpenFileDialog openDialog = new Microsoft.Win32.OpenFileDialog();
            if (openDialog.ShowDialog() == true)
            {
           
                LoadRadio(openDialog.FileName);
            }
        }

        private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            OpenFile();
        }
    }
}
