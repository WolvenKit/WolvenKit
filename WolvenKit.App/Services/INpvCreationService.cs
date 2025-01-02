using WolvenKit.App.ViewModels.Dialogs;

namespace WolvenKit.App.Services;

public interface INpvCreationService
{
    void CreateNpv(NpvCreationDialogViewModel viewModel);
}