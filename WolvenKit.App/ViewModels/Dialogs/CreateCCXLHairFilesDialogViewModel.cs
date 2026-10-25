using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using CommunityToolkit.Mvvm.ComponentModel;
using WolvenKit.App.Extensions;
using WolvenKit.App.Helpers;
using WolvenKit.App.Models.ProjectManagement.Project;
using WolvenKit.App.Services;

namespace WolvenKit.App.ViewModels.Dialogs;

public partial class CreateCCXLHairFilesDialogViewModel : ObservableObject
{

    [ObservableProperty] private string _selectedInkCCFile = "";

    [ObservableProperty] private string _selectedMainAppFile = "";
    [ObservableProperty] private string _selectedCybAppFile = "";

    [ObservableProperty] private string _selectedShadowAppFile = "";


    [ObservableProperty] private string _selectedMainMeshFile = "";
    [ObservableProperty] private string _selectedCybMeshFile = "";

    [ObservableProperty] private string _selectedShadowMeshFile = "";

    [ObservableProperty] private string _selectedMiFile = "";

    [ObservableProperty] private string _selectedMiType = "";

    [ObservableProperty] private bool _isCap = false;

    [ObservableProperty] private string _selectedCapMiFile = "";

    private readonly Cp77Project _activeProject;
    private readonly ISettingsManager _settingsManager;
    private readonly ProjectResourceTools _projectResourceTools;
    public CreateCCXLHairFilesDialogViewModel(Cp77Project activeProject, ISettingsManager settingsManager,
        ProjectResourceTools projectResourceTools)
    {
        _activeProject = activeProject;
        _settingsManager = settingsManager;
        _projectResourceTools = projectResourceTools;

        InkCCFileOption.AddRange<string>(
            activeProject.ModFiles
                .Where(fp => fp.EndsWith(".inkcharcustomization"))

        );
        SelectedInkCCFile = InkCCFileOption.LastOrDefault() ?? "";


        AppFileOption.AddRange<string>(
            activeProject.ModFiles
                .Where(fp => fp.EndsWith(".app"))

        );
        SelectedMainAppFile = AppFileOption.First() ?? "";
        SelectedCybAppFile = AppFileOption.LastOrDefault() ?? "";
        SelectedShadowAppFile = AppFileOption.LastOrDefault() ?? "";


        MeshFileOption.AddRange<string>(
            activeProject.ModFiles
                .Where(fp => fp.EndsWith(".mesh"))

        );
        SelectedMainMeshFile = MeshFileOption.First() ?? "";
        SelectedCybMeshFile = MeshFileOption.LastOrDefault() ?? "";
        SelectedShadowMeshFile = MeshFileOption.LastOrDefault() ?? "";


        MiFileOption.AddRange<string>(
            activeProject.ModFiles
                .Where(fp => fp.EndsWith(".mi"))

        );
        SelectedMiFile = MiFileOption.LastOrDefault() ?? "";

        MainMiMaterialTypeList = new List<string> { "Braid", "Cap", "Cap01", "Curls", "Dread", "Long", "Short", "Brows", "Lashes" };
        SelectedMiType = "Long";

        SelectedCapMiFile = MiFileOption.FirstOrDefault() ?? "";
    }

    [ObservableProperty]
    private List<string> _inkCCFileOption = [];

    [ObservableProperty]
    private List<string> _appFileOption = [];

    [ObservableProperty]
    private List<string> _meshFileOption = [];

    [ObservableProperty]
    private List<string> _miFileOption = [];

    [ObservableProperty]
    private List<string> _mainMiMaterialTypeList = [];
}
