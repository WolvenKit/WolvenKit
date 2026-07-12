using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reactive.Disposables;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Navigation;
using ReactiveUI;
using Splat;
using WolvenKit.App.Helpers;
using WolvenKit.App.Models.ProjectManagement.Project;
using WolvenKit.App.ViewModels.Dialogs;
using WolvenKit.Core;

namespace WolvenKit.Views.Dialogs.Windows;

/// <summary>
/// Interaction logic für NpvCreationDialog.xaml
/// </summary>
public partial class NpvCreationDialogView : IViewFor<NpvCreationDialogViewModel>
{
    object IViewFor.ViewModel { get => ViewModel; set => ViewModel = (NpvCreationDialogViewModel)value; }


    public NpvCreationDialogView(Cp77Project activeProject)
    {
        InitializeComponent();

        ViewModel = new NpvCreationDialogViewModel(activeProject);
        DataContext = ViewModel;

        this.WhenActivated(disposables =>
        {
            this.Bind(ViewModel,
                    x => x.Eyes,
                    x => x.ComboboxEyes.SelectedIndex)
                .DisposeWith(disposables);
            this.Bind(ViewModel,
                    x => x.Nose,
                    x => x.ComboboxNose.SelectedIndex)
                .DisposeWith(disposables);
            this.Bind(ViewModel,
                    x => x.Mouth,
                    x => x.ComboboxMouth.SelectedIndex)
                .DisposeWith(disposables);
            this.Bind(ViewModel,
                    x => x.Jaw,
                    x => x.ComboboxJaw.SelectedIndex)
                .DisposeWith(disposables);
            this.Bind(ViewModel,
                    x => x.Ears,
                    x => x.ComboboxEars.SelectedIndex)
                .DisposeWith(disposables);
        });
    }

    public bool? ShowDialog(Window owner)
    {
        Owner = owner;
        return ShowDialog();
    }

    public NpvCreationDialogViewModel ViewModel { get; set; }

    private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
    {
        var psi = new System.Diagnostics.ProcessStartInfo { FileName = e.Uri.AbsoluteUri, UseShellExecute = true };
        System.Diagnostics.Process.Start(psi);
        e.Handled = true;
    }

    private void OnCancelButtonClick(object sender, RoutedEventArgs e)
    {
        DialogResult = false;
        Close();
    }

    private void OnKeyDown(object sender, KeyEventArgs e)
    {
        if (e.Key == Key.Enter)
        {
            OnOkButtonClick(null, null);
            return;
        }

        if (e.Key != Key.Escape)
        {
            return;
        }

        OnCancelButtonClick(null, null);
    }

    private void OnOkButtonClick(object sender, RoutedEventArgs e)
    {
        DialogResult = true;
        Close();
    }

    private void WizardControl_OnFinish(object sender, RoutedEventArgs e)
    {
        throw new System.NotImplementedException();
    }

    private void WizardPage_PreviewKeyDown(object sender, KeyEventArgs e)
    {
        // throw new System.NotImplementedException();
    }

    private void OnBodyGenderSelected(object sender, SelectionChangedEventArgs e)
    {
        // throw new System.NotImplementedException();
    }

    private void WizardControl_OnHelpButtonClicked(object sender, RoutedEventArgs e)
    {
        var ps = new ProcessStartInfo(WikiLinks.NPVs) { UseShellExecute = true, Verb = "open" };
        Process.Start(ps);
    }
}
