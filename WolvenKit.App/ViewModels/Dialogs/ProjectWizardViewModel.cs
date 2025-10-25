using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using WolvenKit.App.Helpers;
using WolvenKit.App.Services;
using WolvenKit.Interfaces.Extensions;

namespace WolvenKit.App.ViewModels.Dialogs;

public partial class ProjectWizardViewModel : DialogViewModel, INotifyDataErrorInfo
{
    #region Fields

    private readonly Dictionary<string, List<string>> _errorsByPropertyName = new();

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

        _projectType = ["Cyberpunk 2077"];

        string? lastProjectPath;
        if (_settingsManager.LastUsedProjectPath is not null &&
            Path.GetDirectoryName(Path.GetDirectoryName(_settingsManager.LastUsedProjectPath)) is string s &&
            Directory.Exists(s))
        {
            lastProjectPath = s;
        }
        else
        {
            lastProjectPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        }
        // project path
        _projectPath = _settingsManager.DefaultProjectPath ?? lastProjectPath;
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
    private string? _modName = null!;

    [NotNull]
    [ObservableProperty]
    [NotifyCanExecuteChangedFor(nameof(OkCommand))]
    private string? _projectPath = null!;

    [ObservableProperty] private string? _author;

    [ObservableProperty] private string? _email;

    [ObservableProperty] private string? _version;

    [ObservableProperty] private ObservableCollection<string> _projectType;

    [ObservableProperty] private string? _whyNotCreate;

    #endregion Properties

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

    private bool CanExecuteOk() => !HasErrors;

    [RelayCommand(CanExecute = nameof(CanExecuteOk))]
    private void Ok()
    {
        _settingsManager.LastUsedProjectPath = ProjectPath;
        _settingsManager.Save();

        FileHandler?.Invoke(this);
    }

    [RelayCommand]
    private void Cancel() => FileHandler?.Invoke(null);

    partial void OnProjectNameChanged(string? _value) => ValidateProjectName();

    public void ValidateProjectName()
    {
        ClearError(nameof(ProjectName));

        if (string.IsNullOrEmpty(ProjectName))
        {
            AddError(nameof(ProjectName), "Please enter a Project name!");
        }
        else if (!string.IsNullOrEmpty(ProjectPath) && Directory.Exists(Path.Combine(ProjectPath, ProjectName)))
        {
            AddError(nameof(ProjectName), "A project with this name already exists!");
        }
        else if (!ProjectName.ToFileName().Equals(ProjectName, StringComparison.OrdinalIgnoreCase))
        {
            AddError(nameof(ProjectName), "Project name must not contain special characters or spaces!");
        }
    }

    partial void OnModNameChanged(string? value) => ValidateModName();

    public void ValidateModName()
    {
        ClearError(nameof(ModName));

        if (string.IsNullOrEmpty(ModName))
        {
            AddError(nameof(ModName), "Please enter a mod name!");
        }
    }

    partial void OnProjectPathChanged(string? value) => ValidateProjectPath();

    public void ValidateProjectPath()
    {
        ClearError(nameof(ProjectPath));

        if (string.IsNullOrEmpty(ProjectPath))
        {
            AddError(nameof(ProjectPath), "Please enter a path!");
        }
        else if (!Directory.Exists(ProjectPath))
        {
            AddError(nameof(ProjectPath), "Selected path does not exist");
        }
        else if (!ProjectPath.IsSaneFilePath())
        {
            // We're grudgingly okay with spaces. We are not okay with special characters.
            AddError(nameof(ProjectPath), "Please do not use special characters in your project path!");
        }

        ValidateProjectName();
    }

    public void ReadDefaultValuesFromSettings()
    {
        if (string.IsNullOrEmpty(Author))
        {
            Author = _settingsManager.ModderName;
        }

        if (string.IsNullOrEmpty(Email))
        {
            Email = _settingsManager.ModderEmail;
        }
    }

    #region INotifyDataErrorInfo

    private void AddError(string propertyName, string error)
    {
        if (!_errorsByPropertyName.TryGetValue(propertyName, out var errorList))
        {
            errorList = new List<string>();
            _errorsByPropertyName.Add(propertyName, errorList);
        }

        if (!errorList.Contains(error))
        {
            errorList.Add(error);
            ErrorsChanged?.Invoke(this, new DataErrorsChangedEventArgs(propertyName));
        }
    }

    private void ClearError(string propertyName)
    {
        // ReSharper disable once CanSimplifyDictionaryRemovingWithSingleCall
        if (!_errorsByPropertyName.ContainsKey(propertyName))
        {
            return;
        }

        _errorsByPropertyName.Remove(propertyName);
        ErrorsChanged?.Invoke(this, new DataErrorsChangedEventArgs(propertyName));
    }

    public IEnumerable GetErrors(string? propertyName)
    {
        if (!string.IsNullOrEmpty(propertyName) && _errorsByPropertyName.TryGetValue(propertyName, out var errorList))
        {
            return errorList;
        }

        return new List<string>();
    }

    public bool HasErrors => _errorsByPropertyName.Count > 0;

    public event EventHandler<DataErrorsChangedEventArgs>? ErrorsChanged;

    #endregion INotifyDataErrorInfo

    public void SaveAuthorToSettingsIfNeeded()
    {
        if (!string.IsNullOrEmpty(_settingsManager.ModderName) ||
            string.IsNullOrEmpty(Author))
        {
            return;
        }

        _settingsManager.ModderName = Author;
        _settingsManager.Save();
    }
}
