using System.Collections.ObjectModel;
using WolvenKit.App.Services;
using WolvenKit.Modkit.Scripting;

namespace WolvenKit.App.ViewModels.Scripting;

public class ScriptDirectoryViewModel : ScriptViewModel
{
    public ObservableCollection<ScriptViewModel> Files { get; } = new();

    public override bool CanExecute => false;
    public override bool CanDelete => false;

    public ScriptDirectoryViewModel(ScriptSource scriptSource, ScriptType scriptType, ISettingsManager settingsManager) : base(scriptSource.ToString(), "", scriptType, scriptSource)
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