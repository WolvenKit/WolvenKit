using System;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using WolvenKit.App.Helpers;

namespace WolvenKit.App.ViewModels.Dialogs;

public partial class ProjectWizardViewModel : DialogViewModel
{
    #region Fields

    public delegate Task ReturnHandler(ProjectWizardViewModel? project);
    public ReturnHandler? FileHandler;

    public const string WitcherGameName = "Witcher 3";
    public const string CyberpunkGameName = "Cyberpunk 2077";

    #endregion Fields

    #region Constructors

    public ProjectWizardViewModel()
    {
        Title = "Project Wizard";

        _projectType = new ObservableCollection<string> { "Cyberpunk 2077" };
    }

    #endregion Constructors

    #region Properties

    public string Title { get; set; }

    [NotNull]
    [ObservableProperty] private string? _projectName = null!;
    [NotNull]
    [ObservableProperty] private string? _projectPath = null!;
    [ObservableProperty] private string? _author;
    [ObservableProperty] private string? _email;
    [ObservableProperty] private string? _version;
    [ObservableProperty] private ObservableCollection<string> _projectType = new();


    /// <summary>
    /// Gets/Sets if all the fields are valid.
    /// </summary>
    [ObservableProperty]
    [NotifyCanExecuteChangedFor(nameof(OkCommand))]
    private bool _allFieldsValid;

    ///// <summary>
    ///// Gets/Sets the author's profile image brush.
    ///// </summary>
    //public ImageBrush ProfileImageBrush { get; set; }

    ///// <summary>
    ///// Gets/Sets the author's profile image path.
    ///// </summary>
    //public string ProfileImageBrushPath { get; set; }

    #endregion Properties


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

    private bool CanExecuteOk() => AllFieldsValid;
    [RelayCommand]
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
