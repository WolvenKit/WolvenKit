using WolvenKit.Views.ViewModels;

namespace WolvenKit.Views.HomePage.Pages
{
    public partial class WelcomePageView
    {
        #region Constructors

        public WelcomePageView()
        {
            InitializeComponent();


        }



        public static RootViewModel zViewModel => App.Current.Resources[nameof(ViewModel)] as RootViewModel;
        #endregion Constructors

        private void Fuckoff_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            MainWindow z;
            z = App.MainX;
            z.Loaded += (snd, eva) => zViewModel.OnApplicationLoaded();
            z.Show();
        }
    }
}
