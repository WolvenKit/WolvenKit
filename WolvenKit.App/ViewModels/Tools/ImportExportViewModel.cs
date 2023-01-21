using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.Input;
using ReactiveUI.Fody.Helpers;
using WolvenKit.Common;
using WolvenKit.Common.Interfaces;
using WolvenKit.Common.Model.Arguments;
using WolvenKit.Common.Services;
using WolvenKit.Core.Extensions;
using WolvenKit.Core.Interfaces;
using WolvenKit.Core.Services;
using WolvenKit.Functionality.Controllers;
using WolvenKit.Functionality.Converters;
using WolvenKit.Functionality.Services;
using WolvenKit.ViewModels.Tools;

namespace WolvenKit.App.ViewModels.Tools;

public abstract partial class ImportExportViewModel : FloatingPaneViewModel
{
    
    protected (JsonObject, Type) currentSettings;
    protected static readonly JsonSerializerOptions s_jsonSerializerSettings = new()
    {
        Converters =
            {
                new JsonFileEntryConverter(),
                new JsonArchiveConverter()
            },
        WriteIndented = true
    };

    protected ImportExportViewModel(string header, string contentId) : base(header, contentId)
    {
    }

    [Reactive] public ImportExportItemViewModel? SelectedObject { get; set; }

    [Reactive] public ObservableCollection<ImportExportItemViewModel> Items { get; set; } = new();

    [Reactive] public bool IsProcessing { get; set; } = false;

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

        currentSettings = (SerializeArgs(args), args.GetType());
    }

    [RelayCommand(CanExecute = nameof(IsAnyFileSelected))]
    private void PasteArgumentsTemplateTo()
    {
        var results = Items.Where(x => x.IsChecked);
        var count = 0;

        foreach (var item in results)
        {
            var (settings, type) = currentSettings;

            if (item.Properties.GetType() != type)
            {
                continue;
            }

            item.Properties = settings.Deserialize(type, s_jsonSerializerSettings) as ImportExportArgs;
            count++;
        }

        if (count > 0)
        {
            _notificationService.Success($"Template has been copied to the selected items.");
        }
    }

    [RelayCommand]
    private void Refresh() => LoadFiles();

    [RelayCommand]
    private void ToggleAdvancedOptions() => _settingsManager.ShowAdvancedOptions = !_settingsManager.ShowAdvancedOptions;


    #endregion

    #region Methods

    protected bool IsAnyFileSelected() => Items.Where(x => x.IsChecked).Any();

    private bool IsAnyFile() => Items.Any();

    private JsonObject SerializeArgs(ImportExportArgs args)
    {
        if (JsonSerializer.SerializeToNode(args, args.GetType(), s_jsonSerializerSettings) is JsonObject node)
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
