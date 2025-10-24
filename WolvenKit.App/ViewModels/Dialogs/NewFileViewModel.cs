using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Xml.Serialization;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using WolvenKit.App.Services;
using WolvenKit.Common;
using WolvenKit.Common.Model;
using WolvenKit.Core.Extensions;
using WolvenKit.Core.Interfaces;
using WolvenKit.RED4.Archive;
using WolvenKit.RED4.CR2W;

namespace WolvenKit.App.ViewModels.Dialogs;

public partial class NewFileViewModel : DialogViewModel
{

    public delegate Task ReturnHandler(NewFileViewModel? file);
    public ReturnHandler? FileHandler;
    private readonly IProjectManager _projectManager;
    private readonly ISettingsManager _settingsManager;
    private readonly ILoggerService _loggerService;

    public NewFileViewModel(
        IProjectManager projectManager,
        ISettingsManager settingsManager,
        ILoggerService loggerService
    )
    {
        _projectManager = projectManager;
        _loggerService = loggerService;
        _settingsManager = settingsManager;

        Title = "Create new file";

        try
        {
            using var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(@"WolvenKit.App.Resources.WolvenKitFileDefinitions.xml").NotNull();

            XmlSerializer serializer = new(typeof(WolvenKitFileDefinitions));
            if (serializer.Deserialize(stream) is not WolvenKitFileDefinitions newdef)
            {
                throw new ArgumentNullException("WolvenKitFileDefinitions");
            }

            var resourceFiles = newdef.Categories.First(x => x.Name == "CR2W Files").Files.NotNull();

            foreach (ERedExtension ext in Enum.GetValues(typeof(ERedExtension)))
            {
                var c = CommonFunctions.GetResourceClassesFromExtension(ext);
                if (c is not null)
                {
                    resourceFiles.Add(new AddFileModel(c, $"A .{ext} File", ext.ToString(), EWolvenKitFile.Cr2w, ""));
                }
            }

            var ordered = newdef.Categories.First(x => x.Name == "CR2W Files").Files.NotNull().OrderBy(x => x.Name).ToList();
            newdef.Categories.First(x => x.Name == "CR2W Files").Files = ordered;
            Categories = new ObservableCollection<FileCategoryModel>(newdef.Categories);

            SelectedCategory = Categories.FirstOrDefault();
        }
        catch (Exception e)
        {
            _loggerService.Error(e);
            throw;
        }
    }

    public string Title { get; set; }

    [ObservableProperty] private string? _text;

    [ObservableProperty]
    [NotifyCanExecuteChangedFor(nameof(OkCommand))]
    private bool _isCreating;

    [ObservableProperty]
    [NotifyCanExecuteChangedFor(nameof(OkCommand))]
    private string? _fileName;
    partial void OnFileNameChanged(string? value)
    {
        if (SelectedFile is not null && value is not null)
        {
            FullPath = Path.Combine(GetDefaultDir(SelectedFile.Type), value);
            WhyNotCreate = File.Exists(FullPath) ? "Filename already in use" : "";
        }
        else
        {
            WhyNotCreate = "";
        }
    }

    [ObservableProperty]
    [NotifyCanExecuteChangedFor(nameof(OkCommand))]
    private string? _fullPath;

    [ObservableProperty] private ObservableCollection<FileCategoryModel> _categories = new();

    [ObservableProperty] private FileCategoryModel? _selectedCategory;

    [ObservableProperty] private AddFileModel? _selectedFile;
    partial void OnSelectedFileChanged(AddFileModel? value)
    {
        if (value is null)
        {
            return;
        }

        var project = _projectManager.ActiveProject;
        if (project is null)
        {
            return;
        }

#pragma warning disable IDE0072 // Add missing cases
        FileName = SelectedFile?.Type switch
        {
            EWolvenKitFile.TweakXl => Path.Combine(GetTweakDir(), $"untitled.{value.Extension.NotNull().ToLower()}"),
            EWolvenKitFile.RedScript => Path.Combine(GetScriptDir(), $"untitled.{value.Extension.NotNull().ToLower()}"),
            EWolvenKitFile.ArchiveXl => $"{project.Name}.{value.Extension.NotNull().ToLower()}",
            EWolvenKitFile.CETLua => Path.Combine(GetCetDir(), $"init.{value.Extension.NotNull().ToLower()}"),
            _ => $"{value.Name.NotNull().Split(' ').First()}1.{value.Extension.NotNull().ToLower()}",
        };
#pragma warning restore IDE0072 // Add missing cases
    }

    [ObservableProperty] private string? _whyNotCreate;

    private string GetTweakDir() =>
        _projectManager.ActiveProject!.GetResourceTweakDirectory(_settingsManager.UseModderNameAsSubfolder);

    private string GetScriptDir() =>
        _projectManager.ActiveProject!.GetResourceScriptsDirectory(_settingsManager.UseModderNameAsSubfolder);

    private string GetCetDir() =>
        _projectManager.ActiveProject!.GetResourceCETDirectory(false);

    private string GetDefaultDir(EWolvenKitFile type)
    {
        ArgumentNullException.ThrowIfNull(_projectManager.ActiveProject);

        return type switch
        {
            EWolvenKitFile.TweakXl => GetTweakDir(),
            EWolvenKitFile.Cr2w => _projectManager.ActiveProject.ModDirectory,
            EWolvenKitFile.ArchiveXl => _projectManager.ActiveProject.ResourcesDirectory,
            EWolvenKitFile.RedScript => GetScriptDir(),
            EWolvenKitFile.CETLua => GetCetDir(),
            EWolvenKitFile.WScript => throw new NotImplementedException(),
            EWolvenKitFile.Other => throw new NotImplementedException(),
            _ => throw new ArgumentOutOfRangeException(nameof(type)),
        };
    }

    private bool CanExecuteOk() => !IsCreating && FileName is not null && !string.IsNullOrEmpty(FileName) && !File.Exists(FullPath);

    [RelayCommand(CanExecute = nameof(CanExecuteOk))]
    private void Ok()
    {
        IsCreating = true;
        FileHandler?.Invoke(this);
    }

    [RelayCommand]
    private void Cancel()
    {
        FileHandler?.Invoke(null);
    }

}
