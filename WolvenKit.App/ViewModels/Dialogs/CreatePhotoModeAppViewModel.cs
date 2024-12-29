using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using CommunityToolkit.Mvvm.ComponentModel;
using WolvenKit.App.Extensions;
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

    public CreatePhotoModeAppViewModel(Cp77Project activeProject, ISettingsManager settingsManager)
    {
        _activeProject = activeProject;
        _settingsManager = settingsManager;
        
        PhotomodeAppOptions.AddRange<string>(
            activeProject.ModFiles
                .Where(fp => fp.EndsWith(".app"))
        );

        PhotomodeEntOptions.AddRange<string>(
            activeProject.ModFiles
                .Where(fp => fp.EndsWith(".ent"))
        );
    }

    public bool IsAppNameTouched { get; set; }
    public bool IsEntNameTouched { get; set; }
    public bool IsInkatlasNameTouched { get; set; }
    public bool IsJsonNameTouched { get; set; }
    public bool IsYamlNameTouched { get; set; }
    public bool IsXlNameTouched { get; set; }
    public bool IsPhotoModeDirectoryTouched { get; set; }

    public void AutoSetValues()
    {
        // Dialogue can't even be shown if modder name is not set
        var photomodeDirectory = Path.GetDirectoryName(SelectedEnt) ??
                                 Path.GetDirectoryName(SelectedApp) ??
                                 _settingsManager.ModderName!;

        if (string.IsNullOrEmpty(PhotomodeRelativeFolder) || !IsPhotoModeDirectoryTouched)
        {
            if (!photomodeDirectory.Contains(s_photomodeSubDir))
            {
                photomodeDirectory = Path.Join(photomodeDirectory, s_photomodeSubDir);
            }

            PhotomodeRelativeFolder = photomodeDirectory;
        }

        if (string.IsNullOrEmpty(SelectedApp))
        {
            SelectedApp = PhotomodeAppOptions.FirstOrDefault(f => f.Contains(s_photomodeSubDir)) ??
                          PhotomodeAppOptions.FirstOrDefault() ?? "";
        }

        if (string.IsNullOrEmpty(SelectedEnt))
        {
            SelectedEnt = PhotomodeEntOptions.FirstOrDefault(f => f.Contains(s_photomodeSubDir)) ??
                          PhotomodeEntOptions.FirstOrDefault() ?? "";
        }

        if (!IsAppNameTouched && string.IsNullOrEmpty(AppFileName) && !string.IsNullOrEmpty(SelectedApp))
        {
            var fileName = Path.GetFileNameWithoutExtension(SelectedApp);
            var suffix = fileName.Contains("photomode") ? "" : "_photomode";
            AppFileName = $"{fileName}{suffix}.app";
        }

        if (!IsEntNameTouched && string.IsNullOrEmpty(EntFileName) && !string.IsNullOrEmpty(SelectedEnt))
        {
            var fileName = Path.GetFileNameWithoutExtension(SelectedEnt);
            var suffix = fileName.Contains("photomode") ? "" : "_photomode";
            EntFileName = $"{fileName}{suffix}.ent";
        }

        if (!IsAppNameTouched && Path.Join(PhotomodeRelativeFolder, AppFileName) == SelectedApp)
        {
            IsCreateAppFile = false;
        }

        if (!IsEntNameTouched && Path.Join(PhotomodeRelativeFolder, EntFileName) == SelectedEnt)
        {
            IsCreateEntFile = false;
        }

        SetJsonFileName();

        SetInkatlasFileName();

        SetYamlFileName();

        SetXlFileName();
    }

    private void SetXlFileName()
    {
        if (IsXlNameTouched)
        {
            return;
        }

        var xlFiles = _activeProject.ResourceFiles.Where(fp => fp.EndsWith(".xl")).ToList();

        if (xlFiles.Count == 1)
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
        if (IsYamlNameTouched)
        {
            return;
        }

        var yamlFiles = _activeProject.ResourceFiles.Where(fp => fp.EndsWith(".yaml")).ToList();

        if (yamlFiles.Count == 1)
        {
            IsCreateYamlFile = false;
            YamlFileName = yamlFiles.First();
        }
        else if (!string.IsNullOrEmpty(NpcName) && string.IsNullOrEmpty(YamlFileName))
        {
            YamlFileName = $"{NpcName.ToFileName()}_npc_photomode.yaml";
            IsCreateYamlFile =
                !File.Exists(Path.Join(_activeProject.ModDirectory, PhotomodeRelativeFolder, YamlFileName));
        }
    }

    private void SetInkatlasFileName()
    {
        if (IsInkatlasNameTouched)
        {
            return;
        }

        var inkatlasFiles = _activeProject.ModFiles.Where(fp => fp.EndsWith(".inkatlas")).ToList();

        if (inkatlasFiles.Count == 1)
        {
            IsCreateInkatlasFile = false;
            InkatlasFileName = inkatlasFiles.First();
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
        if (IsJsonNameTouched)
        {
            return;
        }

        var jsonFiles = _activeProject.ModFiles.Where(fp => fp.EndsWith(".json")).ToList();

        if (jsonFiles.Count == 1)
        {
            IsCreateJsonFile = false;
            JsonFileName = jsonFiles.First();
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
        SetSaveButtonState();
    }

    private void SetSaveButtonState()
    {
        if (string.IsNullOrEmpty(SelectedApp) || string.IsNullOrEmpty(SelectedEnt) ||
            string.IsNullOrEmpty(NpcName) || NpcName.Length < 4)
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
    public void PreselectAppFromNpcName(string boxText)
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

        var photomodeFolderPath = entPath ?? appPath;
        if (IsPhotoModeDirectoryTouched || string.IsNullOrEmpty(photomodeFolderPath) ||
            Path.GetDirectoryName(photomodeFolderPath) is not string dir)
        {
            return;
        }

        if (!dir.Contains(s_photomodeSubDir))
        {
            dir = Path.Join(dir, s_photomodeSubDir);
        }

        PhotomodeRelativeFolder = dir;
    }
}