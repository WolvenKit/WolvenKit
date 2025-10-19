using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
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
        ExistingFiles = project.ModFiles.Where(f => f.HasFileExtension(".inkatlas"))
            .ToDictionary<string, string>(x => x);
        InkatlasFileName = $"{project.Name}_icons";

        IconFileSizes = new Dictionary<string, (int, int)>()
        {
            { "Clothing item (160x160)", (160, 160) },
            { "Weapon small (160x80)", (160, 80) },
            { "Weapon (160x120)", (160, 80) },
            { "NPV", (200, 200) },
        };
    }

    protected override void OnPropertyChanged(PropertyChangedEventArgs e)
    {
        switch (e.PropertyName)
        {
            case nameof(RelativePath):
                RelativePath = RelativePath.ToFilePath();
                break;
            case nameof(InkatlasFileName):
                InkatlasFileName = InkatlasFileName.ToFileName().Replace(".inkatlas", "");
                break;
            case nameof(ExistingFile) when !string.IsNullOrEmpty(ExistingFile):

                InkatlasFileName = Path.GetFileName(ExistingFile).ToFileName().Replace(".inkatlas", "");
                if (Path.GetDirectoryName(ExistingFile) is string path)
                {
                    RelativePath = path.ToFileName();
                }

                break;
        }

        base.OnPropertyChanged(e);
    }

    [ObservableProperty] private Dictionary<string, string> _existingFiles;

    [ObservableProperty] private Dictionary<string, string> _projectFolders;

    [ObservableProperty] private Dictionary<string, (int, int)> _iconFileSizes;

    /// <summary>
    /// Remember the last selection
    /// </summary>
    [ObservableProperty] private bool _rememberValues = true;

    /// <summary>
    /// Relative path to inkatlas folder
    /// </summary>
    [ObservableProperty] private string _existingFile = "";

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
