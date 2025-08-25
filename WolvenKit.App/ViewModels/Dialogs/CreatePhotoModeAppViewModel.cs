using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using CommunityToolkit.Mvvm.ComponentModel;
using WolvenKit.App.Extensions;
using WolvenKit.App.Helpers;
using WolvenKit.App.Models.ProjectManagement.Project;
using WolvenKit.App.Services;
using WolvenKit.Interfaces.Extensions;

namespace WolvenKit.App.ViewModels.Dialogs;

/// <summary>
/// Asks user for a component name and a chunk mask
/// </summary>
public partial class CreatePhotoModeAppViewModel : ObservableObject
{
    [ObservableProperty] private string _selectedApp = "";
    [ObservableProperty] private string _selectedEnt = "";
    [ObservableProperty] private string _npcName = "";

    [ObservableProperty] private string _inkatlasFileName = "";
    [ObservableProperty] private string _jsonFileName = "";
    [ObservableProperty] private string _yamlFileName = "";
    [ObservableProperty] private string _xlFileName = "";

    [ObservableProperty] private string _appFileName = "";
    [ObservableProperty] private string _entFileName = "";

    [ObservableProperty] private string _photomodeRelativeFolder = "";

    [ObservableProperty] private PhotomodeBodyGender _selectedBodyGender = PhotomodeBodyGender.Female;

    [ObservableProperty] private bool _isCreateAppFile = true;
    [ObservableProperty] private bool _isCreateEntFile = true;
    [ObservableProperty] private bool _isCreateYamlFile = true;
    [ObservableProperty] private bool _isCreateJsonFile = true;
    [ObservableProperty] private bool _isCreateXlFile = true;
    [ObservableProperty] private bool _isCreateInkatlasFile = true;
    [ObservableProperty] private bool _isOverwrite;

    // enable save button?
    [ObservableProperty] private bool _canSave;

    private static readonly string s_photomodeSubDir =
        $"{Path.DirectorySeparatorChar}photomode{Path.DirectorySeparatorChar}";

    private readonly Cp77Project _activeProject;
    private readonly ISettingsManager _settingsManager;
    private readonly ProjectResourceTools _projectResourceTools;

    public CreatePhotoModeAppViewModel(Cp77Project activeProject, ISettingsManager settingsManager,
        ProjectResourceTools projectResourceTools)
    {
        _activeProject = activeProject;
        _settingsManager = settingsManager;
        _projectResourceTools = projectResourceTools;

        PhotomodeAppOptions.AddRange<string>(
            activeProject.ModFiles
                .Where(fp => fp.EndsWith(".app") && !fp.Contains(s_photomodeSubDir))
        );

        PhotomodeEntOptions.AddRange<string>(
            activeProject.ModFiles
                .Where(fp => fp.EndsWith(".ent") && !fp.Contains(s_photomodeSubDir))
        );

        if (string.IsNullOrEmpty(SelectedApp))
        {
            SelectedApp = PhotomodeAppOptions.FirstOrDefault(f => f.Contains($"{AppFileName}.app")) ??
                          PhotomodeAppOptions.FirstOrDefault() ?? "";
        }

        if (string.IsNullOrEmpty(SelectedEnt))
        {
            SelectedEnt = PhotomodeEntOptions.FirstOrDefault(f => f.Contains($"{EntFileName}.ent")) ??
                          PhotomodeEntOptions.FirstOrDefault() ?? "";
        }

        if (string.IsNullOrEmpty(PhotomodeRelativeFolder) && Directory.GetDirectories(activeProject.ModDirectory)
                .FirstOrDefault(d => d.EndsWith(s_photomodeSubDir)) is string subDir)
        {
            PhotomodeRelativeFolder = subDir;
        }
    }

    public bool IsAppNameTouched { get; set; }
    public bool IsEntNameTouched { get; set; }
    public bool IsInkatlasNameTouched { get; set; }
    public bool IsJsonNameTouched { get; set; }
    public bool IsYamlNameTouched { get; set; }
    public bool IsXlNameTouched { get; set; }
    public bool IsPhotoModeDirectoryTouched { get; set; }

    public bool IsNpcNameTouched { get; set; }

    public void AutoSetValues()
    {
        UpdateAppFileNameAndCheckbox();

        UpdateEntFileNameAndCheckbox();

        UpdateNpcName();

        UpdatePhotoModeDirectory();

        SetJsonFileName();

        SetInkatlasFileName();

        SetYamlFileName();

        SetXlFileName();
    }

    private void UpdateAppFileNameAndCheckbox()
    {
        if ((IsAppNameTouched && !string.IsNullOrEmpty(SelectedApp)) || string.IsNullOrEmpty(SelectedApp))
        {
            return;
        }

        var fileName = Path.GetFileNameWithoutExtension(SelectedApp);
        var suffix = fileName.Contains("photomode") ? "" : "_photomode";
        AppFileName = $"{fileName}{suffix}.app";

        if (Path.Join(PhotomodeRelativeFolder, AppFileName) == SelectedApp)
        {
            IsCreateAppFile = false;
        }
    }

