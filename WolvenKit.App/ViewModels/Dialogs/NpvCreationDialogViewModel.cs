using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using CommunityToolkit.Mvvm.ComponentModel;

namespace WolvenKit.App.ViewModels.Dialogs;

public enum NpvBodyGender
{
    Female = 0,
    Male = 1,
}

public partial class NpvCreationDialogViewModel : DialogViewModel
{
    [ObservableProperty] private string _destFolderPath = "";
    [ObservableProperty] private bool _canSave = false;
    [ObservableProperty] private bool _pageComplete = false;

    [ObservableProperty] private int _currentPage = 0;

    public NpvBodyGender BodyGender = NpvBodyGender.Female;

    public int Eyes = 0;
    public int Nose = 0;
    public int Mouth = 0;
    public int Jaw = 0;
    public int Ears = 0;

    public List<string> CyberwareOptions = ["", "01", "02", "03", "04", "05", "06", "07", "08", "09"];
    public List<string> TattooOptions = ["", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11"];
    public List<string> ScarOptions = ["", "01", "02", "03", "04", "05", "06", "07", "08", "09"];

    public NpvCreationDialogViewModel()
    {
    }

    public void RefreshVisibility()
    {
        PageComplete = !string.IsNullOrEmpty(DestFolderPath);
        CanSave = CurrentPage == 1 && !string.IsNullOrEmpty(DestFolderPath);
    }
}