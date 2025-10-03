using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using CommunityToolkit.Mvvm.ComponentModel;
using WolvenKit.App.Extensions;
using WolvenKit.App.Models.ProjectManagement.Project;
using WolvenKit.Interfaces.Extensions;

namespace WolvenKit.App.ViewModels.Dialogs;

public partial class AddItemsToStoreDialogViewModel : ObservableObject
{
    private readonly Cp77Project _project;

    [ObservableProperty] private List<string> _itemCodes = [];

    [ObservableProperty] private string _redsPath = string.Empty;
    [ObservableProperty] private string _yamlPath = string.Empty;

    [ObservableProperty] private bool _rememberValues;

    [ObservableProperty] private bool _isFinishEnabled;

    [ObservableProperty] private Dictionary<string, string> _yamlFiles = [];
    [ObservableProperty] private Dictionary<string, string> _redsFiles = [];

    public AddItemsToStoreDialogViewModel(Cp77Project project, bool rememberValues, string prevYamlPath,
        string prevRedsPath)
    {
        _project = project;
        RememberValues = rememberValues;

        var yamlFiles = new Dictionary<string, string> { { "", "" } };
        yamlFiles.AddRange(project.ResourceFiles.Where(f => f.HasFileExtension("yaml"))
            .ToDictionary(f => f, f => f.Replace(project.ModDirectory, "")));

        YamlFiles = yamlFiles;

        if (rememberValues && YamlFiles.ContainsValue(prevYamlPath))
        {
            YamlPath = prevYamlPath;
        }
        else if (YamlFiles.Count == 2)
        {
            YamlPath = YamlFiles.Last().Value;
        }

        var redsFiles = new Dictionary<string, string> { { "", "" } };
        redsFiles.AddRange(project.ResourceFiles.Where(f => f.HasFileExtension("reds"))
            .ToDictionary(f => f, f => f.Replace(project.ModDirectory, "")));

        RedsFiles = redsFiles;

        if (rememberValues && RedsFiles.ContainsValue(prevRedsPath))
        {
            RedsPath = prevRedsPath;
        }
        else if (RedsFiles.Count == 2)
        {
            RedsPath = RedsFiles.Last().Value;
        }
    }

    public bool CanSave() =>
        ItemCodes.Count > 0 && !(string.IsNullOrEmpty(YamlPath) && string.IsNullOrEmpty(RedsPath));
}
