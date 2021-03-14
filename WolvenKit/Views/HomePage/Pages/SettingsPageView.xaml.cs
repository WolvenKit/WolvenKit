namespace WolvenKit.Views.HomePage.Pages
{
    public partial class SettingsPageView
    {
        #region Constructors

        public SettingsPageView()
        {
            InitializeComponent();
        }

        #endregion Constructors

        #region Methods

        private void TabControlDemo_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            // I wanted to add logic that the selected tab item moves to be the first in the row but I am not sure it works with the HC tabcontrol. If someone feels liek testing this later go ahead :D
        }

        #endregion Methods
    }
}
