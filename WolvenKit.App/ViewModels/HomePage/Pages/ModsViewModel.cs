using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Threading;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using DynamicData;
using Serilog.Events;
using WolvenKit.App.Helpers;
using WolvenKit.App.Interaction;
using WolvenKit.App.Models;
using WolvenKit.App.Services;
using WolvenKit.App.ViewModels.Shell;
using WolvenKit.Common;
using WolvenKit.Core.Extensions;
using WolvenKit.Core.Interfaces;
using WolvenKit.Core.Services;
using WolvenKit.Helpers;

namespace WolvenKit.App.ViewModels.HomePage.Pages;

public partial class ModsViewModel : PageViewModel
{
    private readonly ISettingsManager _settings;
    private readonly ILoggerService _logger;
    private readonly IPluginService _pluginService;
    private readonly IProgressService<double> _progressService;
    private readonly MySink _mySink;
    private readonly AppViewModel _appViewModel;

    private readonly JsonSerializerOptions _options = new()
    {
        WriteIndented = true,
        DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
        IgnoreReadOnlyProperties = true,
    };

    public ModsViewModel(
        ISettingsManager settings, 
        ILoggerService logger, 
        IPluginService pluginService, 
        IProgressService<double> progressService,
        MySink mySink,
        AppViewModel appViewModel)
    {
        _settings = settings;
        _logger = logger;
        _pluginService = pluginService;
        _progressService = progressService;
        _mySink = mySink;
        _appViewModel = appViewModel;

        _logText = "";
        _confirmText = "";

        _settings.PropertyChanged += Settings_PropertyChanged;
        _progressService.ProgressChanged += ProgressService_ProgressChanged;

        var myOperation = _mySink.Connect()
        .Bind(out var _logEntries)
        .DisposeMany()
        .Subscribe(OnNext);

    }

    private void OnNext(IChangeSet<LogEvent> obj)
    {
        if (!IsProcessing)
        {
            return;
        }

        foreach (var change in obj)
        {
            switch (change.Reason)
            {
                case ListChangeReason.Add:
                    var item = change.Item.Current;
                    AddLog(item);
                    break;
                case ListChangeReason.AddRange:
                    foreach (var logEntry in change.Range)
                    {
                        AddLog(logEntry);
                    }
                    break;
                case ListChangeReason.Replace:
                case ListChangeReason.Remove:
                case ListChangeReason.RemoveRange:
                case ListChangeReason.Refresh:
                case ListChangeReason.Moved:
                case ListChangeReason.Clear:
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }

    private void ProgressService_ProgressChanged(object? sender, double e) => Step = (int)(e * 5 - 1);

    private void Settings_PropertyChanged(object? sender, System.ComponentModel.PropertyChangedEventArgs e)
    {
        if (e.PropertyName == nameof(ISettingsManager.CP77ExecutablePath))
        {
            if (!string.IsNullOrEmpty(_settings.CP77ExecutablePath))
            {
                LoadMods();
            }
        }
    }

    [ObservableProperty] private bool _showLog = false;

    [ObservableProperty] private string _logText;

    [ObservableProperty] private string _confirmText;

    [ObservableProperty] private int _step;

    [ObservableProperty] private bool _loadOrderChanged;

    [ObservableProperty] private ObservableCollection<ModInfoViewModel> _mods = new();

    [ObservableProperty] private ModInfoViewModel? _selectedMod;

    [ObservableProperty] private IEnumerable<ModInfoViewModel>? _selectedMods;

    [ObservableProperty] private bool _isProcessing;

    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(IsNotFinished))]
    private bool _isFinished;

    public bool IsNotFinished => !IsFinished;

    [ObservableProperty] private bool _isForceEnabled;

    #region commands

    [RelayCommand]
    private void Confirm()
    {
        IsFinished = false;
        IsProcessing = false;
    }

    [RelayCommand]
    private void ToggleLog()
    {
        ShowLog = !ShowLog;
    }

    [RelayCommand]
    private async Task Deploy() => await DeployRedmod();

    [RelayCommand]
    private void Refresh() => LoadMods();

    [RelayCommand]
    private void OpenModFolder() => Commonfunctions.ShowFolderInExplorer(_settings.GetRED4GameModDir());

