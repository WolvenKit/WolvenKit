using System;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using WolvenKit.App.Helpers;
using WolvenKit.App.Services;

namespace WolvenKit.App.ViewModels.Dialogs;

public partial class ProjectWizardViewModel : DialogViewModel
{
    #region Fields

    private readonly ISettingsManager _settingsManager;

    public delegate Task ReturnHandler(ProjectWizardViewModel? project);
    public ReturnHandler? FileHandler;

    public const string WitcherGameName = "Witcher 3";
    public const string CyberpunkGameName = "Cyberpunk 2077";

    #endregion Fields

    #region Constructors

    public ProjectWizardViewModel(ISettingsManager settingsManager)
    {
        _settingsManager = settingsManager;

        Title = "Project Wizard";

        _projectType = new ObservableCollection<string> { "Cyberpunk 2077" };

        // project path
        _projectPath = _settingsManager.LastUsedProjectPath ?? Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
    }

    #endregion Constructors

    #region Properties

    public string Title { get; set; }

    [NotNull]
    [ObservableProperty]
    [NotifyCanExecuteChangedFor(nameof(OkCommand))]
    private string? _projectName = null!;
    
    [NotNull]
    [ObservableProperty]
    [NotifyCanExecuteChangedFor(nameof(OkCommand))]
    private string? _projectPath = null!;
    
    [ObservableProperty] private string? _author;
    
    [ObservableProperty] private string? _email;
    
    [ObservableProperty] private string? _version;
    
    [ObservableProperty] private ObservableCollection<string> _projectType = new();

    #endregion Properties

    partial void OnProjectPathChanged(string? value)
    {
        _settingsManager.LastUsedProjectPath = value;
        _settingsManager.Save();
    }

    [ObservableProperty] private string? _whyNotCreate;

    [RelayCommand]
    private void OpenProjectPath()
    {
        var dlg = new FolderPicker
        {
            ForceFileSystem = true,
            Title = "Select the folder to create the project in"
        };

        if (dlg.ShowDialog() != true)
        {
            return;
        }

        var result = dlg.ResultPath;
        if (string.IsNullOrEmpty(result))
        {
            return;
        }

        ProjectPath = result;
    }

    private bool CanExecuteOk() =>
        !string.IsNullOrEmpty(ProjectName) && 
        !string.IsNullOrEmpty(ProjectPath) &&
        Directory.Exists(ProjectPath) &&
        !Directory.Exists(Path.Combine(ProjectPath, ProjectName));

    [RelayCommand(CanExecute = nameof(CanExecuteOk))]
    private void Ok()
    {
        FileHandler?.Invoke(this);
    }

    [RelayCommand]
    private void Cancel()
    {
        FileHandler?.Invoke(null);
    }

}
