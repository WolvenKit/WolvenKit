using System.Collections.Generic;
using System.Linq;
using CommunityToolkit.Mvvm.ComponentModel;
using WolvenKit.App.Models.ProjectManagement.Project;

namespace WolvenKit.App.ViewModels.Dialogs;

public partial class GenerateRefitMeshesDialogViewModel : ObservableObject
{
    [ObservableProperty] private Dictionary<string, string> _maleBaseMeshOptions;
    [ObservableProperty] private Dictionary<string, string> _femaleBaseMeshOptions;

    [ObservableProperty] private string _maleBaseMesh = "";
    [ObservableProperty] private string _femaleBaseMesh = "";

    [ObservableProperty] private string _maleRefits = "";
    [ObservableProperty] private string _femaleRefits = "";

    public GenerateRefitMeshesDialogViewModel(Cp77Project activeProject)
    {
        var baseBodyMeshes = activeProject.ModFiles.Where(f => f.Contains("base_body") && f.EndsWith(".mesh")).ToList();
        MaleBaseMeshOptions = baseBodyMeshes.Where(f => f.Contains("pma")).ToDictionary(f => f, f => f);
        FemaleBaseMeshOptions = baseBodyMeshes.Where(f => f.Contains("pwa")).ToDictionary(f => f, f => f);
    }
}