    [RelayCommand]
    private void LaunchGame()
    {
        try
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = _settings.GetRED4GameLaunchCommand(),
                Arguments = $"{_settings.GetRED4GameLaunchOptions()} -modded",
                ErrorDialog = true,
            });
        }
        catch (Exception ex)
        {
            _logger.Error("Launch: error launching game! Please check your executable path in Settings.");
            _logger.Info($"Launch: error debug info: {ex.Message}");
        }
    }

    [RelayCommand]
    private async Task CheckRedMod()
    {
        if (!_pluginService.IsInstalled(EPlugin.redmod))
        {
            var res = await Interactions
                .ShowMessageBoxAsync(
                    "The RedMod tools are not installed and mod compilation will not work. Would you like to install the RedMod tools now?",
                    "RedMod not found");

            switch (res)
            {
                case WMessageBoxResult.OK:
                case WMessageBoxResult.Yes:
                    await _appViewModel.ShowHomePage(EHomePage.Plugins);
                    break;
                case WMessageBoxResult.None:
                case WMessageBoxResult.Cancel:
                case WMessageBoxResult.No:
                case WMessageBoxResult.Custom:
                default:
                    break;
            }
        }
    }
    
    [RelayCommand]
    private void LaunchGameFromLastSave()
    {
        try
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = _settings.GetRED4GameLaunchCommand(),
                Arguments = $"{_settings.GetRED4GameLaunchOptions()} -modded",
                ErrorDialog = true,
            });
        }
        catch (Exception ex)
        {
            _logger.Error("Launch: error launching game! Please check your executable path in Settings.");
            _logger.Info($"Launch: error debug info: {ex.Message}");
        }
    }

    [RelayCommand]
    private void Remove()
    {
        if (SelectedMod is null)
        {
            return;
        }

        if (!Directory.Exists(SelectedMod.Path))
        {
            _logger.Warning($"Could not find mod: {SelectedMod.Path}");
        }

        try
        {
            Directory.Delete(SelectedMod.Path, true);

            Mods.Remove(SelectedMod);
        }
        catch (Exception)
        {
            _logger.Error($"Could not delete mod: {SelectedMod.Path}");
        }
    }

    #endregion

    private void AddLog(LogEvent item)
    {
        var msg = item.RenderMessage();
        LogText += $"{msg}\n";
    }

    private IEnumerable<ModInfoViewModel> GetEnabledMods() => Mods.Where(x => x.IsEnabled);

    private async Task<bool> DeployRedmod()
    {
        if (!_pluginService.IsInstalled(EPlugin.redmod))
        {
            _logger.Error("Redmod needs to be installed to deploy mods.");
            var response = await Interactions.ShowMessageBoxAsync("The RedMod tools are not installed. Would you like to install them?", "RedMod not found");

            switch (response)
            {
                case WMessageBoxResult.OK:
                case WMessageBoxResult.Yes:
                    await _appViewModel.ShowHomePage(EHomePage.Plugins);
                    break;
                case WMessageBoxResult.None:
                case WMessageBoxResult.Cancel:
                case WMessageBoxResult.No:
                case WMessageBoxResult.Custom:
                default:
                    break;
            }

            return false;
        }

        IsProcessing = true;
        LogText = "Deploying Redmod ...";

        // compile with redmod
        var redmodPath = Path.Combine(_settings.GetRED4GameRootDir(), "tools", "redmod", "bin", "redMod.exe");
        if (!File.Exists(redmodPath))
        {
            _logger.Error("RedMod tools are not installed. Please go to WolvenKit plugins and install RedMod.");
            IsProcessing = false;
            return false;
        }
        else
        {
            _progressService.Report(0);

            var enabledMods = GetEnabledMods().OrderBy(x => x.LoadOrder).ToList();

            var rttiSchemaPath = Path.Combine(_settings.GetRED4GameRootDir(), "tools", "redmod", "metadata.json");
            var args = $"deploy -root=\"{_settings.GetRED4GameRootDir()}\"";

            if (LoadOrderChanged || IsForceEnabled)
            {
                args += " -force";
            }

            var modsStr = string.Join(' ', enabledMods.Select(x => $"\"{x.Folder}\""));
            args += $" -mod={modsStr}";

            _logger.Info($"WorkDir: {redmodPath}");
            _logger.Info($"Running commandlet: {args}");

            _progressService.Report(0.0);

            var workingDir = Path.Combine(_settings.GetRED4GameRootDir(), "tools", "redmod", "bin");
            var result = await ProcessUtil.RunRedmodAsync(redmodPath, args, workingDir, progress: _progressService);

            _progressService.Report(1.0);
            _progressService.Completed();

            IsFinished = true;
            ConfirmText = result 
                ? $"Sucessfully deployed {enabledMods.Count} mods with REDmod." 
                : "REDmod deploy failed. Please check the log for details.";

            return result;
        }
    }

    private void LoadMods()
    {
        LoadModsInfo();

        ParseMods();
    }

    private void LoadModsInfo()
    {
        Mods.Clear();

        var di = new DirectoryInfo(_settings.GetRED4GameModDir());
        var infos = di.GetFiles("info.json", SearchOption.AllDirectories);
        foreach (var item in infos)
        {
            try
            {
                var info = JsonSerializer.Deserialize<ModInfo>(File.ReadAllText(item.FullName), _options).NotNull();
                var folder = item.Directory.NotNull().FullName;
                Mods.Add(new ModInfoViewModel(info, folder, _logger));
            }
            catch (Exception)
            {
                _logger.Warning($"Could not read mod file: {item.FullName}");
            }

        }
    }

    private void ParseMods()
    {
        // parse existing mods.info and update enabled
        // also update load order
        var modsInfoPath = Path.Combine(_settings.GetRED4GameRootDir(), "r6", "cache", "modded", "mods.json");
        var foundMods = new List<ModInfoViewModel>();
        if (File.Exists(modsInfoPath))
        {
            try
            {
                var modsInfo = JsonSerializer.Deserialize<ModsInfo>(File.ReadAllText(modsInfoPath), _options).NotNull();
                for (var i = 0; i < modsInfo.Mods.Count; i++)
                {
                    var mod = modsInfo.Mods[i];

                    var local = Mods.FirstOrDefault(x => x.Folder == mod.folder);
                    if (local is not null)
                    {
                        local.IsEnabled = mod.enabled;
                        local.LoadOrder = i;
                        foundMods.Add(local);
                    }
                }
            }
            catch (Exception)
            {
                _logger.Warning($"Could not read mods info file: {modsInfoPath}");
                return;
            }



        }

        // loop through all existing mods
        // reorder according to modsInfo
        // first come all the mods in mods.info
        // then the rest
        var rest = Mods.Where(x => !foundMods.Contains(x)).ToList();
        for (var i = 0; i < rest.Count; i++)
        {
            var mod = rest[i];
            mod.LoadOrder = i + foundMods.Count;
        }

        _logger.Info($"Found {Mods.Count} REDmods.");
    }

    public void SetLoadOrderChanged(bool v) => LoadOrderChanged = v;
}
