
using Catel.IoC;
using Catel.Services;
using WolvenKit.Services;

namespace WolvenKit.Views.SettingsPages.SubPages.Editor
{
    public partial class CompatibilitySubSettingsView
    {
        private readonly ISettingsManager _settingsManager;
        private readonly IOpenFileService _openFileService;
        private readonly ISelectDirectoryService _selectDirectoryService;

        public CompatibilitySubSettingsView()
        {
            InitializeComponent();

            _settingsManager = ServiceLocator.Default.ResolveType<ISettingsManager>();
            _openFileService = ServiceLocator.Default.ResolveType<IOpenFileService>();
            _selectDirectoryService = ServiceLocator.Default.ResolveType<ISelectDirectoryService>();
        }

        private async void CP77ExecutablePathBtn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            var result = await _openFileService.DetermineFileAsync(new DetermineOpenFileContext() {
                Filter = "Exe files|*.exe"
            });
            if (result.Result)
                _settingsManager.CP77ExecutablePath = result.FileName;
        }

        private async void W3ExecutablePathBtn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            var result = await _openFileService.DetermineFileAsync(new DetermineOpenFileContext() {
                Filter = "Exe files|*.exe"
            });
            if (result.Result)
                _settingsManager.W3ExecutablePath = result.FileName;
        }

        private async void WccLitePathBtn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            var result = await _openFileService.DetermineFileAsync(new DetermineOpenFileContext() {
                Filter = "wcc_lite.exe file|wcc_lite.exe"
            });
            if (result.Result)
                _settingsManager.WccLitePath = result.FileName;
        }

        private async void DepotPathBtn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            var result = await _selectDirectoryService.DetermineDirectoryAsync(
                new DetermineDirectoryContext()
            );
            if (result.Result)
                _settingsManager.DepotPath = result.DirectoryName;
        }

        private async void GameModDirBtn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            var result = await _selectDirectoryService.DetermineDirectoryAsync(
                new DetermineDirectoryContext()
            );
            if (result.Result)
                _settingsManager.GameModDir = result.DirectoryName;
        }

        private async void GameDlcDirBtn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            var result = await _selectDirectoryService.DetermineDirectoryAsync(
                new DetermineDirectoryContext()
            );
            if (result.Result)
                _settingsManager.GameDlcDir = result.DirectoryName;
        }
    }
}
