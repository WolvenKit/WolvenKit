using WolvenKit.App.ViewModels.Dialogs;

namespace WolvenKit.App.Factories;

public interface IDialogViewModelFactory
{
    public SoundModdingViewModel? SoundModdingViewModel();

    public NewFileViewModel? NewFileViewModel();
}
