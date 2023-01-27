using System.IO;
using CommunityToolkit.Mvvm.ComponentModel;
using WolvenKit.Common.Interfaces;
using WolvenKit.Common.Model.Arguments;

namespace WolvenKit.ViewModels.Tools
{
    /// <summary>
    /// ImportExportItem ViewModel
    /// </summary>
    public abstract partial class ImportExportItemViewModel : ObservableObject, ISelectableViewModel
    {
        protected ImportExportItemViewModel(string baseFile, ImportExportArgs properties)
        {
            BaseFile = baseFile;
            _properties = properties;
        }


        public string BaseFile { get; set; }

        [ObservableProperty] private ImportExportArgs _properties;

        [ObservableProperty] private bool _isChecked;

        public string? ExportTaskIdentifier => Properties.ToString();
        public string Extension => Path.GetExtension(BaseFile).TrimStart('.');
        public string Name => Path.GetFileName(BaseFile);


    }
}
