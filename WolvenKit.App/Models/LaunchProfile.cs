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
                LoadSaveName = null;
            }

            _loadLastSave = value;
        }
    }

    private string? _loadSaveName;
    [Category("Game Launch")]
    [Display(Name = "Load specific savegame")]
    public string? LoadSaveName
    {
        get => _loadSaveName;
        set
        {
            if (value is not null)
            {
                LoadLastSave = false;
            }

            _loadSaveName = value;
        }
    }

    [Category("Game Launch")]
    [Display(Name = "Game Commandline Arguments")]
    public string? GameArguments { get; set; }

    [property: Browsable(false)] public int? Order { get; set; }

    internal LaunchProfile Copy() => (LaunchProfile)MemberwiseClone();

    public void SwitchPosition(LaunchProfile otherProfile) => (Order, otherProfile.Order) = (otherProfile.Order, Order);

    public event PropertyChangedEventHandler? PropertyChanged;

    protected virtual void OnPropertyChanged(string? propertyName = null) =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
}
