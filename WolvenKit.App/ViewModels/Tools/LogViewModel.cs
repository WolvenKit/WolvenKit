using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Documents;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using DynamicData;
using WolvenKit.App.Models.Docking;
using WolvenKit.App.Services;
using WolvenKit.App.ViewModels.Scripting;
using WolvenKit.Core.Interfaces;
using WolvenKit.Modkit.Scripting;

namespace WolvenKit.App.ViewModels.Tools;

/// <summary>
/// Implements the viewmodel that drives the log view.
/// </summary>
public partial class LogViewModel : ToolViewModel
{
    #region Fields

    /// <summary>
    /// Identifies the <see ref="ContentId"/> of this tool window.
    /// </summary>
    public const string ToolContentId = "Log_Tool";

    /// <summary>
    /// Identifies the caption string used for this tool window.
    /// </summary>
    public const string ToolTitle = "Log";

    private readonly ILoggerService _loggerService;
    private readonly AppScriptService _scriptService;
    private readonly ISettingsManager _settingsManager;

    // private readonly ReadOnlyObservableCollection<LogEntry> _logEntries;
    // public ReadOnlyObservableCollection<LogEntry> LogEntries => _logEntries;
    [ObservableProperty]
    private bool[] _filterByLevel = { true, true, true, true, true };

    private readonly ObservableCollection<ScriptFileViewModel> _scriptFiles = new();
    public CollectionViewSource ScriptFiles { get; } = new();

    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(CanRunScript))]
    private ScriptFileViewModel? _selectedScriptFile;

    [ObservableProperty]
    private bool _isRunningScript;

    public bool CanRunScript => SelectedScriptFile != null;

    [ObservableProperty]
    private FlowDocument _document = new();

    #endregion Fields

    public LogViewModel(
        ILoggerService loggerService,
        AppScriptService scriptService,
        ISettingsManager settingsManager
        ) : base(ToolTitle)
    {
        _loggerService = loggerService;
        _scriptService = scriptService;
        _settingsManager = settingsManager;

        SetupToolDefaults();
        SideInDockedMode = DockSide.Bottom;

        ScriptFiles.GroupDescriptions.Add(new PropertyGroupDescription("Source"));
        ScriptFiles.SortDescriptions.Add(new SortDescription("Name", ListSortDirection.Ascending));
        ScriptFiles.Source = _scriptFiles;
        GetScriptFiles();

        //filter, sort and populate reactive list,
        // _loggerService.Connect() //connect to the cache
        //     .ObserveOn(RxApp.MainThreadScheduler)
        //     .Bind(out _logEntries)
        //     .Subscribe(OnNext);
    }

    [RelayCommand]
    private void ToggleFilterLevel(string index)
    {
        if (!int.TryParse(index, out var level))
        {
            level = -1;
        }
        if (level < 0 || level >= FilterByLevel.Length)
        {
            return;
        }
        var copy = (bool[])FilterByLevel.Clone();

        copy[level] = !copy[level];
        if (copy.All(value => !value))
        {
            return;
        }
        FilterByLevel = copy;
    }

    [RelayCommand]
    private void UpdateScripts()
    {
        GetScriptFiles();
    }

    [RelayCommand]
    private async Task RunScript()
    {
        if (!CanRunScript || IsRunningScript)
        {
            return;
        }
        var scriptFile = SelectedScriptFile!;

        if (!File.Exists(scriptFile.Path))
        {
            return;
        }
        scriptFile.Reload(_loggerService);
        IsRunningScript = true;
        await _scriptService.ExecuteAsync(scriptFile.Code);
        IsRunningScript = false;
    }

    [RelayCommand]
    private void StopScript()
    {
        if (!IsRunningScript)
        {
            return;
        }
        _scriptService.Stop();
        IsRunningScript = false;
    }


    private void SetupToolDefaults() => ContentId = ToolContentId;

    private void GetScriptFiles()
    {
        _scriptFiles.Clear();
        ScanDir(ScriptSource.System, @"Resources\Scripts");
        ScanDir(ScriptSource.User, ISettingsManager.GetWScriptDir());

        void ScanDir(ScriptSource scriptSource, string path)
        {
            var scripts = _scriptService.GetScripts(path)
                .Where(script => script.Type == ScriptType.General)
                .Select(script => new ScriptFileViewModel(_settingsManager, scriptSource, script))
                .ToList();

            _scriptFiles.Add(scripts);
        }
    }

}
