using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Xml.Serialization;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using WolvenKit.App.Services;
using WolvenKit.Common;
using WolvenKit.Common.Model;
using WolvenKit.Common.Services;
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
    private readonly RedTypeTemplateService _redTypeTemplateService;

    public NewFileViewModel(
        IProjectManager projectManager,
        ISettingsManager settingsManager,
        ILoggerService loggerService,
        RedTypeTemplateService redTypeTemplateService
    )
    {
        _projectManager = projectManager;
        _loggerService = loggerService;
        _settingsManager = settingsManager;
        _redTypeTemplateService = redTypeTemplateService;

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

            CurrentRedTypeTemplates = new();
            CurrentRedTypeTemplates.GroupDescriptions.Add(new PropertyGroupDescription(nameof(RedTypeTemplate.Type)));
            CurrentRedTypeTemplates.SortDescriptions.Add(new SortDescription(nameof(RedTypeTemplate.Name), ListSortDirection.Ascending));
            CurrentRedTypeTemplates.SortDescriptions.Add(new SortDescription(nameof(RedTypeTemplate.Type), ListSortDirection.Ascending));

            foreach (ERedExtension ext in Enum.GetValues(typeof(ERedExtension)))
            {
                var c = CommonFunctions.GetResourceClassesFromExtension(ext);
                if (c is null)
                {
                    continue;
                }

                resourceFiles.Add(new AddFileModel(c, $"A .{ext} File", ext.ToString(), EWolvenKitFile.Cr2w, "", new List<RedTypeTemplate>()));
            }

            var ordered = newdef.Categories.First(x => x.Name == "CR2W Files").Files.NotNull().OrderBy(x => x.Name).ToList();
            newdef.Categories.First(x => x.Name == "CR2W Files").Files = ordered;
            Categories = new ObservableCollection<FileCategoryModel>(newdef.Categories);
            IndexRedTypeTemplates();

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
    private CollectionViewSource? _currentRedTypeTemplates;

    [ObservableProperty]
    private RedTypeTemplate? _selectedRedTypeTemplate;

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

        if (CurrentRedTypeTemplates is not null)
        {
            CurrentRedTypeTemplates.Source = SelectedFile?.RedTypeTemplates;
            SelectedRedTypeTemplate = GetInitialTemplateForSelectedFile();
            CurrentRedTypeTemplates.View.Refresh();
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
        _projectManager.ActiveProject!.GetResourceTweakDirectory(_settingsManager.UseAuthorNameAsSubfolder);

    private string GetScriptDir() =>
        _projectManager.ActiveProject!.GetResourceScriptsDirectory(_settingsManager.UseAuthorNameAsSubfolder);

    private string GetCetDir() => _projectManager.ActiveProject!.GetResourceCETDirectory();

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

    [RelayCommand]
    private async Task Refresh()
    {
        await Task.Run(_redTypeTemplateService.LoadTemplates);
        IndexRedTypeTemplates();
        SelectedRedTypeTemplate = GetInitialTemplateForSelectedFile();
        CurrentRedTypeTemplates?.View.Refresh();
    }

    private void IndexRedTypeTemplates()
    {
        foreach (var fileModel in Categories.First(x => x.Name == "CR2W Files").Files.NotNull())
        {
            var rootChunkType = RedTypeTemplateService.ParseType(fileModel.Name ?? "");
            if (rootChunkType is null)
            {
                continue;
            }

            fileModel.RedTypeTemplates ??= new List<RedTypeTemplate>();

            fileModel.RedTypeTemplates.Clear();
            fileModel.RedTypeTemplates.Add(new RedTypeTemplate("No Template", RedTypeTemplateType.Raw));
            fileModel.RedTypeTemplates.AddRange(_redTypeTemplateService.SystemTemplates.Where(te => te.Type == rootChunkType).Select(t => new RedTypeTemplate(t.Name, RedTypeTemplateType.System)));
            fileModel.RedTypeTemplates.AddRange(_redTypeTemplateService.UserTemplates.Where(te => te.Type == rootChunkType).Select(t => new RedTypeTemplate(t.Name, RedTypeTemplateType.User)));
        }
    }

    private RedTypeTemplate? GetInitialTemplateForSelectedFile()
    {
        if (SelectedFile is null)
        {
            return null;
        }

        var userDefault =
            SelectedFile.RedTypeTemplates?.FirstOrDefault(rtt =>
                rtt.Name == "default" && rtt.Type == RedTypeTemplateType.User);
        if (userDefault is not null)
        {
            return userDefault;
        }

        var systemDefault =
            SelectedFile.RedTypeTemplates?.FirstOrDefault(rtt =>
                rtt.Name == "default" && rtt.Type == RedTypeTemplateType.System);
        if (systemDefault is not null)
        {
            return systemDefault;
        }

        return SelectedFile.RedTypeTemplates?.FirstOrDefault(rtt => rtt.Type == RedTypeTemplateType.Raw);
    }
}
