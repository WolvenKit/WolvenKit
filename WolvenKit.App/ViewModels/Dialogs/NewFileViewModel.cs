using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Reactive;
using System.Reflection;
using System.Threading.Tasks;
using System.Xml.Serialization;
using CommunityToolkit.Mvvm.ComponentModel;
using ReactiveUI;
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

    public NewFileViewModel(IProjectManager projectManager)
    {
        _projectManager = projectManager;


        OkCommand = ReactiveCommand.Create(() =>
        {
            IsCreating = true;
            FileHandler?.Invoke(this);
        }, this.WhenAnyValue(
            x => x.FileName, x => x.FullPath, x => x.IsCreating,
            (file, path, isCreating) =>
                !isCreating &&
                file is not null &&
                !string.IsNullOrEmpty(file) &&
                !File.Exists(path)));

#pragma warning disable IDE0053 // Use expression body for lambda expressions
        CancelCommand = ReactiveCommand.Create(() => { FileHandler?.Invoke(null); });
#pragma warning restore IDE0053 // Use expression body for lambda expressions

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


        this.WhenAnyValue(x => x.SelectedFile)
            .WhereNotNull()
            .Subscribe(x =>
            {
                var project = _projectManager.ActiveProject;
                if (project is null)
                {
                    return;
                }

                var sep = Path.DirectorySeparatorChar;
#pragma warning disable IDE0072 // Add missing cases
                FileName = SelectedFile?.Type switch
                {
                    EWolvenKitFile.RedScript => $"r6{sep}scripts{sep}{project.Name}{sep}untitled.{x.Extension.ToLower()}",
                    EWolvenKitFile.CETLua => $"bin{sep}x64{sep}plugins{sep}cyber_engine_tweaks{sep}mods{sep}{project.Name}{sep}init.{x.Extension.ToLower()}",
                    _ => x is not null ? $"{x.Name.Split(' ').First()}1.{x.Extension.ToLower()}" : null,
                };
#pragma warning restore IDE0072 // Add missing cases
            });
        this.WhenAnyValue(x => x.FileName)
            .Subscribe(x =>
            {
                if (SelectedFile is not null && x is not null)
                {
                    FullPath = Path.Combine(GetDefaultDir(SelectedFile.Type), x);
                    WhyNotCreate = File.Exists(FullPath) ? "Filename already in use" : "";
                }
                else
                {
                    WhyNotCreate = "";
                }
            });

    }

    [ObservableProperty] private string? _text;

    [ObservableProperty] private bool _isCreating;

    [ObservableProperty] private string? _fileName;
    [ObservableProperty] private string? _fullPath;

    public string Title { get; set; }

    [ObservableProperty] private ObservableCollection<FileCategoryModel> _categories = new();

    [ObservableProperty] private FileCategoryModel? _selectedCategory;

    [ObservableProperty] private AddFileModel? _selectedFile;

    public override ReactiveCommand<Unit, Unit> OkCommand { get; }
    public override ReactiveCommand<Unit, Unit> CancelCommand { get; }
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
            _ => throw new ArgumentOutOfRangeException(nameof(type)),
        };


    }
}
