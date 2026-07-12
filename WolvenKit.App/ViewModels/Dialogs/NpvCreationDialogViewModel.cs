using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using CommunityToolkit.Mvvm.ComponentModel;
using WolvenKit.App.Models.ProjectManagement.Project;

namespace WolvenKit.App.ViewModels.Dialogs;

public partial class NpvCreationDialogViewModel : DialogViewModel
{
    [ObservableProperty] private Dictionary<string, string> _projectFolders = [];

    [ObservableProperty] private string _destFolderPath = "";
    [ObservableProperty] private string _name = "";

    [ObservableProperty] private int _eyes = 0;
    [ObservableProperty] private int _nose = 0;
    [ObservableProperty] private int _mouth = 0;
    [ObservableProperty] private int _jaw = 0;
    [ObservableProperty] private int _ears = 0;

    [ObservableProperty] private int _beard = 0;
    [ObservableProperty] private int _beardStyle = 0;
    [ObservableProperty] private int _cyberware = 0;
    [ObservableProperty] private int _facialScars = 0;
    [ObservableProperty] private int _facialTattoos = 0;
    [ObservableProperty] private int _piercings = 0;
    [ObservableProperty] private int _eyeMakeup = 0;
    [ObservableProperty] private int _lipMakeup = 0;
    [ObservableProperty] private int _cheekMakeup = 0;

    [ObservableProperty] private int _blemishes = 0;
    [ObservableProperty] private int _nails = 0;
    [ObservableProperty] private int _genitals = 0;
    [ObservableProperty] private int _genitalSize = 0;
    [ObservableProperty] private int _pubicHair = 0;
    [ObservableProperty] private int _bodyScars = 0;
    [ObservableProperty] private int _nipples = 0;

    [ObservableProperty] private string _bodyGender = "Female";
    [ObservableProperty] private bool _bodyGenderMale = false;

    public bool CanSave()
    {
        if (string.IsNullOrEmpty(DestFolderPath) ||
            string.IsNullOrEmpty(Name))
        {
            return false;
        }

        return true;
    }

    protected override void OnPropertyChanged(PropertyChangedEventArgs e)
    {
        if (e.PropertyName == nameof(BodyGender))
        {
            BodyGenderMale = BodyGender == "Male";
        }

        base.OnPropertyChanged(e);
    }
}
