using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.Input;
using WolvenKit.App.Interaction;
using WolvenKit.App.Services;
using WolvenKit.App.ViewModels.Shell;

namespace WolvenKit.App.ViewModels.Dialogs;

public partial class ScriptManagerViewModel : DialogViewModel
{
    private const string s_scriptExtension = ".wscript";

    private readonly AppViewModel _appViewModel;
    private readonly ExtendedScriptService _scriptService;
    private readonly ISettingsManager _settingsManager;

    
    public ScriptManagerViewModel(AppViewModel appViewModel, ExtendedScriptService scriptService, ISettingsManager settingsManager)
    {
        _appViewModel = appViewModel;
        _scriptService = scriptService;
        _settingsManager = settingsManager;

        GetScriptFiles();
    }

    public ObservableCollection<ScriptEntry> Scripts { get; } = new();


    public void AddScript(string fileName, ScriptType type)
    {
        if (string.IsNullOrEmpty(fileName))
        {
            return;
        }

        if (!fileName.EndsWith(s_scriptExtension))
        {
            fileName += s_scriptExtension;
        }

        var scriptPath = Path.Combine(ISettingsManager.GetWScriptDir(), fileName);
        if (File.Exists(scriptPath))
        {
            return;
        }

        File.Create(scriptPath).Close();
        GetScriptFiles();
    }

    [RelayCommand]
    private void Ok()
    {
        _appViewModel.CloseModalCommand.Execute(null);
    }

    [RelayCommand]
    private void Cancel() => _appViewModel.CloseModalCommand.Execute(null);


    public void GetScriptFiles()
    {
        _settingsManager.ScriptStatus ??= new();

        Scripts.Clear();

        var files = new List<string>();

        ScanDir(ScriptSource.System, @"Resources\Scripts");
        ScanDir(ScriptSource.User, ISettingsManager.GetWScriptDir());

        var keys = _settingsManager.ScriptStatus.Keys.ToList();
        foreach (var statusKey in keys)
        {
            if (!files.Contains(statusKey))
            {
                _settingsManager.ScriptStatus.Remove(statusKey);
            }
        }

        void ScanDir(ScriptSource scriptSource, string path)
        {
            var generalScriptDir = new ScriptDirectory(scriptSource, ScriptType.General, _settingsManager);
            var onSaveScriptDir = new ScriptDirectory(scriptSource, ScriptType.OnSave, _settingsManager);
            var uiScriptDir = new ScriptDirectory(scriptSource, ScriptType.Ui, _settingsManager);

            foreach (var file in Directory.GetFiles(path, $"*{s_scriptExtension}"))
            {
                var fileName = Path.GetFileName(file);
                files.Add(file);

                if (!_settingsManager.ScriptStatus.TryGetValue(fileName, out var enabled))
                {
                    enabled = true;
                }

                if (fileName.StartsWith("ui_"))
                {
                    uiScriptDir.Files.Add(new ScriptFile(fileName, file, ScriptType.Ui, scriptSource, _settingsManager));
                }
                else if (fileName.StartsWith("onSave_"))
                {
                    onSaveScriptDir.Files.Add(new ScriptFile(fileName, file, ScriptType.OnSave, scriptSource, _settingsManager));
                }
                else
                {
                    generalScriptDir.Files.Add(new ScriptFile(fileName, file, ScriptType.General, scriptSource, _settingsManager));
                }
            }

            Scripts.Add(generalScriptDir);
            Scripts.Add(onSaveScriptDir);
            Scripts.Add(uiScriptDir);
        }
    }

    public async Task OpenFile(ScriptFile scriptFile)
    {
        if (!File.Exists(scriptFile.Path))
        {
            return;
        }

        var localFilePath = scriptFile.Path;
        if (scriptFile.ScriptSource == ScriptSource.System)
        {
            var response = await Interactions.ShowMessageBoxAsync(
                "Trying to open a system file. Should a local copy be created?",
                "Open system file",
                WMessageBoxButtons.YesNo);

            if (response == WMessageBoxResult.No)
            {
                return;
            }

            localFilePath = Path.Combine(ISettingsManager.GetWScriptDir(), scriptFile.Name);
            if (File.Exists(localFilePath))
            {
                response = await Interactions.ShowMessageBoxAsync(
                    "A copy of this file already exists. Overwrite it?",
                    "Overwrite file",
                    WMessageBoxButtons.YesNo);

                if (response == WMessageBoxResult.No)
                {
                    return;
                }
            }

            File.Copy(scriptFile.Path, localFilePath, true);
        }

        await _appViewModel.RequestFileOpen(localFilePath);
        _appViewModel.CloseModalCommand.Execute(null);
    }

