using System.IO;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using WolvenKit.Common.Interfaces;
using WolvenKit.Common.Model.Arguments;

namespace WolvenKit.ViewModels.Tools
{
    /// <summary>
    /// ImportExportItem ViewModel
    /// </summary>
    public abstract class ImportExportItemViewModel : ReactiveObject, ISelectableViewModel
    {
        protected ImportExportItemViewModel(string baseFile, ImportExportArgs properties)
        {
            BaseFile = baseFile;
            Properties = properties;
        }


        public string BaseFile { get; set; }

        [Reactive] public ImportExportArgs Properties { get; set; }

        [Reactive] public bool IsChecked { get; set; }

        public string? ExportTaskIdentifier => Properties.ToString();
        public string Extension => Path.GetExtension(BaseFile).TrimStart('.');
        public string Name => Path.GetFileName(BaseFile);


    }
}
