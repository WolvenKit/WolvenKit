using System.IO;
using CommunityToolkit.Mvvm.ComponentModel;
using WolvenKit.Common.Interfaces;
using WolvenKit.Common.Model.Arguments;
using System.Text.RegularExpressions;

namespace WolvenKit.App.ViewModels.Tools;

/// <summary>
/// ImportExportItem ViewModel
/// </summary>
public abstract partial class ImportExportItemViewModel : ObservableObject, ISelectableViewModel
{
    protected ImportExportItemViewModel(string baseFile, ImportExportArgs properties)
    {
        BaseFile = baseFile;
        _properties = properties;

        _propertiesDisplay = _properties.ToString();

        Properties.PropertyChanged += Properties_PropertyChanged;
    }

    private void Properties_PropertyChanged(object? sender, System.ComponentModel.PropertyChangedEventArgs e) =>
        PropertiesDisplay = Properties.ToString();

    public string BaseFile { get; set; }

    [ObservableProperty] private ImportExportArgs _properties;

    [ObservableProperty] private bool _isChecked;

    [ObservableProperty] private string? _propertiesDisplay;

    public string Extension => Path.GetExtension(BaseFile).TrimStart('.');
    public string Name => Path.GetFileName(BaseFile);

    [GeneratedRegex(@"^.*source\\(archive|raw)\\")]
    private static partial Regex ProjectSubfolderRegex();

    // This is used by ExportView.xaml and TextureImportView.xaml
    public string FullPath => ProjectSubfolderRegex().Replace(BaseFile, string.Empty);

    public void SetProperties(ImportExportArgs args)
    {
        Properties.PropertyChanged -= Properties_PropertyChanged;
        
        Properties = args;
        PropertiesDisplay = Properties.ToString();

        Properties.PropertyChanged += Properties_PropertyChanged;
    }
}
