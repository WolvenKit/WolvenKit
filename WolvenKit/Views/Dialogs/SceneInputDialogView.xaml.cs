#nullable enable
using System.Collections.Generic;
using System.Windows;
using WolvenKit.App.Interaction.Options;
using WolvenKit.App.ViewModels.Dialogs;

namespace WolvenKit.Views.Dialogs;

public partial class SceneInputDialogView : Window
{
    public SceneInputDialogViewModel ViewModel { get; set; }

    public SceneInputDialogView(SceneInputDialogOptions dialogOptions)
    {
        ViewModel = new SceneInputDialogViewModel(dialogOptions);
        DataContext = ViewModel;
        InitializeComponent();
    }

    // Convenience properties for easy access
    public string? PrimaryInput => ViewModel.PrimaryInputValue;
    public bool EnableSecondaryInput => ViewModel.EnableSecondaryInput;
    public string? SecondaryInput => ViewModel.SecondaryInputValue;
    public string? DropdownValue => ViewModel.SelectedDropdownValue;

    public bool? ShowDialog(Window owner)
    {
        Owner = owner;
        return ShowDialog();
    }
}
