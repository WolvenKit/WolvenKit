using WolvenKit.App.Services;
using WolvenKit.Core.Interfaces;
using WolvenKit.Modkit.Scripting;

namespace WolvenKit.App.ViewModels.Scripting;

public class ScriptFileViewModel : ScriptViewModel
{
    private readonly ISettingsManager _settingsManager;
    private readonly ScriptFile _scriptFile;

    public string? Version => _scriptFile.Version;
    public string? Author => _scriptFile.Author;
    public string? Description => _scriptFile.Description;
    public string? Usage => _scriptFile.Usage;

    public string Code => _scriptFile.Content;

    public string SelectInfo
    {
        get
        {
            if (Version != null && Author != null)
            {
                return $"v{Version} · {Author}";
            }
            else if (Version != null)
            {
                return $"v{Version}";
            }
            else if (Author != null)
            {
                return Author;
            }
            return "";
        }
    }
    public string? HoverInfo
    {
        get
        {
            if (Description != null && Usage != null)
            {
                return $"Description:\n{Description}\n\nUsage:\n{Usage}";
            }
            else if (Description != null)
            {
                return $"Description:\n{Description}";
            }
            else if (Usage != null)
            {
                return $"Usage:\n{Usage}";
            }
            return null;
        }
    }

    public override bool CanExecute => Type == ScriptType.General;
    public override bool CanDelete => Source == ScriptSource.User;

    public ScriptFileViewModel(ISettingsManager settingsManager, ScriptSource source, ScriptFile scriptFile) : base(scriptFile.Name, scriptFile.Path, scriptFile.Type, source)
    {
        _scriptFile = scriptFile;
        _settingsManager = settingsManager;

        if (!_settingsManager.ScriptStatus!.TryGetValue(Path, out _enabled))
        {
            _enabled = true;
        }
    }

    public bool Reload(ILoggerService? loggerService)
    {
        return _scriptFile.Reload(loggerService);
    }

    #region INotifyPropertyChanged

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

    #endregion
}