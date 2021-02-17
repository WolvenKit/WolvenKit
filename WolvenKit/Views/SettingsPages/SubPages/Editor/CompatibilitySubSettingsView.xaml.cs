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

        private HandyControl.Data.OperationResult<bool> VerifyFolder(string str)
        {
            return System.IO.Directory.Exists(str)
                ? HandyControl.Data.OperationResult.Success()
                : HandyControl.Data.OperationResult.Failed();
        }

        private HandyControl.Data.OperationResult<bool> VerifyFile(string str)
        {
            return System.IO.File.Exists(str)
                ? HandyControl.Data.OperationResult.Success()
                : HandyControl.Data.OperationResult.Failed();
        }

        private void TextBox_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            if (cp77Txtbx.VerifyData())
                _settingsManager.CP77ExecutablePath = cp77Txtbx.Text;
            if (w3Txtbx.VerifyData())
                _settingsManager.W3ExecutablePath = w3Txtbx.Text;
            if (wccliteTxtbx.VerifyData())
                _settingsManager.WccLitePath = wccliteTxtbx.Text;
            if (depotTxtbx.VerifyData())
                _settingsManager.DepotPath = depotTxtbx.Text;
            _settingsManager.Save();
        }
    }
}
