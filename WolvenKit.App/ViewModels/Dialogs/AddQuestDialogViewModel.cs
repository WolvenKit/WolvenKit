using CommunityToolkit.Mvvm.ComponentModel;
using WolvenKit.App.Models.ProjectManagement.Project;

namespace WolvenKit.App.ViewModels.Dialogs;

public partial class AddQuestDialogViewModel : ObservableObject
{
    public AddQuestDialogViewModel(Cp77Project project)
    {
        ModName = project.Name;
    }

    [ObservableProperty] private string _modName;
} 