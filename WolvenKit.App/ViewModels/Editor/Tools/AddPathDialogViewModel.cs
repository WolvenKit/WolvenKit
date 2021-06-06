using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Catel.Data;
using Catel.IoC;
using Catel.MVVM;
using Catel.Services;
using WolvenKit.Functionality.Commands;
using WolvenKit.Functionality.Services;

namespace WolvenKit.ViewModels.Editor.Tools
{
    public class AddPathDialogViewModel : ViewModelBase
    {
        private readonly IOpenFileService _openFileService;
        private readonly ISelectDirectoryService _selectDirectoryService;
        private readonly ISettingsManager _settingsManager;

        #region constructors
        public AddPathDialogViewModel()
        {
            OpenDialogCommand = new RelayCommand(OpenFileDialog, CanOpenFileDialog);

            _settingsManager = ServiceLocator.Default.ResolveType<ISettingsManager>();
            _openFileService = ServiceLocator.Default.ResolveType<IOpenFileService>();
            _selectDirectoryService = ServiceLocator.Default.ResolveType<ISelectDirectoryService>();

        }
        #endregion

        #region properties
        //public static readonly PropertyData PathProperty = RegisterProperty("Path", typeof(string));

        //public string Path
        //{
        //    get { return GetValue<string>(PathProperty); }
        //    set { SetValue(PathProperty, value); }
        //}

        public string Path { get; set; }

        public ICommand OpenDialogCommand { get; private set; }

        #endregion

        #region methods

        private bool CanOpenFileDialog() => true;

        private async void OpenFileDialog()
        {
            var result = await _openFileService.DetermineFileAsync(new DetermineOpenFileContext()
            {
                Filter = "Exe files|*.exe"
            });
            if (result.Result)
            {
                Path = result.FileName;
                // _settingsManager.Save(); // Save Path here ?
            }
        }
        #endregion
    }
}