    private void UpdateEntFileNameAndCheckbox()
    {
        if ((IsEntNameTouched && !string.IsNullOrEmpty(SelectedEnt)) || string.IsNullOrEmpty(SelectedEnt))
        {
            return;
        }

        var fileName = Path.GetFileNameWithoutExtension(SelectedEnt);
        var suffix = fileName.Contains("photomode") ? "" : "_photomode";
        EntFileName = $"{fileName}{suffix}.ent";

        if (Path.Join(PhotomodeRelativeFolder, EntFileName) == SelectedEnt)
        {
            IsCreateEntFile = false;
        }
    }

    private void UpdatePhotoModeDirectory()
    {
        if (IsPhotoModeDirectoryTouched)
        {
            return;
        }

        // Dialogue can't even be shown if modder name is not set
        var photomodeDirectory = Path.Join(_settingsManager.ModderName!.ToFileName(), s_photomodeSubDir);
        if (!string.IsNullOrEmpty(NpcName) && !photomodeDirectory.Contains(NpcName.ToFileName()))
        {
            photomodeDirectory = Path.Join(photomodeDirectory, NpcName.ToFileName());
        }

        if (string.IsNullOrEmpty(PhotomodeRelativeFolder) || !IsPhotoModeDirectoryTouched)
        {
            PhotomodeRelativeFolder = photomodeDirectory;
        }
    }

    private void UpdateNpcName()
    {
        if (IsNpcNameTouched && !string.IsNullOrEmpty(NpcName))
        {
            return;
        }

        if (SelectedEnt.Contains("photo"))
        {
            NpcName = Path.GetFileNameWithoutExtension(SelectedEnt).Split("photo").First().ToHumanFriendlyString();
        }
        else if (SelectedApp.Contains("photo"))
        {
            NpcName = Path.GetFileNameWithoutExtension(SelectedApp).Split("photo").First().ToHumanFriendlyString();
        }
        else
        {
            NpcName = _activeProject.ModName.ToHumanFriendlyString();
        }
    }

    private void SetXlFileName()
    {
        if (IsXlNameTouched)
        {
            return;
        }

        var xlFiles = _activeProject.ResourceFiles.Where(fp => fp.EndsWith(".xl")).ToList();

        if (xlFiles.Count == 1 && !IsXlNameTouched)
        {
            XlFileName = xlFiles.First();
            IsCreateXlFile = false;
        }
        else if (string.IsNullOrEmpty(XlFileName))
        {
            XlFileName = $"{_activeProject.ModName.ToFileName()}.archive.xl";
            IsCreateXlFile =
                !File.Exists(Path.Join(_activeProject.ModDirectory, PhotomodeRelativeFolder, XlFileName));
        }
    }

    private void SetYamlFileName()
    {
        var yamlFiles = _activeProject.ResourceFiles.Where(fp => fp.EndsWith(".yaml")).ToList();

        if (yamlFiles.Count == 1 && !IsYamlNameTouched)
        {
            IsCreateYamlFile = false;
            YamlFileName = Path.GetFileName(yamlFiles.First());
        }
        else if (!string.IsNullOrEmpty(NpcName) && string.IsNullOrEmpty(YamlFileName))
        {
            YamlFileName = $"{NpcName.ToFileName()}_npc.yaml";
            IsCreateYamlFile =
                !File.Exists(Path.Join(_activeProject.ModDirectory, PhotomodeRelativeFolder, YamlFileName));
        }
    }

    private void SetInkatlasFileName()
    {

        var inkatlasFiles = _activeProject.ModFiles.Where(fp => fp.EndsWith(".inkatlas")).ToList();

        if (inkatlasFiles.Count == 1 && !IsInkatlasNameTouched)
        {
            IsCreateInkatlasFile = false;
            InkatlasFileName = Path.GetFileName(inkatlasFiles.First());
        }
        else if (!string.IsNullOrEmpty(NpcName) && string.IsNullOrEmpty(InkatlasFileName))
        {
            InkatlasFileName = $"{NpcName.ToFileName()}_icon.inkatlas";
            IsCreateInkatlasFile =
                !File.Exists(Path.Join(_activeProject.ModDirectory, PhotomodeRelativeFolder, InkatlasFileName));
        }
    }

    private void SetJsonFileName()
    {
        if (!string.IsNullOrEmpty(JsonFileName))
        {
            return;
        }

        var jsonFiles = _activeProject.ModFiles.Where(fp => fp.EndsWith(".json")).ToList();

        if (jsonFiles.Count == 1 && !IsJsonNameTouched)
        {
            IsCreateJsonFile = false;
            JsonFileName = Path.GetFileName(jsonFiles.First());
        }
        else if (!string.IsNullOrEmpty(NpcName) && string.IsNullOrEmpty(JsonFileName))
        {
            JsonFileName = $"{NpcName.ToFileName()}_i18n.json";
            IsCreateJsonFile =
                !File.Exists(Path.Join(_activeProject.ModDirectory, PhotomodeRelativeFolder, JsonFileName));
        }
    }

