using WolvenKit.App.Services;
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