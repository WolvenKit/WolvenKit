using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using CommunityToolkit.Mvvm.ComponentModel;
using WolvenKit.App.Extensions;
using WolvenKit.App.Helpers;
using WolvenKit.App.Models.ProjectManagement.Project;
using WolvenKit.App.Services;

namespace WolvenKit.App.ViewModels.Dialogs;

public partial class CreateCCXLHairFilesDialogViewModel : ObservableObject
{

    [ObservableProperty] private string _hairmodName = "";
    [ObservableProperty] private string _ccDisplayName = "";

    [ObservableProperty] private string _selectedInkCCFile = "";

    [ObservableProperty] private string _selectedMainAppFile = "";
    [ObservableProperty] private string _selectedCybAppFile = "";

    [ObservableProperty] private string _selectedShadowAppFile = "";


    [ObservableProperty] private string _selectedMainMeshFile = "";
    [ObservableProperty] private string _selectedCybMeshFile = "";

    [ObservableProperty] private string _selectedShadowMeshFile = "";

    [ObservableProperty] private string _selectedRigFile = "";
    [ObservableProperty] private string _selectedAnimGraphFile = "";

    [ObservableProperty] private string _selectedJsonFile = "";




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

        SelectedMainAppFile = AppFileOption.FirstOrDefault() ?? "";
        SelectedCybAppFile = AppFileOption.FirstOrDefault() ?? "";
        SelectedShadowAppFile = AppFileOption.FirstOrDefault() ?? "";

        MeshFileOption.AddRange<string>(
            activeProject.ModFiles
                .Where(fp => fp.EndsWith(".mesh"))

        );
        SelectedMainMeshFile = MeshFileOption.First() ?? "";
        
        SelectedCybMeshFile = MeshFileOption.FirstOrDefault() ?? "";
        SelectedShadowMeshFile = MeshFileOption.FirstOrDefault() ?? "";



        RigFileOption.AddRange<string>(
            activeProject.ModFiles
                .Where(fp => fp.EndsWith(".rig"))

        );
        SelectedRigFile = RigFileOption.LastOrDefault() ?? "";



        AnimGraphFileOption.AddRange<string>(
            activeProject.ModFiles
                .Where(fp => fp.EndsWith(".animgraph"))

        );


        SelectedAnimGraphFile = AnimGraphFileOption.LastOrDefault() ?? "";

        JsonFileOption.AddRange<string>(
           activeProject.ModFiles
               .Where(fp => fp.EndsWith(".json"))


       );
        SelectedJsonFile = JsonFileOption.LastOrDefault() ?? "";


    }

    [ObservableProperty]
    private List<string> _inkCCFileOption = [];

    [ObservableProperty]
    private List<string> _appFileOption = [];

    [ObservableProperty]
    private List<string> _meshFileOption = [];

    [ObservableProperty]
    private List<string> _rigFileOption = [];

    [ObservableProperty]
    private List<string> _animGraphFileOption = [];

    [ObservableProperty]
    private List<string> _jsonFileOption = [];



    public void SetFiles() {
        HairmodName = _activeProject.ModName;

        SelectedInkCCFile = InkCCFileOption.FirstOrDefault()!;

        SelectedMainAppFile = AppFileOption.FirstOrDefault()!;
        SelectedCybAppFile = AppFileOption.FirstOrDefault(fp => fp.Contains("_cyberware"))!;
        SelectedShadowAppFile = AppFileOption.FirstOrDefault(fp => fp.Contains("_fpp"))!;

        SelectedMainMeshFile = MeshFileOption.FirstOrDefault()!;
        SelectedCybMeshFile = MeshFileOption.FirstOrDefault(fp => fp.Contains("_cyberware"))!;
        SelectedShadowMeshFile = MeshFileOption.FirstOrDefault(fp => fp.Contains("_shadow"))!;

        SelectedRigFile = RigFileOption.FirstOrDefault()!;
        SelectedAnimGraphFile = AnimGraphFileOption.FirstOrDefault()!;

        SelectedJsonFile = JsonFileOption.FirstOrDefault()!;

    }
}
