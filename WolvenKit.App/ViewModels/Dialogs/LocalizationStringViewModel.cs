using System.ComponentModel;
using CommunityToolkit.Mvvm.ComponentModel;

namespace WolvenKit.App.ViewModels.Dialogs;

public partial class LocalizationStringViewModel : ObservableObject
{
    [ObservableProperty] private string _femaleVariant = "";
    [ObservableProperty] private string _maleVariant = "";
    [ObservableProperty] private string _secondaryKey = "";
    [ObservableProperty] private bool _isValid = false;

    protected override void OnPropertyChanged(PropertyChangedEventArgs e)
    {
        CalculateIsValid();
        base.OnPropertyChanged(e);
    }

    private void CalculateIsValid()
    {
        IsValid = !string.IsNullOrWhiteSpace(SecondaryKey) &&
                  !(string.IsNullOrWhiteSpace(FemaleVariant) && string.IsNullOrWhiteSpace(MaleVariant));
    }
}
