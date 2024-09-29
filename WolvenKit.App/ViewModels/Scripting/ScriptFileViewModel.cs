using WolvenKit.App.Services;
using WolvenKit.Core.Interfaces;
using WolvenKit.Modkit.Scripting;

namespace WolvenKit.App.ViewModels.Scripting;

public class ScriptFileViewModel : ScriptViewModel
{
    private readonly ISettingsManager _settingsManager;

    public ScriptFile ScriptFile { get; }

    public string? Version => ScriptFile.Version;
    public string? Author => ScriptFile.Author;
    public string? Description => ScriptFile.Description;
    public string? Usage => ScriptFile.Usage;

    public string Code => ScriptFile.Content;

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
        _settingsManager = settingsManager;
        ScriptFile = scriptFile;
        
        if (!_settingsManager.ScriptStatus!.TryGetValue(Path, out _enabled))
        {
            _enabled = true;
        }
    }

    public bool Reload(ILoggerService? loggerService)
    {
        return ScriptFile.Reload(loggerService);
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