    protected override void OnPropertyChanged(PropertyChangedEventArgs e)
    {
        base.OnPropertyChanged(e);
        switch (e.PropertyName)
        {
            case nameof(SelectedApp):
            case nameof(AppFileName) when string.IsNullOrEmpty(AppFileName):
                UpdateAppFileNameAndCheckbox();
                break;
            case nameof(SelectedEnt):
            case nameof(EntFileName) when string.IsNullOrEmpty(EntFileName):
                UpdateEntFileNameAndCheckbox();
                break;
            case nameof(JsonFileName) when string.IsNullOrEmpty(JsonFileName):
                SetJsonFileName();
                break;
            case nameof(InkatlasFileName) when string.IsNullOrEmpty(InkatlasFileName):
                SetInkatlasFileName();
                break;
            case nameof(IsCreateInkatlasFile) when !IsOverwrite && IsCreateInkatlasFile:
                IsOverwrite =
                    File.Exists(_projectResourceTools.GetAbsolutePath(InkatlasFileName, PhotomodeRelativeFolder));
                break;
            case nameof(IsCreateAppFile) when !IsOverwrite && IsCreateAppFile:
                IsOverwrite = File.Exists(_projectResourceTools.GetAbsolutePath(AppFileName, PhotomodeRelativeFolder));
                break;
            case nameof(IsCreateEntFile) when !IsOverwrite && IsCreateEntFile:
                IsOverwrite = File.Exists(_projectResourceTools.GetAbsolutePath(EntFileName, PhotomodeRelativeFolder));
                break;
            case nameof(IsCreateJsonFile) when !IsOverwrite && IsCreateJsonFile:
                IsOverwrite = File.Exists(_projectResourceTools.GetAbsolutePath(JsonFileName, PhotomodeRelativeFolder));
                break;
            case nameof(IsCreateYamlFile) when !IsOverwrite && IsCreateYamlFile:
                IsOverwrite = File.Exists(_projectResourceTools.GetAbsolutePath(YamlFileName, "", true));
                break;
            case nameof(IsCreateXlFile) when !IsOverwrite && IsCreateXlFile:
                IsOverwrite = File.Exists(_projectResourceTools.GetAbsolutePath(XlFileName));
                break;
        }
        SetSaveButtonState();
    }

    private void SetSaveButtonState()
    {
        if (string.IsNullOrEmpty(SelectedApp) || string.IsNullOrEmpty(SelectedEnt))
        {
            CanSave = false;
            return;
        }

        if (IsCreateAppFile && (string.IsNullOrEmpty(AppFileName) || !AppFileName.EndsWith(".app")))
        {
            CanSave = false;
            return;
        }

        if (IsCreateEntFile && (string.IsNullOrEmpty(EntFileName) || !EntFileName.EndsWith(".ent")))
        {
            CanSave = false;
            return;
        }

        if (IsCreateXlFile && (string.IsNullOrEmpty(XlFileName) || !XlFileName.EndsWith(".xl")))
        {
            CanSave = false;
            return;
        }

        if (IsCreateJsonFile && (string.IsNullOrEmpty(JsonFileName) || !JsonFileName.EndsWith(".json")))
        {
            CanSave = false;
            return;
        }

        if (IsCreateInkatlasFile && (string.IsNullOrEmpty(InkatlasFileName) || !InkatlasFileName.EndsWith(".inkatlas")))
        {
            CanSave = false;
            return;
        }

        // If the yaml value is okay, we can save here
        CanSave = !(IsCreateYamlFile && (string.IsNullOrEmpty(YamlFileName) || !YamlFileName.EndsWith(".yaml")));
    }

    [ObservableProperty] private List<string> _photomodeAppOptions = [];
    [ObservableProperty] private List<string> _photomodeEntOptions = [];

    [ObservableProperty] private List<PhotomodeBodyGender> _bodyGenderOptions =
        Enum.GetValues(typeof(PhotomodeBodyGender)).Cast<PhotomodeBodyGender>().ToList();

    /// <summary>
    /// If the NPC name was changed: Try set selected .app and .ent, if we find one that matches.
    /// AutoSetValues will be called when NPC name is written back
    /// </summary>
    /// <param name="boxText"></param>
    public void PreselectAppAndEntFromNpcName(string boxText)
    {
        var npcNameFileName = boxText.ToFileName();
        var entPath = PhotomodeEntOptions.FirstOrDefault(x => x.Contains(npcNameFileName)) ?? null;
        var appPath = PhotomodeAppOptions.FirstOrDefault(x => x.Contains(npcNameFileName)) ?? null;
        if (!IsEntNameTouched && !string.IsNullOrEmpty(entPath))
        {
            SelectedEnt = entPath;
        }

        if (!IsAppNameTouched && !string.IsNullOrEmpty(appPath))
        {
            SelectedApp = appPath;
        }

        UpdatePhotoModeDirectory();
    }
}
