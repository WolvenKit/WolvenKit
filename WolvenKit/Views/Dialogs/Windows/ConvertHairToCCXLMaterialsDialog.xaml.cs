using System.Windows.Input;
using ReactiveUI;
using System.Windows;
using WolvenKit.App.ViewModels.Dialogs;
using WolvenKit.App.Models.ProjectManagement.Project;

namespace WolvenKit.Views.Dialogs.Windows;
/// <summary>
/// Interaction logic for ConvertToCCXLMaterials.xaml
/// </summary>
public partial class ConvertHairToCCXLMaterialsDialog : IViewFor<ConvertHairToCCXLMaterialsDialogViewModel>
{
    public ConvertHairToCCXLMaterialsDialog(Cp77Project activeProject)
    {
        InitializeComponent();
        ViewModel = new ConvertHairToCCXLMaterialsDialogViewModel(activeProject);
        DataContext = ViewModel;
    }

    public ConvertHairToCCXLMaterialsDialogViewModel ViewModel { get; set; }
    object IViewFor.ViewModel { get => ViewModel; set => ViewModel = (ConvertHairToCCXLMaterialsDialogViewModel)value; }

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
