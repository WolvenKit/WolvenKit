using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using CommunityToolkit.Mvvm.ComponentModel;
using WolvenKit.App.Extensions;
using WolvenKit.App.Models.ProjectManagement.Project;
using static System.Net.Mime.MediaTypeNames;

namespace WolvenKit.App.ViewModels.Dialogs;
public partial class ConvertHairToCCXLMaterialsDialogViewModel : ObservableObject
{
    [ObservableProperty] private string _selectedMiFile = "";

    [ObservableProperty] private string _selectedMiType = "";

    [ObservableProperty] private bool _IsCap = false;

    [ObservableProperty] private string _selectedCapMiFile = "";

    public ConvertHairToCCXLMaterialsDialogViewModel(Cp77Project activeProject) 
    {

        MiFileOption.AddRange<string>(
            activeProject.ModFiles
                .Where(fp => fp.EndsWith(".mi"))

        );
        SelectedMiFile = MiFileOption.LastOrDefault() ?? "";

        MainMiMaterialTypeList = new List<string> { "Braid", "Cap", "Cap01", "Curls", "Dread", "Long", "Short", "Brows", "Lashes" };
        SelectedMiType = "Long" ?? MainMiMaterialTypeList.LastOrDefault();

        SelectedCapMiFile = MiFileOption.FirstOrDefault() ?? ""; 

    }
    [ObservableProperty] private List<string> _miFileOption = [];
    [ObservableProperty] private List<string> _mainMiMaterialTypeList = [];
    protected override void OnPropertyChanged(PropertyChangedEventArgs e)
    {
        base.OnPropertyChanged(e);

    }

}
