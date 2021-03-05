using WolvenKit.Functionality.WKitGlobal.Helpers;

namespace WolvenKit.MVVM.Views.Components.Tools.AudioTool.Radio
{
    public partial class RadioPlayerView
    {
        #region Constructors

        public RadioPlayerView()
        {
            InitializeComponent();
        }

        #endregion Constructors

        #region Methods

        public void LoadRadio(string path)
        {
        }

        private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {
        }

        private void OpenFile()
        {
        }

        private void PauseButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
        }

        private void PlayButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
        }

        private void StopButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
        }

        private void UserControl_IsVisibleChanged(object sender, System.Windows.DependencyPropertyChangedEventArgs e)
        {
            if (IsVisible)
            {
                DiscordHelper.SetDiscordRPCStatus("Radio Player");
            }
        }

        #endregion Methods
    }
}
