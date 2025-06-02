using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using CommunityToolkit.Mvvm.ComponentModel;
using WolvenKit.App.Models.ProjectManagement.Project;
using WolvenKit.Interfaces.Extensions;

namespace WolvenKit.App.ViewModels.Dialogs;

public partial class AddInkatlasDialogViewModel : ObservableObject
{
    public AddInkatlasDialogViewModel(Cp77Project project)
    {
        // Dropdown menu should have all folders in mod directory available
        ProjectFolders = project.GetAllFolders(project.ModDirectory).ToDictionary<string, string>(x => x);

        InkatlasFileName = $"{project.Name}_icons";
    }

    protected override void OnPropertyChanged(PropertyChangedEventArgs e)
    {
        switch (e.PropertyName)
        {
            case nameof(RelativePath):
                RelativePath = RelativePath.ToFileName();
                break;
            case nameof(InkatlasFileName):
                InkatlasFileName = InkatlasFileName.ToFileName().Replace(".inkatlas", "");
                break;
        }

        base.OnPropertyChanged(e);
    }

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
    [ObservableProperty] private string _inkatlasFileName = "";

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