using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using CommunityToolkit.Mvvm.ComponentModel;
using WolvenKit.App.Models.ProjectManagement.Project;
using WolvenKit.Interfaces.Extensions;

namespace WolvenKit.App.ViewModels.Dialogs;

public partial class AddPropFileDialogViewModel : ObservableObject
{
    public AddPropFileDialogViewModel(Cp77Project project)
    {
        ProjectFolders = project.GetAllFolders(project.ModDirectory).ToDictionary<string, string>(x => x);
        ProjectMeshes = project.ModFiles.Where(f => f.HasFileExtension(".mesh")).ToDictionary<string, string>(x => x);
        PropName = "";
        Appearances = [];
    }

    protected override void OnPropertyChanged(PropertyChangedEventArgs e)
    {
        switch (e.PropertyName)
        {
            case nameof(ParentFolder):
                ParentFolder = ParentFolder.ToFilePath();
                break;
        }

        base.OnPropertyChanged(e);
    }

    [ObservableProperty] private Dictionary<string, string> _projectFolders;

    [ObservableProperty] private Dictionary<string, string> _projectMeshes;

    /// <summary>
    /// Remember the last selection
    /// </summary>
    [ObservableProperty] private bool _rememberValues = true;

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
    [ObservableProperty] private bool _meshFile1UseAppearances = true;

    [ObservableProperty] private string _meshFile2 = "";
    [ObservableProperty] private bool _meshFile2UseAppearances = false;

    [ObservableProperty] private string _meshFile3 = "";
    [ObservableProperty] private bool _meshFile3UseAppearances = false;

    [ObservableProperty] private string _meshFile4 = "";
    [ObservableProperty] private bool _meshFile4UseAppearances = false;

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
