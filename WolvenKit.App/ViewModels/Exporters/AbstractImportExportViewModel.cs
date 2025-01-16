﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using WolvenKit.App.Converters;
using WolvenKit.App.Services;
using WolvenKit.App.ViewModels.Tools;
using WolvenKit.Common.Model.Arguments;
using WolvenKit.Common.Services;

namespace WolvenKit.App.ViewModels.Exporters;

public abstract partial class AbstractImportExportViewModel : FloatingPaneViewModel
{
    protected readonly IAppArchiveManager _archiveManager;
    protected readonly INotificationService _notificationService;
    protected readonly ISettingsManager _settingsManager;

    protected (JsonObject, Type) _currentSettings;
    protected readonly JsonSerializerOptions _jsonSerializerSettings;

    protected Task? _refreshtask;

    protected AbstractImportExportViewModel(IAppArchiveManager archiveManager, INotificationService notificationService,
        ISettingsManager settingsManager, string header, string contentId) : base(header, contentId)
    {
        _archiveManager = archiveManager;
        _notificationService = notificationService;
        _settingsManager = settingsManager;

        _jsonSerializerSettings = new()
        {
            Converters = { new JsonFileEntryConverter(_archiveManager), new JsonArchiveConverter() }, WriteIndented = true
        };
    }

    [ObservableProperty] private ImportExportItemViewModel? _selectedObject;

    [ObservableProperty] private ObservableCollection<ImportExportItemViewModel> _items = new();

    [ObservableProperty] private bool _isProcessing;

    public List<string> VisibleItemPaths { get; set; } = new();


    #region commands

    [RelayCommand(CanExecute = nameof(IsAnyFile))] // TODO NotifyCanExecuteChangedFor
    private async Task ProcessAll() => await Task.Run(() => ExecuteProcessBulk(true));

    [RelayCommand(CanExecute = nameof(IsAnyFileSelected))] // TODO NotifyCanExecuteChangedFor
    private async Task ProcessSelected() => await Task.Run(() => ExecuteProcessBulk());

    [RelayCommand(CanExecute = nameof(IsAnyFileSelected))] // TODO NotifyCanExecuteChangedFor
    private void CopyArgumentsTemplateTo()
    {
        if (SelectedObject?.Properties is not ImportExportArgs args)
        {
            return;
        }

        _currentSettings = (SerializeArgs(args), args.GetType());
    }

    [RelayCommand(CanExecute = nameof(IsAnyFileSelected))] // TODO NotifyCanExecuteChangedFor
    private void PasteArgumentsTemplateTo()
    {
        var (settings, type) = _currentSettings;

        var count = Items
            .Where(item => item.IsChecked && item.Properties.GetType() == type)
            .Count(item =>
            {
                if (settings.Deserialize(type, _jsonSerializerSettings) is not ImportExportArgs ds)
                {
                    return false;
                }

                item.SetProperties(ds);
                return true;
            });

        if (count > 0)
        {
            _notificationService.Success($"Template has been copied to {count} items.");
        }
    }

    [RelayCommand]
    protected async Task Refresh()
    {
        if (_refreshtask is null || (_refreshtask is not null && _refreshtask.IsCompleted))
        {
            _refreshtask = LoadFilesAsync();
            await _refreshtask;
            OnRefresh?.Invoke(this, EventArgs.Empty);
        }
    }

    [RelayCommand]
    private void ToggleAdvancedOptions() => _settingsManager.ShowAdvancedOptions = !_settingsManager.ShowAdvancedOptions;

    #endregion

    #region Methods

    protected bool IsAnyFileSelected() => Items.Where(x => x.IsChecked).Any();

    private bool IsAnyFile() => Items.Any();

    private JsonObject SerializeArgs(ImportExportArgs args)
    {
        if (JsonSerializer.SerializeToNode(args, args.GetType(), _jsonSerializerSettings) is not JsonObject node)
        {
            throw new ArgumentNullException();
        }

        node.Remove("Changing");
        node.Remove("Changed");
        node.Remove("ThrownExceptions");

        return node;

    }

    protected abstract Task ExecuteProcessBulk(bool all = false);

    protected abstract Task LoadFilesAsync();

    public event EventHandler? OnRefresh;

    protected async void ImportExportViewModel_PropertyChanged(object? sender, System.ComponentModel.PropertyChangedEventArgs e)
    {
        // Restart refresh if we gained focus and aren't currently doing that
        if (!IsActive || e.PropertyName != nameof(IsActive) || _refreshtask?.IsCompleted == false)
        {
            return;
        }

        _refreshtask = LoadFilesAsync();
        await _refreshtask;
    }

    #endregion    
}

