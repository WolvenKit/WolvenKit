using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using CommunityToolkit.Mvvm.ComponentModel;
using WolvenKit.App.Extensions;
using WolvenKit.App.Helpers;
using WolvenKit.App.Models.ProjectManagement.Project;

namespace WolvenKit.App.ViewModels.Dialogs;

public enum CharacterCreatorCheekMakeupColors
{
    None,
    Brown,
    Pink,
    Red,
    Goldenbrown,
    Peach,
    Raspberry,
    Magenta,
    Green
}

// ReSharper disable InconsistentNaming
public enum CharacterCreatorFreckleColors
{
    Brown_02,
    Brown_01,
    Black_02,
    Black_01,
    Red_02,
    Red_01
}

public partial class NpvCreationDialogViewModel : DialogViewModel
{
    [ObservableProperty] private Dictionary<string, string> _projectFolders = [];

    // TODO: Populate these on creation
    [ObservableProperty] private Dictionary<string, string> _eyeColorListBoxItems = [];
    [ObservableProperty] private Dictionary<string, string> _eyelashColorListBoxItems = [];
    [ObservableProperty] private Dictionary<string, string> _eyeMakeupColorListBoxItems = [];
    [ObservableProperty] private Dictionary<string, string> _lipstickColorListBoxItems = [];
    [ObservableProperty] private Dictionary<string, string> _cheekMakeupDropdownOptions = [];

    [ObservableProperty] private string _destFolderPath = "";
    [ObservableProperty] private string _name = "";

    [ObservableProperty] private int _eyes = 0;
    [ObservableProperty] private int _nose = 0;
    [ObservableProperty] private int _mouth = 0;
    [ObservableProperty] private int _jaw = 0;
    [ObservableProperty] private int _ears = 0;

    [ObservableProperty] private int _hair = 0;
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
    [ObservableProperty] private int _boobs = 0;
    [ObservableProperty] private int _genitalSize = 0;
    [ObservableProperty] private int _pubicHair = 0;
    [ObservableProperty] private int _bodyScars = 0;
    [ObservableProperty] private int _nipples = 0;

    [ObservableProperty] private string _eyeColor = "";
    [ObservableProperty] private string _eyelashColor = "";
    [ObservableProperty] private string _lipstickColor = "";
    [ObservableProperty] private string _cheekMakeupColor = "";

    [ObservableProperty] private string _hairColor = "";
    [ObservableProperty] private string _beardColor = "";
    [ObservableProperty] private string _pubicHairColor = "";

    [ObservableProperty] private string _bodyGender = "Female";
    [ObservableProperty] private bool _bodyGenderMale = false;

    [ObservableProperty] private bool _isEyeMakeupEnabled = false;
    [ObservableProperty] private bool _isLipMakeupEnabled = false;
    [ObservableProperty] private bool _isCheekMakeupEnabled = false;
    [ObservableProperty] private bool _isFrecklesEnabled = false;
    [ObservableProperty] private bool _isBeardEnabled = false;
    [ObservableProperty] private bool _isPensiEnabled = false;
    [ObservableProperty] private bool _isPubesEnabled = false;


    [ObservableProperty] private bool _formValid = false;

    public NpvCreationDialogViewModel(Cp77Project activeProject)
    {
        ProjectFolders = activeProject.GetAllFolders(activeProject.ModDirectory).ToDictionary<string, string>(x => x);
        // TODO: Set EyeColorListBoxItems from mesh appearances of eye mesh
        // TODO: Set EyelashColorListBoxItems from mesh materials of eye mesh
        // TODO: Set EyeMakeupColorListBoxItems from mesh materials of eye make-up mesh
        // TODO: Set LipstickColorListBoxItems from mesh materials of lip make-up mesh
    }

    private bool CanSave()
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
        switch (e.PropertyName)
        {
            case nameof(BodyGender):
                BodyGenderMale = BodyGender == "Male";
                break;
            case nameof(EyeMakeup):
                IsEyeMakeupEnabled = EyeMakeup > 0;
                break;
            case nameof(LipMakeup):
                IsLipMakeupEnabled = LipMakeup > 0;
                break;
            case nameof(Genitals):
                IsPensiEnabled = Genitals > 1; // 0 = off, 1 = vagina
                break;
            case nameof(PubicHair):
                IsPubesEnabled = PubicHair > 0;
                break;
            case nameof(Beard):
                IsBeardEnabled = Beard > 0;
                break;
            case nameof(CheekMakeup):
                IsCheekMakeupEnabled = CheekMakeup > 0;
                IsFrecklesEnabled = CheekMakeup is > 0 and <= 4;
                CheekMakeupDropdownOptions.Clear();
                if (CheekMakeup > 4)
                {
                    StringHelper.GetEnumValues(typeof(CharacterCreatorCheekMakeupColors))
                        .ForEach(v => CheekMakeupDropdownOptions.Add(v, v.ToLower()));
                }
                else
                {
                    StringHelper.GetEnumValues(typeof(CharacterCreatorFreckleColors))
                        .ForEach(v => CheekMakeupDropdownOptions.Add(v, v.ToLower()));
                }

                break;
        }

        FormValid = CanSave();

        base.OnPropertyChanged(e);
    }
}
