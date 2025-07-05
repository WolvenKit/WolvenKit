using System.ComponentModel;
using WolvenKit.Common;
using WolvenKit.Common.Services;
using WolvenKit.RED4.CR2W;

namespace WolvenKit.App.Services;

public class LocKeyServiceExt : LocKeyService
{
    private ISettingsManager _settingsManager;

    public LocKeyServiceExt(Red4ParserService parser, IArchiveManager archive, ISettingsManager settingsManager) : base(parser, archive)
    {
        _settingsManager = settingsManager;
        _settingsManager.PropertyChanged += Settings_PropertyChanged;

        Language = _settingsManager.GameLanguage;
    }

    private void Settings_PropertyChanged(object? sender, PropertyChangedEventArgs e)
    {
        if (e.PropertyName == nameof(ISettingsManager.GameLanguage))
        {
            Language = _settingsManager.GameLanguage;
        }
    }
}