using System.Collections.Generic;
using System.IO;
using System.Linq;
using CommunityToolkit.Mvvm.ComponentModel;
using WolvenKit.App.Models.ProjectManagement.Project;
using WolvenKit.App.Services;

namespace WolvenKit.App.ViewModels.Dialogs;

public partial class AddInkatlasDialogViewModel : ObservableObject
{
    public AddInkatlasDialogViewModel(Cp77Project project) => ProjectFolders =
        project.ModFiles // get all folders in mod files
            .Select(Path.GetDirectoryName)
            .Where(f => f is not null && f != project.ModDirectory &&
                        Directory.Exists(Path.Combine(project.ModDirectory, f)))
            .Select(f => f!)
            .Distinct()
            .ToDictionary<string, string>(x => x);

    [ObservableProperty] private Dictionary<string, string> _projectFolders;

    /// <summary>
    /// Remember the last selection
    /// </summary>
    [ObservableProperty] private bool _rememberValues = false;

    /// <summary>
    /// Relative path to inkatlas folder
    /// </summary>
    [ObservableProperty] private string _relativePath = "";

    /// <summary>
    /// name for inkatlas file
    /// </summary>
    [ObservableProperty] private string _inkatlasFileName = "inkatlas";

    /// <summary>
    /// Tile width
    /// </summary>
    [ObservableProperty] private string _tileWidth = "0";

    /// <summary>
    /// Tile height
    /// </summary>
    [ObservableProperty] private string _tileHeight = "0";

    /// <summary>
    /// Source directory for raw png files
    /// </summary>
    [ObservableProperty] private string _pngSourceDir = "";
}