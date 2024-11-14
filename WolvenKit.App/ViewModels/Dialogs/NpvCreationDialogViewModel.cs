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

    public NpvBodyGender BodyGender = NpvBodyGender.Female;

    public int Eyes = 0;
    public int Nose = 0;
    public int Mouth = 0;
    public int Jaw = 0;
    public int Ears = 0;

    public NpvCreationDialogViewModel()
    {
    }

    public void RefreshVisibility() => CanSave = !string.IsNullOrEmpty(DestFolderPath);
}