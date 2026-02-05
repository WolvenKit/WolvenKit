using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using CommunityToolkit.Mvvm.ComponentModel;
using WolvenKit.App.Models.ProjectManagement.Project;
using WolvenKit.Interfaces.Extensions;

namespace WolvenKit.App.ViewModels.Dialogs;

public partial class AddPropFileDialogViewModel : ObservableObject
{

    [ObservableProperty] private Dictionary<string, string> _projectFolders;

    [ObservableProperty] private Dictionary<string, string> _projectMeshes;

    [ObservableProperty] private bool _cleanupInvalidEntries = true;

    /// <summary>
    /// Move mesh files to parent folder? (if they aren't already)
    /// </summary>
    [ObservableProperty] private bool _moveMeshesToFolder = false;

    /// <summary>
    /// Move mesh files to parent folder? (if they aren't already)
    /// </summary>
    [ObservableProperty] private bool _readAppearancesFromMesh = false;

    /// <summary>
    /// Relative path to PropFile folder
    /// </summary>
    [ObservableProperty] private string _parentFolder = "";

    /// <summary>
    /// name for PropFile file
    /// </summary>
    [ObservableProperty] private string _propName = "";

    [ObservableProperty] private List<string>? _appearances;

    [ObservableProperty] private string _meshFile1 = "";
    [ObservableProperty] private bool _meshFile1UseAppearances = false;

    [ObservableProperty] private string _meshFile2 = "";
    [ObservableProperty] private bool _meshFile2UseAppearances = false;

    [ObservableProperty] private string _meshFile3 = "";
    [ObservableProperty] private bool _meshFile3UseAppearances = false;

    [ObservableProperty] private string _meshFile4 = "";
    [ObservableProperty] private bool _meshFile4UseAppearances = false;


    [ObservableProperty] private bool _rememberSelection = false;

    public bool HasMoveMeshBeenTouched { get; set; } = false;

    public AddPropFileDialogViewModel(Cp77Project project)
    {
        ProjectFolders = project.GetAllFolders(project.ModDirectory).ToDictionary<string, string>(x => x);
        ProjectMeshes = project.ModFiles.Where(f => f.HasFileExtension(".mesh")).ToDictionary<string, string>(x => x);
        PropName = "";
        Appearances = [];
    }

    private bool NeedsMoveToParentFolder(string filePath)
    {
        if (string.IsNullOrEmpty(filePath) || string.IsNullOrEmpty(ParentFolder))
        {
            return false;
        }

        return !filePath.StartsWith(ParentFolder);
    }

    protected override void OnPropertyChanged(PropertyChangedEventArgs e)
    {
        switch (e.PropertyName)
        {
            case nameof(ParentFolder):
                ParentFolder = ParentFolder.ToFilePath();

                if (string.IsNullOrEmpty(PropName))
                {
                    PropName = (ParentFolder.Split(Path.DirectorySeparatorChar).LastOrDefault() ?? "")
                        .ToHumanFriendlyString();
                }

                // Update "Move meshes" checkbox based on parent folder path
                if (HasMoveMeshBeenTouched)
                {
                    break;
                }

                MoveMeshesToFolder = NeedsMoveToParentFolder(MeshFile1) || NeedsMoveToParentFolder(MeshFile2) ||
                                     NeedsMoveToParentFolder(MeshFile3) || NeedsMoveToParentFolder(MeshFile4);
                break;
            case nameof(MeshFile1) when !HasMoveMeshBeenTouched:
                MoveMeshesToFolder = MoveMeshesToFolder || NeedsMoveToParentFolder(MeshFile1);
                break;
            case nameof(MeshFile2) when !HasMoveMeshBeenTouched:
                MoveMeshesToFolder = MoveMeshesToFolder || NeedsMoveToParentFolder(MeshFile2);
                break;
            case nameof(MeshFile3) when !HasMoveMeshBeenTouched:
                MoveMeshesToFolder = MoveMeshesToFolder || NeedsMoveToParentFolder(MeshFile3);
                break;
            case nameof(MeshFile4) when !HasMoveMeshBeenTouched:
                MoveMeshesToFolder = MoveMeshesToFolder || NeedsMoveToParentFolder(MeshFile4);
                break;

        }

        base.OnPropertyChanged(e);
    }
    public Dictionary<string, bool> GetMeshFileData()
    {
        Dictionary<string, bool> ret = [];
        if (!string.IsNullOrEmpty(MeshFile1))
        {
            ret[MeshFile1] = MeshFile1UseAppearances;
        }

        if (!string.IsNullOrEmpty(MeshFile2))
        {
            ret[MeshFile2] = MeshFile2UseAppearances;
        }

        if (!string.IsNullOrEmpty(MeshFile3))
        {
            ret[MeshFile3] = MeshFile3UseAppearances;
        }

        if (!string.IsNullOrEmpty(MeshFile4))
        {
            ret[MeshFile4] = MeshFile4UseAppearances;
        }

        return ret;
    }
}
