#nullable enable
using System.Windows;
using WolvenKit.App.ViewModels.Dialogs;

namespace WolvenKit.Views.Dialogs;

public partial class SceneInputDialogView : Window
{
    public SceneInputDialogViewModel ViewModel { get; set; }

    public SceneInputDialogView(
        string title, 
        string primaryLabel, 
        string primaryDefaultValue = "",
        bool showSecondaryInput = false,
        string secondaryLabel = "Secondary:",
        string checkboxText = "Enable secondary input")
    {
        ViewModel = new SceneInputDialogViewModel(title, primaryLabel, primaryDefaultValue, showSecondaryInput, secondaryLabel, checkboxText);
        DataContext = ViewModel;
        InitializeComponent();
    }

    // Convenience properties for easy access
    public string? PrimaryInput => ViewModel.PrimaryInputValue;
    public bool EnableSecondaryInput => ViewModel.EnableSecondaryInput;
    public string? SecondaryInput => ViewModel.SecondaryInputValue;

    public bool? ShowDialog(Window owner)
    {
        Owner = owner;
        return ShowDialog();
    }
}
