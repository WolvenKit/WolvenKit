
using Catel;
using Catel.IoC;
using Catel.Services;
using System.Threading.Tasks;
using WolvenKit.Services;

namespace WolvenKit.Views.SettingsPages.SubPages.Editor
{
    public partial class CompatibilitySubSettingsView
    {
        private ISettingsManager _settingsManager;

        public CompatibilitySubSettingsView()
        {
            InitializeComponent();

            _settingsManager = ServiceLocator.Default.ResolveType<ISettingsManager>();
        }

        private async Task<(bool Result, string FileName)> openFile(string fileType = "Exe files|*.exe")
        {
            var dependencyResolver = ServiceLocator.Default.GetDependencyResolver();
            var openFileService = dependencyResolver.Resolve<IOpenFileService>();
            var result = await openFileService.DetermineFileAsync(
                new DetermineOpenFileContext() {
                    Filter = fileType
                }
            );
            return (result.Result, result.FileName);
        }

        private async Task<(bool Result, string DirectoryName)> openDir()
        {
            var dependencyResolver = ServiceLocator.Default.GetDependencyResolver();
            var selectDirectoryService = dependencyResolver.Resolve<ISelectDirectoryService>();
            var result = await selectDirectoryService.DetermineDirectoryAsync(
                new DetermineDirectoryContext()
            );
            return (result.Result, result.DirectoryName);
        }

        private async void ExecutablePathBtn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            var result = await openFile();
            if (result.Result)
                _settingsManager.ExecutablePath = result.FileName;
        }

        private async void WccLitePathBtn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            var result = await openFile("wcc_lite.exe file|wcc_lite.exe");
            if (result.Result)
                _settingsManager.WccLitePath = result.FileName;
        }

        private async void DepotPathBtn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            var result = await openDir();
            if (result.Result)
                _settingsManager.DepotPath = result.DirectoryName;
        }

        private async void GameModDirBtn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            var result = await openDir();
            if (result.Result)
                _settingsManager.GameModDir = result.DirectoryName;
        }

        private async void GameDlcDirBtn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            var result = await openDir();
            if (result.Result)
                _settingsManager.GameDlcDir = result.DirectoryName;
        }
    }
}
