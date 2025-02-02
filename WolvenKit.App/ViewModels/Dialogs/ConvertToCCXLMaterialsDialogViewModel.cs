using System.Collections.Generic;
using System.Linq;
using CommunityToolkit.Mvvm.ComponentModel;
using WolvenKit.App.Extensions;
using WolvenKit.App.Models.ProjectManagement.Project;
using static System.Net.Mime.MediaTypeNames;

namespace WolvenKit.App.ViewModels.Dialogs;
public partial class ConvertToCCXLMaterialsDialogViewModel : ObservableObject
{
    [ObservableProperty] private string _selectedMi = "";

    [ObservableProperty] private string _mainhairMiFile = "";

    [ObservableProperty] private string _mainhairMiMaterialType = "";

    [ObservableProperty] private bool _IsCap = false;

    [ObservableProperty] private string _caphairMiFile = "";

    public ConvertToCCXLMaterialsDialogViewModel(Cp77Project activeProject) 
    {

        MiFileOption.AddRange<string>(
            activeProject.ModFiles
                .Where(fp => fp.EndsWith(".mi"))
        );

    }
    [ObservableProperty] private List<string> _miFileOption = [];
}