    public async Task RunFile(ScriptFile scriptFile)
    {
        if (!File.Exists(scriptFile.Path))
        {
            return;
        }

        var code = File.ReadAllText(scriptFile.Path);

        await _scriptService.ExecuteAsync(code);
    }

    public async Task DeleteFile(ScriptFile scriptFile)
    {
        if (!File.Exists(scriptFile.Path))
        {
            return;
        }

        var response = await Interactions.ShowMessageBoxAsync(
            $"Are you sure you want to delete \"{scriptFile.Name}\"?",
            "Add file",
            WMessageBoxButtons.YesNo);

        if (response == WMessageBoxResult.Yes)
        {
            File.Delete(scriptFile.Path);
            GetScriptFiles();
        }
    }
}

public abstract class ScriptEntry : INotifyPropertyChanged
{
    protected bool _enabled;

    public string Name { get; protected set; }
    public string Path { get; }
    public ScriptType ScriptType { get; }
    public ScriptSource ScriptSource { get; }

    public bool Enabled
    {
        get => _enabled;
        set => SetField(ref _enabled, value);
    }

    public bool CanEnable => ScriptType != ScriptType.General;
    public abstract bool CanExecute { get; }
    public abstract bool CanDelete { get; }

    public ScriptEntry(string name, string path, ScriptType scriptType, ScriptSource scriptSource)
    {
        Name = name;
        Path = path;
        ScriptType = scriptType;
        ScriptSource = scriptSource;
    }

    #region INotifyPropertyChanged

    public event PropertyChangedEventHandler? PropertyChanged;

    protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

    protected bool SetField<T>(ref T field, T value, [CallerMemberName] string? propertyName = null)
    {
        if (EqualityComparer<T>.Default.Equals(field, value))
        {
            return false;
        }
        field = value;
        OnPropertyChanged(propertyName);
        return true;
    }

    #endregion
}

public class ScriptFile : ScriptEntry
{
    private readonly ISettingsManager _settingsManager;

    public string? Version { get; private set; }
    public string? Author { get; private set; }

    public override bool CanExecute => ScriptType == ScriptType.General;
    public override bool CanDelete => ScriptSource == ScriptSource.User;

    public ScriptFile(string name, string path, ScriptType scriptType, ScriptSource scriptSource, ISettingsManager settingsManager) : base(name, path, scriptType, scriptSource)
    {
        _settingsManager = settingsManager;

        if (Name.EndsWith(".wscript"))
        {
            Name = Name.Substring(0, Name.Length - 8);
        }

        if (!_settingsManager.ScriptStatus!.TryGetValue(Path, out _enabled))
        {
            _enabled = true;
        }

        GetInfo();
    }

    private void GetInfo()
    {
        foreach (var line in File.ReadAllLines(Path))
        {
            if (!line.StartsWith("// "))
            {
                break;
            }

            var comment = line.Substring(3);

            if (comment.StartsWith("@version "))
            {
                Version = comment.Substring("@version ".Length);
            }

            if (comment.StartsWith("@author "))
            {
                Author = comment.Substring("@author ".Length);
            }
        }
    }

    protected override void OnPropertyChanged(string? propertyName = null)
    {
        base.OnPropertyChanged(propertyName);

        if (propertyName == nameof(Enabled))
        {
            if (!_settingsManager.ScriptStatus!.TryAdd(Path, Enabled))
            {
                _settingsManager.ScriptStatus[Path] = Enabled;
            }
            _settingsManager.Save();
        }
    }
}

public class ScriptDirectory : ScriptEntry
{
    public ObservableCollection<ScriptEntry> Files { get; } = new();

    public override bool CanExecute => false;
    public override bool CanDelete => false;

    public ScriptDirectory(ScriptSource scriptSource, ScriptType scriptType, ISettingsManager settingsManager) : base(scriptSource.ToString(), "", scriptType, scriptSource)
    {
    }

    #region INotifyPropertyChanged

    protected override void OnPropertyChanged(string? propertyName = null)
    {
        base.OnPropertyChanged(propertyName);

        if (propertyName == nameof(Enabled))
        {
            foreach (var scriptFile in Files)
            {
                scriptFile.Enabled = Enabled;
            }
        }
    }

    #endregion
}

public enum ScriptType
{
    General,
    OnSave,
    Ui
}

public enum ScriptSource
{
    System,
    User
}