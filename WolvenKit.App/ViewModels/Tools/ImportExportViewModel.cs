using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using WolvenKit.Common;
using WolvenKit.Common.Model.Arguments;
using WolvenKit.Common.Services;
using WolvenKit.Functionality.Converters;
using WolvenKit.Functionality.Services;
using WolvenKit.ViewModels.Tools;

namespace WolvenKit.App.ViewModels.Tools;

public abstract partial class ImportExportViewModel : FloatingPaneViewModel
{
    private readonly IArchiveManager _archiveManager;
    private readonly INotificationService _notificationService;
    private readonly ISettingsManager _settingsManager;

    protected (JsonObject, Type) _currentSettings;
    protected readonly JsonSerializerOptions _jsonSerializerSettings;

    protected ImportExportViewModel(IArchiveManager archiveManager, INotificationService notificationService, ISettingsManager settingsManager, string header, string contentId) : base(header, contentId)
    {
        _archiveManager = archiveManager;
        _notificationService = notificationService;
        _settingsManager = settingsManager;

        _jsonSerializerSettings = new()
        {
            Converters =
            {
                new JsonFileEntryConverter(_archiveManager),
                new JsonArchiveConverter()
            },
            WriteIndented = true
        };
    }

    [ObservableProperty] private ImportExportItemViewModel? _selectedObject;

    [ObservableProperty] private ObservableCollection<ImportExportItemViewModel> _items = new();

    [ObservableProperty] private bool _isProcessing;

    #region MyRegion

    [RelayCommand(CanExecute = nameof(IsAnyFile))]
    public async Task ProcessAll() => await ExecuteProcessBulk(true);

    [RelayCommand(CanExecute = nameof(IsAnyFileSelected))]
    public async Task ProcessSelected() => await ExecuteProcessBulk();

    [RelayCommand(CanExecute = nameof(IsAnyFileSelected))]
    private void CopyArgumentsTemplateTo()
    {
        if (SelectedObject?.Properties is not ImportExportArgs args)
        {
            return;
        }

        _currentSettings = (SerializeArgs(args), args.GetType());
    }

    [RelayCommand(CanExecute = nameof(IsAnyFileSelected))]
    private void PasteArgumentsTemplateTo()
    {
        var results = Items.Where(x => x.IsChecked);
        var count = 0;

        foreach (var item in results)
        {
            var (settings, type) = _currentSettings;

            if (item.Properties is null || item.Properties.GetType() != type)
            {
                continue;
            }

            if (settings.Deserialize(type, _jsonSerializerSettings) is ImportExportArgs ds)
            {
                item.Properties = ds;
                count++;
            }
        }

        if (count > 0)
        {
            _notificationService.Success($"Template has been copied to the selected items.");
        }
    }

    [RelayCommand]
    private void Refresh() => LoadFiles();

    [RelayCommand]
    private void ToggleAdvancedOptions()
    {
        _settingsManager.ShowAdvancedOptions = !_settingsManager.ShowAdvancedOptions;
    }


    #endregion

    #region Methods

    protected bool IsAnyFileSelected() => Items.Where(x => x.IsChecked).Any();

    private bool IsAnyFile() => Items.Any();

    private JsonObject SerializeArgs(ImportExportArgs args)
    {
        if (JsonSerializer.SerializeToNode(args, args.GetType(), _jsonSerializerSettings) is JsonObject node)
        {
            node.Remove("Changing");
            node.Remove("Changed");
            node.Remove("ThrownExceptions");

            return node;
        }

        throw new ArgumentNullException();
    }

    protected abstract Task ExecuteProcessBulk(bool all = false);

    protected abstract void LoadFiles();

    #endregion
}
