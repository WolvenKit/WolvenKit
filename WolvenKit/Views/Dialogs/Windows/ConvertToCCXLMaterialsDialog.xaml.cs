using System.Windows.Input;
using ReactiveUI;
using System.Windows;
using WolvenKit.App.ViewModels.Dialogs;
using System.Collections.Generic;
using WolvenKit.App.Models.ProjectManagement.Project;
using CommunityToolkit.Mvvm.ComponentModel;

namespace WolvenKit.Views.Dialogs.Windows;
/// <summary>
/// Interaction logic for ConvertToCCXLMaterials.xaml
/// </summary>
public partial class ConvertToCCXLMaterialsDialog : IViewFor<ConvertToCCXLMaterialsDialogViewModel>
{
    private static bool s_IsCap = false;

    public ConvertToCCXLMaterialsDialog(Cp77Project activeProject)
    {
        InitializeComponent();
        ViewModel = new ConvertToCCXLMaterialsDialogViewModel(activeProject)
        {
            IsCap = s_IsCap

        };
        DataContext = ViewModel;

        MainMiMaterialTypeBox.ItemsSource = new List<string> { "braid", "cap", "cap01", "curls", "dread", "long", "short", "brows", "lashes" };
        
    }

    public ConvertToCCXLMaterialsDialogViewModel ViewModel { get; set; }
    object IViewFor.ViewModel { get => ViewModel; set => ViewModel = (ConvertToCCXLMaterialsDialogViewModel)value; }
    public bool? ShowDialog(Window owner)
    {
        Owner = owner;
        return ShowDialog();
    }
    private void WizardPage_PreviewKeyDown(object sender, KeyEventArgs e)
    {
        if (e.Key != Key.Enter)
        {
            return;
        }

        e.Handled = true;
        DialogResult = true;
        Close();
    }

    private void WizardControl_OnFinish(object sender, RoutedEventArgs e) 
    { 
    }
}
