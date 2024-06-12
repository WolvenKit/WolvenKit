using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using CommunityToolkit.Mvvm.ComponentModel;

namespace WolvenKit.App.Models;
public class LaunchProfile
{
    [Category("Build and Install")]
    [Display(Name = "Create Backup of previous build")]
    public bool CreateBackup { get; set; }


    [Category("Build and Install")]
    [Display(Name = "Create zip file")]
    public bool CreateZipFile { get; set; }

    [Category("Build and Install")]
    [Display(Name = "Install to Game directory")]
    public bool Install { get; set; }
    
    // installsound files
    // install tweak files
    // install script files

    [Category("Build and Install")]
    [Display(Name = "Clean before build to prevent errors?")]
    public bool CleanAll { get; set; } = true;

    [Category("Build and Install")]
    [Display(Name = "Clean after build to save disk space?")]
    public bool CleanAllPostBuild { get; set; } = false;

    [Category("Bundle: REDmod")]
    [Display(Name = "Pack as REDmod")]
    public bool IsRedmod { get; set; }

    [Category("Bundle: REDmod")]
    [Display(Name = "Deploy as REDmod")]
    public bool DeployWithRedmod { get; set; }

    [Category("Game Launch")]
    [Display(Name = "Launch Game")]
    public bool LaunchGame { get; set; }

    private bool _loadLastSave;
    [Category("Game Launch")]
    [Display(Name = "Load last savegame")]
    public bool LoadLastSave
    {
        get => _loadLastSave;
        set
        {
            if (value)
            {
                _loadSpecificSave = false;
            }

            _loadLastSave = value;
        }
    }

    private bool _loadSpecificSave;

    [Category("Game Launch")]
    [Display(Name = "Load specific savegame")]
    public bool LoadSpecificSave
    {
        get => _loadSpecificSave;
        set
        {
            if (value)
            {
                _loadLastSave = false;
            }

            _loadSpecificSave = value;
            OnPropertyChanged(nameof(LoadSpecificSave));
        }
    }

    [Category("Game Launch")]
    [property: Browsable(false)]
    [Display(Name = "Load last savegame: Which?")]
    public string? LoadSaveName
    {
        get;
        set;
    }

    [Category("Game Launch")]
    [Display(Name = "Game Commandline Arguments")]
    public string? GameArguments { get; set; }


    [property: Browsable(false)] public int? Order { get; set; }


    internal LaunchProfile Copy()
    {
        return new LaunchProfile()
        {
            CreateBackup = CreateBackup,
            CleanAll = CleanAll,
            CleanAllPostBuild = CleanAllPostBuild,
            Install = Install,
            IsRedmod = IsRedmod,
            DeployWithRedmod = DeployWithRedmod,
            LaunchGame = LaunchGame,
            LoadLastSave = LoadLastSave,
            GameArguments = GameArguments
        };
    }

    public void SwitchPosition(LaunchProfile otherProfile) => (Order, otherProfile.Order) = (otherProfile.Order, Order);

    public event PropertyChangedEventHandler? PropertyChanged;

    protected virtual void OnPropertyChanged(string? propertyName = null) =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
}
