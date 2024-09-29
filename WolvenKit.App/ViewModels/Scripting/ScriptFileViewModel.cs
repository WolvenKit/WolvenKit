using WolvenKit.App.Services;
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