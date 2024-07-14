using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Xml.Serialization;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using WolvenKit.App.Interaction;
using WolvenKit.App.Services;
using WolvenKit.Common;
using WolvenKit.Common.Model;
using WolvenKit.Core.Extensions;
using WolvenKit.RED4.Archive;
using WolvenKit.RED4.CR2W;

namespace WolvenKit.App.ViewModels.Dialogs;

public partial class NewFileViewModel : DialogViewModel
{

    public delegate Task ReturnHandler(NewFileViewModel? file);
    public ReturnHandler? FileHandler;
    private readonly IProjectManager _projectManager;

    [ObservableProperty] private bool _requiresFilePath;

    public NewFileViewModel(IProjectManager projectManager)
    {
        _projectManager = projectManager;

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
            Console.WriteLine(e);
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
        WhyNotCreate = "";

        if (SelectedFile is null || value is null)
        {
            return;
        }

        if (value.Contains(Path.PathSeparator))
        {
            FullPath = value;
        }
        else
        {
            FullPath = Path.Combine(GetDefaultDir(SelectedFile.Type), value);
        }

        if (File.Exists(FullPath) && !Directory.Exists(FullPath))
        {
            WhyNotCreate = "Filename already in use";
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

        switch (SelectedFile?.Type)
        {
            case EWolvenKitFile.Complex_NPV:
            case EWolvenKitFile.Complex_XL_Control:
            case EWolvenKitFile.Complex_XL_Item:
                RequiresFilePath = false;
                break;
            case null:
            case EWolvenKitFile.Cr2w:
            case EWolvenKitFile.TweakXl:
            case EWolvenKitFile.ArchiveXl:
            case EWolvenKitFile.WScript:
            case EWolvenKitFile.RedScript:
            case EWolvenKitFile.CETLua:
            default:
                RequiresFilePath = true;
                break;
        }

        if (!RequiresFilePath)
        {
            FileName = null;
            return;
        }

        FileName = SelectedFile?.Type switch
        {
            EWolvenKitFile.TweakXl => Path.Combine("r6", "tweaks", project.Name, $"untitled.{value.Extension.NotNull().ToLower()}"),
            EWolvenKitFile.RedScript => Path.Combine("r6", "scripts", project.Name, $"untitled.{value.Extension.NotNull().ToLower()}"),
            EWolvenKitFile.ArchiveXl => $"{project.Name}.archive.{value.Extension.NotNull().ToLower()}",
            EWolvenKitFile.CETLua => Path.Combine("bin", "x64", "plugins", "cyber_engine_tweaks", "mods", project.Name, $"init.{value.Extension.NotNull().ToLower()}"),
            _ => $"{value.Name.NotNull().Split(' ').First()}1.{value.Extension.NotNull().ToLower()}",
        };
    }

    [ObservableProperty] private string? _whyNotCreate;

    private string GetDefaultDir(EWolvenKitFile type)
    {
        ArgumentNullException.ThrowIfNull(_projectManager.ActiveProject);

        return type switch
        {
            EWolvenKitFile.TweakXl => _projectManager.ActiveProject.ResourcesDirectory,
            EWolvenKitFile.Cr2w => _projectManager.ActiveProject.ModDirectory,
            EWolvenKitFile.ArchiveXl => _projectManager.ActiveProject.ResourcesDirectory,
            EWolvenKitFile.RedScript => _projectManager.ActiveProject.ResourcesDirectory,
            EWolvenKitFile.CETLua => _projectManager.ActiveProject.ResourcesDirectory,
            EWolvenKitFile.WScript => throw new NotImplementedException(),
            // Will be handled by subsequent dialogue
            EWolvenKitFile.Complex_NPV => "",
            EWolvenKitFile.Complex_XL_Control => "",
            EWolvenKitFile.Complex_XL_Item => "",
            
            _ => throw new ArgumentOutOfRangeException(nameof(type)),
        };


    }

    private bool CanExecuteOk() => !IsCreating &&
                                   (!RequiresFilePath ||
                                    (FileName is not null && !string.IsNullOrEmpty(FileName) && !File.Exists(FullPath)));

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
